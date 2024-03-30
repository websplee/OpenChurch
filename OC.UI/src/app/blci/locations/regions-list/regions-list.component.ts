import { Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Table } from 'primeng/table';
import { RepositoryService } from '../../../core/services/repository.service';
import { Country } from '../../api/locations/country';
import { Region } from '../../api/locations/region';
import { RegionsDetailsComponent } from '../regions-details/regions-details.component';


@Component({
  selector: 'app-regions-list',
  templateUrl: './regions-list.component.html',
  styleUrls: ['./regions-list.component.scss']
})

export class RegionsListComponent implements OnInit {
    regionDialog: boolean = false;

    deleteRegionDialog: boolean = false;

    deleteRegionsDialog: boolean = false;

    @Input() regions: Region[] = [];

    @Input() country: Country = {};

    region: Region = {};

    selectedRegions: Region[] = [];

    selectedRegion: Region = {} ;

    @Output() onRegionSelectedEvent = new EventEmitter<Region>();

    submitted: boolean = false;

    cols: any[] = [];

    statuses: any[] = [];

    rowsPerPageOptions = [5, 10, 20];

    apiRoute: string = '';

    loading: boolean = false;

    @ViewChild('filter') filter!: ElementRef;

    ref: DynamicDialogRef | undefined;

    constructor(private repository: RepositoryService, private messageService: MessageService, public dialogService: DialogService) { }

    ngOnInit() {
        
        // this.loadData();

        this.cols = [
            { field: 'name', header: 'Name' },
            { field: 'officeLocation', header: 'Office Location' }
        ];

        this.statuses = [
            { label: 'INSTOCK', value: 'instock' },
            { label: 'LOWSTOCK', value: 'lowstock' },
            { label: 'OUTOFSTOCK', value: 'outofstock' }
        ];
    }

    async loadData() {
        this.apiRoute = 'locations/regions';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.regions = results as Region[];
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    openNew() {
        this.ref = this.dialogService.open(RegionsDetailsComponent, {
            data: {
                countryId: this.country.id
            },
            header: 'Create New Region',
            //width: '70%',
            contentStyle: { overflow: 'auto' },
            baseZIndex: 10000,
            maximizable: true
        });
    }

    deleteSelectedRegions() {
        this.deleteRegionsDialog = true;
    }

    editRegion(region: Region) {
        this.region = { ...region };
        this.regionDialog = true;
    }

    deleteRegion(region: Region) {
        this.deleteRegionDialog = true;
        this.region = { ...region };
    }

    confirmDeleteSelected() {
        this.deleteRegionsDialog = false;
        this.regions = this.regions.filter(val => !this.selectedRegions.includes(val));
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Regions Deleted', life: 3000 });
        this.selectedRegions = [];
    }

    onRegionSelected(region: any) {
        this.onRegionSelectedEvent.emit(region);
    }

    confirmDelete() {
        this.deleteRegionDialog = false;
        this.regions = this.regions.filter(val => val.id !== this.region.id);
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Region Deleted', life: 3000 });
        this.region = {};
    }

    hideDialog() {
        this.regionDialog = false;
        this.submitted = false;
    }

    saveRegion() {
        this.submitted = true;

        if (this.region.name?.trim()) {
            if (this.region.id) {
                // @ts-ignore
                this.regions[this.findIndexById(this.region.id)] = this.region;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Region Updated', life: 3000 });
            } else {
                // @ts-ignore
                this.region.inventoryStatus = this.region.inventoryStatus ? this.region.inventoryStatus.value : 'INSTOCK';
                this.regions.push(this.region);
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Region Created', life: 3000 });
            }

            this.regions = [...this.regions];
            this.regionDialog = false;
            this.region = {};
        }
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.regions.length; i++) {
            if (this.regions[i].id === id) {
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
