import { Component, Input } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { Country } from '../../api/locations/country';
import { Region } from '../../api/locations/region';

@Component({
  selector: 'app-regions-details',
  templateUrl: './regions-details.component.html',
  styleUrls: ['./regions-details.component.scss']
})
export class RegionsDetailsComponent {
    @Input() region: Region = {};
    @Input() country: Country = {};
    submitted: boolean = false;
    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
                private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    closeWindow() {
        this.ref.close();
    }

    saveRegion() {
        // Set default values
        this.region.isActive = true;
        this.region.countryId = this.config.data.countryId;

        this.apiRoute = 'locations/regions/';
        this.repository.create(this.apiRoute, this.region).subscribe(
            (results) => {
                this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                this.ref.close({ result: this.region });
                this.region = {};
            },
            (error) => {
                this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });                
            }
        );
    }
}
