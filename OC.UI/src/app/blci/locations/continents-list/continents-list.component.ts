import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MessageService } from 'primeng/api';
import { Table } from 'primeng/table';
import { RepositoryService } from '../../../core/services/repository.service';
import { Continent } from '../../api/locations/continent';

@Component({
    selector: 'app-continents-list',
    templateUrl: './continents-list.component.html',
    styleUrls: ['./continents-list.component.scss']
})
export class ContinentsListComponent implements OnInit {
    continentDialog: boolean = false;

    deleteContinentDialog: boolean = false;

    deleteContinentsDialog: boolean = false;

    continents: Continent[] = [];

    continent: Continent = {};

    selectedContinents: Continent[] = [];

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
            { field: 'name', header: 'Name' }
        ];

        this.statuses = [
            { label: 'INSTOCK', value: 'instock' },
            { label: 'LOWSTOCK', value: 'lowstock' },
            { label: 'OUTOFSTOCK', value: 'outofstock' }
        ];
    }

    async loadData() {
        this.apiRoute = 'locations/continents';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {                
                this.continents = results as Continent[];
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    openNew() {
        this.continent = {};
        this.submitted = false;
        this.continentDialog = true;
    }

    deleteSelectedContinents() {
        this.deleteContinentsDialog = true;
    }

    editContinent(continent: Continent) {
        this.continent = { ...continent };
        this.continentDialog = true;
    }

    deleteContinent(continent: Continent) {
        this.deleteContinentDialog = true;
        this.continent = { ...continent };
    }

    confirmDeleteSelected() {
        this.deleteContinentsDialog = false;
        this.continents = this.continents.filter(val => !this.selectedContinents.includes(val));
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Continents Deleted', life: 3000 });
        this.selectedContinents = [];
    }

    confirmDelete() {
        this.deleteContinentDialog = false;
        this.continents = this.continents.filter(val => val.id !== this.continent.id);
        this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Continent Deleted', life: 3000 });
        this.continent = {};
    }

    hideDialog() {
        this.continentDialog = false;
        this.submitted = false;
    }

    saveContinent() {
        this.submitted = true;

        if (this.continent.name?.trim()) {
            if (this.continent.id) {
                // @ts-ignore
                this.continents[this.findIndexById(this.continent.id)] = this.continent;
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Continent Updated', life: 3000 });
            } else {
                // @ts-ignore
                this.continent.inventoryStatus = this.continent.inventoryStatus ? this.continent.inventoryStatus.value : 'INSTOCK';
                this.continents.push(this.continent);
                this.messageService.add({ severity: 'success', summary: 'Successful', detail: 'Continent Created', life: 3000 });
            }

            this.continents = [...this.continents];
            this.continentDialog = false;
            this.continent = {};
        }
    }

    findIndexById(id: number): number {
        let index = -1;
        for (let i = 0; i < this.continents.length; i++) {
            if (this.continents[i].id === id) {
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
