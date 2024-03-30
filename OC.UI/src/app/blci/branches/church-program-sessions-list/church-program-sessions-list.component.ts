import { Component, OnInit } from '@angular/core';
import * as FileSaver from 'file-saver';
import autoTable from 'jspdf-autotable';
// import jsPDF from 'jspdf';
import { Table } from 'primeng/table';
import { ConfirmationService, MessageService, SelectItem, SelectItemGroup } from 'primeng/api';
import { RepositoryService } from '../../../core/services/repository.service';
import { Region } from '../../api/locations/region';
import { Country } from '../../api/locations/country';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { ChurchProgramSession } from '../../api/branches/church-program-session';
import { ChurchProgramSessionDetailsComponent } from '../church-program-session-details/church-program-session-details.component';

@Component({
  selector: 'app-church-program-sessions-list',
  templateUrl: './church-program-sessions-list.component.html',
  styleUrls: ['./church-program-sessions-list.component.scss']
})
export class ChurchProgramSessionsListComponent implements OnInit {

    page_title!: string;
    apiRoute: string = '';

    cols?: any[];
    exportColumns?: any[];
    loading!: boolean;

    churchProgramSessions!: ChurchProgramSession[];
    churchProgramSession?: ChurchProgramSession;
    selectedChurchProgramSessions?: ChurchProgramSession[];

    countries?: Country[] = [];

    groupedRegions: Region[] = [];

    selectedRegion: Region = {};

    submitted?: boolean;
    activeStateOptions!: any[];
    selectedStatus?: boolean;

    churchProgramSessionDialog!: boolean;
    Delete!: string;

    searchText = '';

    countriesSelectItems: any;

    ref: DynamicDialogRef | undefined;

    constructor(private repository: RepositoryService, private messageService: MessageService, private confirmationService: ConfirmationService, public dialogService: DialogService) {
        this.page_title = 'Church Program Sessions';
        this.loading = true;
        this.churchProgramSessions = [];
        this.churchProgramSessionDialog = false;
        this.activeStateOptions = [{ label: 'Disabled', value: 'off' }, { label: 'Enabled', value: 'on' }];
    }

    ngOnInit(): void {
        // load churchProgramSessions
        this.loadData();
    }

    loadData() {
        this.apiRoute = 'branches/churchProgramSessions';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.churchProgramSessions = results as ChurchProgramSession[];
                this.loading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    openNew() {
        this.ref = this.dialogService.open(ChurchProgramSessionDetailsComponent, {
            data: {
                region: this.selectedRegion
            },
            header: 'Create New Church Program Session',
            width: '60%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    editChurchProgramSession(churchProgramSession: ChurchProgramSession) {
        this.ref = this.dialogService.open(ChurchProgramSessionDetailsComponent, {
            data: {
                churchProgramSession: churchProgramSession
            },
            header: 'Editing Church Program Session: ' + churchProgramSession.name,
            width: '60%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    deleteSelectedChurchProgramSessions() {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete the selected User ChurchProgramSession? ' + this.selectedChurchProgramSessions,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.churchProgramSessions = this.churchProgramSessions.filter(val => !this.selectedChurchProgramSessions?.includes(val));
                this.selectedChurchProgramSessions = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'ChurchProgramSession Deleted', life: 3000 });
            }
        });
    }


    deleteChurchProgramSession(churchProgramSession: ChurchProgramSession) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete <b>' + churchProgramSession.name + '</b>?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.churchProgramSessions = this.churchProgramSessions.filter(val => val.id !== churchProgramSession.id);
                this.churchProgramSession = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'User ChurchProgramSession Deleted', life: 3000 });
            }
        });
    }

    hideDialog() {
        this.churchProgramSessionDialog = false;
        this.submitted = false;
    }

    addChurchProgramSession() {
        // Implement code to send User ChurchProgramSessions to server
        this.messageService.add({ severity: 'info', summary: 'Notice', detail: 'Function ' + this.createId() + ' not yet implemented', life: 4000 })
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.churchProgramSessions.length; i++) {
            if (this.churchProgramSessions[i].id === id) {
                index = i;
                break;
            }
        }
        return index;
    }

    createId(): number {
        let id: number;
        /* Function to create random ID string
  
        var chars = '0123456789';
        for ( var i = 0; i < 5; i++ ) {
            id += chars.charAt(Math.floor(Math.random() * chars.length));
        }*/
        id = this.churchProgramSessions.length + 1;
        return id;
    }

    /*
      Below are functions to do with file exporting
    */

    exportPdf() {
        import("jspdf").then(jsPDF => {
            import("jspdf-autotable").then(x => {
                const doc = new jsPDF.default('p', 'mm', [0, 0], true);
                autoTable(doc, {
                    html: '#dt',
                    includeHiddenHtml: false,
                    useCss: true,
                    theme: 'striped',
                    startY: 5,
                    margin: undefined,
                    pageBreak: undefined,
                    rowPageBreak: undefined,
                    tableWidth: undefined
                });
                doc.save('BLCI-ChurchProgramSessions_' + this.getFullDate(new Date()) + '.pdf');
            })
        })
    }

    // Excel export needs work, such as layout design and proper datatype exporting
    exportExcel() {
        /*import("xlsx").then(xlsx => {
            const workbook = xlsx.utils.book_new();
            // const worksheet = xlsx.utils.aoa_to_sheet(this.users, opts) // Array of Arrays
            const worksheet = xlsx.utils.json_to_sheet(this.churchProgramSessions) // JSON sheet
            // const worksheet = xlsx.utils.table_to_sheet(document.getElementById('#dt1'))  // HTML scraping
            xlsx.utils.book_append_sheet(workbook, worksheet, 'Users')
            const excelBuffer: any = xlsx.writeXLSX(workbook, { type: 'array', bookType: 'xlsx', compression: true, });
            this.saveAsExcelFile(excelBuffer, "BLCIChurchProgramSessionsListing");

        })*/
    }

    getFullDate(date: Date): string {
        const day = String(date.getDate()).padStart(2, '0');
        const month = String(date.getMonth() + 1).padStart(2, '0');
        const year = String(date.getFullYear());
        const dt = day + '-' + month + '-' + year;
        return dt;
    }

    saveAsExcelFile(buffer: any, fileName: string): void {
        let EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
        let EXCEL_EXTENSION = '.xlsx';
        const data: Blob = new Blob([buffer], {
            type: EXCEL_TYPE
        });
        FileSaver.saveAs(data, fileName + '_[' + this.getFullDate(new Date) + ']' + EXCEL_EXTENSION);
    }

    clear(table: Table) {
        table.clear();
        this.searchText = '';
    }
}
