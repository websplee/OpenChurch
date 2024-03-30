import { Component, OnInit } from '@angular/core';
import * as FileSaver from 'file-saver';
import autoTable from 'jspdf-autotable';
// import jsPDF from 'jspdf';
import { Table } from 'primeng/table';
import { ConfirmationService, MessageService, SelectItem, SelectItemGroup } from 'primeng/api';
import { RepositoryService } from '../../../core/services/repository.service';
import { Branch } from '../../api/branches/branch';
import { Region } from '../../api/locations/region';
import { Country } from '../../api/locations/country';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { BranchDetailsComponent } from '../branch-details/branch-details.component';

@Component({
  selector: 'app-branches-list',
  templateUrl: './branches-list.component.html',
  styleUrls: ['./branches-list.component.scss']
})
export class BranchesListComponent implements OnInit {

    page_title!: string;
    apiRoute: string = '';

    cols?: any[];
    exportColumns?: any[];
    isLoading: boolean = true;

    branches!: Branch[];
    branch?: Branch;
    selectedBranches?: Branch[];

    countries?: Country[] = [];

    groupedRegions: Region[] = [];

    selectedRegion: Region = {};

    submitted?: boolean;
    activeStateOptions!: any[];
    selectedStatus?: boolean;

    branchDialog!: boolean;
    Delete!: string;

    searchText = '';

    countriesSelectItems: any;

    ref: DynamicDialogRef | undefined;

    constructor(private repository: RepositoryService, private messageService: MessageService, private confirmationService: ConfirmationService, public dialogService: DialogService) {
        this.page_title = 'Branches';
        this.isLoading = true;
        this.branches = [];
        this.branchDialog = false;
        this.activeStateOptions = [{ label: 'Disabled', value: 'off' }, { label: 'Enabled', value: 'on' }];
    }

    ngOnInit(): void {
        // load branches
        this.loadData();

        // load regions
        this.loadDataRegions();
    }

    loadData() {
        this.apiRoute = 'branches/branches';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.branches = results as Branch[];
                this.isLoading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.isLoading = false;
    }

    loadDataRegions() {
        this.apiRoute = 'locations/regions';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.groupedRegions = results as Region[];
                this.isLoading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.isLoading = false;
    }
     

    openNew() {
        this.ref = this.dialogService.open(BranchDetailsComponent, {
            data: {
                region: this.selectedRegion
            },
            header: 'Create New Branch',
            width: '60%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    editBranch(branch: Branch) {
        this.ref = this.dialogService.open(BranchDetailsComponent, {
            data: {
                branch: branch
            },
            header: 'Editing Branch: ' + branch.name,
            width: '60%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    deleteSelectedBranches() {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete the selected User Branch? ' + this.selectedBranches,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.branches = this.branches.filter(val => !this.selectedBranches?.includes(val));
                this.selectedBranches = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Branch Deleted', life: 3000 });
            }
        });
    }


    deleteBranch(branch: Branch) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete <b>' + branch.name + '</b>?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.branches = this.branches.filter(val => val.id !== branch.id);
                this.branch = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'User Branch Deleted', life: 3000 });
            }
        });
    }

    hideDialog() {
        this.branchDialog = false;
        this.submitted = false;
    }

    addBranch() {
        // Implement code to send User Branches to server
        this.messageService.add({ severity: 'info', summary: 'Notice', detail: 'Function ' + this.createId() + ' not yet implemented', life: 4000 })
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.branches.length; i++) {
            if (this.branches[i].id === id) {
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
        id = this.branches.length + 1;
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
                doc.save('BLCI-Branches_' + this.getFullDate(new Date()) + '.pdf');
            })
        })
    }

    // Excel export needs work, such as layout design and proper datatype exporting
    exportExcel() {
        /*import("xlsx").then(xlsx => {
            const workbook = xlsx.utils.book_new();
            // const worksheet = xlsx.utils.aoa_to_sheet(this.users, opts) // Array of Arrays
            const worksheet = xlsx.utils.json_to_sheet(this.branches) // JSON sheet
            // const worksheet = xlsx.utils.table_to_sheet(document.getElementById('#dt1'))  // HTML scraping
            xlsx.utils.book_append_sheet(workbook, worksheet, 'Users')
            const excelBuffer: any = xlsx.writeXLSX(workbook, { type: 'array', bookType: 'xlsx', compression: true, });
            this.saveAsExcelFile(excelBuffer, "BLCIBranchesListing");

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
