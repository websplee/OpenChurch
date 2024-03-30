import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { MessageService } from 'primeng/api';
import { RepositoryService } from '../../../core/services/repository.service';
import { Country } from '../../api/locations/country';
import { Region } from '../../api/locations/region';

@Component({
  selector: 'app-countries-list',
  templateUrl: './countries-list.component.html',
})
export class CountriesListComponent implements OnInit {
    constructor(
        private repository: RepositoryService,
        private messageService: MessageService
    ) { }

    apiRoute: string = '';
    loading: boolean = true;
    countries: Country[] = [];
    selectedCountry: Country = {};
    @Output() onCountrySelectedEvent = new EventEmitter<Country>();

    ngOnInit() {
        this.loadData();
    }

    loadData() {
        this.apiRoute = 'locations/countries';
        this.repository.getData(this.apiRoute).subscribe(
            (results) => {
                this.countries = results as Country[];
                this.onCountrySelectedEvent.emit(this.countries[0] as Country);
                this.loading = false;
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'API Failure', detail: 'Failed to fetch data from API', life: 3000 });
            }
        );
        this.loading = false;
    }

    onClick(country: any) {
        this.selectedCountry = country.value;
        this.onCountrySelectedEvent.emit(this.selectedCountry as Country);
    }
}
