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
import { LeadershipRole } from '../../api/members/leadership-role';
import { LeadershipRoleDetailsComponent } from '../leadership-role-details/leadership-role-details.component';

@Component({
  selector: 'app-leadership-roles-list',
  templateUrl: './leadership-roles-list.component.html',
  styleUrls: ['./leadership-roles-list.component.scss']
})
export class LeadershipRolesListComponent implements OnInit {

    page_title!: string;
    apiRoute: string = '';

    cols?: any[];
    exportColumns?: any[];
    loading!: boolean;

    leadershipRoles!: LeadershipRole[];
    leadershipRole?: LeadershipRole;
    selectedLeadershipRoles?: LeadershipRole[];
    selectedLeadershipRole?: LeadershipRole;
;

    submitted?: boolean;
    activeStateOptions!: any[];
    selectedStatus?: boolean;

    leadershipRoleDialog!: boolean;
    Delete!: string;

    searchText = '';

    ref: DynamicDialogRef | undefined;

    constructor(private repository: RepositoryService, private messageService: MessageService, private confirmationService: ConfirmationService, public dialogService: DialogService) {
        this.page_title = 'Leadership Roles';
        this.loading = true;
        this.leadershipRoles = [];
        this.leadershipRoleDialog = false;
        this.activeStateOptions = [{ label: 'Disabled', value: 'off' }, { label: 'Enabled', value: 'on' }];
    }

    ngOnInit(): void {
        // load leadershipRoles
        this.loadData();
    }

    loadData() {
        this.apiRoute = 'members/leadershipRoles';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.leadershipRoles = results as LeadershipRole[];
                this.loading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }


    openNew() {
        this.ref = this.dialogService.open(LeadershipRoleDetailsComponent, {
            
            header: 'Create New Leadership Role',
            width: '40%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    editLeadershipRole(leadershipRole: LeadershipRole) {
        this.ref = this.dialogService.open(LeadershipRoleDetailsComponent, {
            data: {
                leadershipRole: leadershipRole
            },
            header: 'Editing Leadership Role: ' + leadershipRole.name,
            width: '40%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    deleteSelectedLeadershipRoles() {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete the selected User LeadershipRole? ' + this.selectedLeadershipRoles,
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.leadershipRoles = this.leadershipRoles.filter(val => !this.selectedLeadershipRoles?.includes(val));
                this.selectedLeadershipRoles = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'LeadershipRole Deleted', life: 3000 });
            }
        });
    }


    deleteLeadershipRole(leadershipRole: LeadershipRole) {
        this.confirmationService.confirm({
            message: 'Are you sure you want to delete <b>' + leadershipRole.name + '</b>?',
            header: 'Confirm',
            icon: 'pi pi-exclamation-triangle',
            accept: () => {
                this.leadershipRoles = this.leadershipRoles.filter(val => val.id !== leadershipRole.id);
                this.leadershipRole = undefined;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'User LeadershipRole Deleted', life: 3000 });
            }
        });
    }


    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.leadershipRoles.length; i++) {
            if (this.leadershipRoles[i].id === id) {
                index = i;
                break;
            }
        }
        return index;
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
                doc.save('BLCI-LeadershipRoles_' + this.getFullDate(new Date()) + '.pdf');
            })
        })
    }

    // Excel export needs work, such as layout design and proper datatype exporting
    exportExcel() {
        /*import("xlsx").then(xlsx => {
            const workbook = xlsx.utils.book_new();
            // const worksheet = xlsx.utils.aoa_to_sheet(this.users, opts) // Array of Arrays
            const worksheet = xlsx.utils.json_to_sheet(this.leadershipRoles) // JSON sheet
            // const worksheet = xlsx.utils.table_to_sheet(document.getElementById('#dt1'))  // HTML scraping
            xlsx.utils.book_append_sheet(workbook, worksheet, 'Users')
            const excelBuffer: any = xlsx.writeXLSX(workbook, { type: 'array', bookType: 'xlsx', compression: true, });
            this.saveAsExcelFile(excelBuffer, "BLCILeadershipRolesListing");

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
