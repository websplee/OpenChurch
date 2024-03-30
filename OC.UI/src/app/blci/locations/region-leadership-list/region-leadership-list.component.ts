import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { MessageService } from 'primeng/api';
import { Table } from 'primeng/table';
import { RepositoryService } from '../../../core/services/repository.service';
import { Region } from '../../api/locations/region';
import { RegionLeadership } from '../../api/locations/region-leadership';

@Component({
  selector: 'app-region-leadership-list',
  templateUrl: './region-leadership-list.component.html',
  styleUrls: ['./region-leadership-list.component.scss']
})

export class RegionLeadershipListComponent implements OnInit {

    @Input() region: Region = {};

    regionLeadershipDialog: boolean = false;

    deleteRegionLeadershipDialog: boolean = false;

    deleteRegionLeadershipsDialog: boolean = false;

    regionLeaderships: RegionLeadership[] = [];

    regionLeadership: RegionLeadership = {};

    selectedRegionLeadership: RegionLeadership = {};

    selectedRegionLeaderships: RegionLeadership[] = [];

    submitted: boolean = false;

    cols: any[] = [];

    statuses: any[] = [];

    rowsPerPageOptions = [5, 10, 20];

    apiRoute: string = '';

    loading: boolean = true;

    @ViewChild('filter') filter!: ElementRef;

    constructor(private repository: RepositoryService, private messageService: MessageService) { }

    ngOnInit() {

        this.loadData();

        this.cols = [
            { field: 'id', header: 'Id' },
            { field: 'memberPictureUrl', header: 'Picture' },
            { field: 'leadershipRoleName', header: 'Leadership Role' },
            { field: 'isActive', header: 'Active' }
        ];

        this.statuses = [
            { label: 'INSTOCK', value: 'instock' },
            { label: 'LOWSTOCK', value: 'lowstock' },
            { label: 'OUTOFSTOCK', value: 'outofstock' }
        ];
    }

    async loadData() {
        this.apiRoute = 'locations/regionleaderships';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.regionLeaderships = results as RegionLeadership[];
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    openNew() {
        this.regionLeadership = {};
        this.submitted = false;
        this.regionLeadershipDialog = true;
    }

    deleteSelectedRegionLeaderships() {
        this.deleteRegionLeadershipsDialog = true;
    }

    editRegionLeadership(regionLeadership: RegionLeadership) {
        this.regionLeadership = { ...regionLeadership };
        this.regionLeadershipDialog = true;
    }

    deleteRegionLeadership(regionLeadership: RegionLeadership) {
        this.deleteRegionLeadershipDialog = true;
        this.regionLeadership = { ...regionLeadership };
    }

    confirmDeleteSelected() {
        this.deleteRegionLeadershipsDialog = false;
        this.regionLeaderships = this.regionLeaderships.filter(val => !this.selectedRegionLeaderships.includes(val));
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'RegionLeaderships Deleted', life: 3000 });
        this.selectedRegionLeaderships = [];
    }

    confirmDelete() {
        this.deleteRegionLeadershipDialog = false;
        this.regionLeaderships = this.regionLeaderships.filter(val => val.id !== this.regionLeadership.id);
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'RegionLeadership Deleted', life: 3000 });
        this.regionLeadership = {};
    }

    hideDialog() {
        this.regionLeadershipDialog = false;
        this.submitted = false;
    }

    onRegionLeadershipSelected(regionLeadership: RegionLeadership) {

    }

    saveRegionLeadership() {
        this.submitted = true;

        if (this.regionLeadership.memberName?.trim()) {
            if (this.regionLeadership.id) {
                // @ts-ignore
                this.regions[this.findIndexById(this.regionLeadership.id)] = this.regionLeadership;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'RegionLeadership Updated', life: 3000 });
            } else {
                // @ts-ignore
                this.regionLeadership.inventoryStatus = this.regionLeadership.inventoryStatus ? this.regionLeadership.inventoryStatus.value : 'INSTOCK';
                this.regionLeaderships.push(this.regionLeadership);
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'RegionLeadership Created', life: 3000 });
            }

            this.regionLeaderships = [...this.regionLeaderships];
            this.regionLeadershipDialog = false;
            this.regionLeadership = {};
        }
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.regionLeaderships.length; i++) {
            if (this.regionLeaderships[i].id === id) {
                index = i;
                break;
            }
        }

        return index;
    }

    createId(): string {
        let id = '';
        const chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
        for (let i = 0; i < 5; i++) {
            id += chars.charAt(Math.floor(Math.random() * chars.length));
        }
        return id;
    }

    onGlobalFilter(table: Table, event: Event) {
        table.filterGlobal((event.target as HTMLInputElement).value, 'contains');
    }

    clear(table: Table) {
        table.clear();
        this.filter.nativeElement.value = '';
    }
}
