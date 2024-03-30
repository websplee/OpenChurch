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
import { Member } from '../../api/members/member';
import { MemberDetailsComponent } from '../member-details/member-details.component';

@Component({
  selector: 'app-members-list',
  templateUrl: './members-list.component.html',
  styleUrls: ['./members-list.component.scss']
})
export class MembersListComponent implements OnInit {

    page_title!: string;
    apiRoute: string = '';

    cols?: any[];
    exportColumns?: any[];
    loading!: boolean;

    members!: Member[];
    member?: Member;
    selectedMembers?: Member[];

    countries?: Country[] = [];

    groupedRegions: Region[] = [];

    selectedRegion: Region = {};

    submitted?: boolean;
    activeStateOptions!: any[];
    selectedStatus?: boolean;

    memberDialog!: boolean;
    Delete!: string;

    searchText = '';

    countriesSelectItems: any;

    ref: DynamicDialogRef | undefined;

    constructor(private repository: RepositoryService, private messageService: MessageService, private confirmationService: ConfirmationService, public dialogService: DialogService) {
        this.page_title = 'Members';
        this.loading = true;
        this.members = [];
        this.memberDialog = false;
        this.activeStateOptions = [{ label: 'Disabled', value: 'off' }, { label: 'Enabled', value: 'on' }];
    }

    ngOnInit(): void {
        // load members
        this.loadData();
    }

    loadData() {
        this.apiRoute = 'members/members';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.members = results as Member[];
                this.loading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    openNew() {
        this.ref = this.dialogService.open(MemberDetailsComponent, {
            data: {
                region: this.selectedRegion
            },
            header: 'Create New Member',
            width: '40%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    editMember(member: Member) {
        this.ref = this.dialogService.open(MemberDetailsComponent, {
            data: {
                member: member
            },
            header: 'Editing Member: ' + member.name,
            width: '40%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    deleteSelectedMembers() {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete the selected User Member? ' + this.selectedMembers,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.members = this.members.filter(val => !this.selectedMembers?.includes(val));
                this.selectedMembers = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Member Deleted', life: 3000 });
            }
        });
    }


    deleteMember(member: Member) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete <b>' + member.name + '</b>?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.members = this.members.filter(val => val.id !== member.id);
                this.member = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'User Member Deleted', life: 3000 });
            }
        });
    }

    hideDialog() {
        this.memberDialog = false;
        this.submitted = false;
    }

    addMember() {
        // Implement code to send User Members to server
        this.messageService.add({ severity: 'info', summary: 'Notice', detail: 'Function ' + this.createId() + ' not yet implemented', life: 4000 })
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.members.length; i++) {
            if (this.members[i].id === id) {
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
        id = this.members.length + 1;
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
                doc.save('BLCI-Members_' + this.getFullDate(new Date()) + '.pdf');
            })
        })
    }

    // Excel export needs work, such as layout design and proper datatype exporting
    exportExcel() {
        /*import("xlsx").then(xlsx => {
            const workbook = xlsx.utils.book_new();
            // const worksheet = xlsx.utils.aoa_to_sheet(this.users, opts) // Array of Arrays
            const worksheet = xlsx.utils.json_to_sheet(this.members) // JSON sheet
            // const worksheet = xlsx.utils.table_to_sheet(document.getElementById('#dt1'))  // HTML scraping
            xlsx.utils.book_append_sheet(workbook, worksheet, 'Users')
            const excelBuffer: any = xlsx.writeXLSX(workbook, { type: 'array', bookType: 'xlsx', compression: true, });
            this.saveAsExcelFile(excelBuffer, "BLCIMembersListing");

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
