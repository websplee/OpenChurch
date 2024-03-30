import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { Ministry } from '../../api/branches/ministry';

@Component({
  selector: 'app-ministry-details',
  templateUrl: './ministry-details.component.html',
  styleUrls: ['./ministry-details.component.scss']
})
export class MinistryDetailsComponent  implements OnInit {
    @Input() ministry: Ministry = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.ministry === undefined) { } else {
            this.ministry = this.config.data.ministry as Ministry;
            this.editing = true;
        }

    }

    closeWindow() {
        this.ref.close();
    }

    saveMinistry() {

        if (this.editing) {
            this.apiRoute = 'branches/ministries/';
            this.repository.update(this.apiRoute, this.ministry).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.ministry });
                    this.ministry = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );

            this.editing = false;
        }
        else {
            // Set default values
            this.ministry.isActive = true;
            console.log("lets add");
            console.log(this.ministry);
            this.apiRoute = 'branches/ministries/';
            this.repository.create(this.apiRoute, this.ministry).subscribe(
                (results) => {
                    console.log(results);
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.ministry });
                    this.ministry = {};
                },
                (error) => {
                    console.log(error);
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }

    }
}
