import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { Branch } from '../../api/branches/branch';
import { Country } from '../../api/locations/country';
import { Region } from '../../api/locations/region';

@Component({
  selector: 'app-branch-details',
  templateUrl: './branch-details.component.html',
  styleUrls: ['./branch-details.component.scss']
})
export class BranchDetailsComponent implements OnInit {
    @Input() branch: Branch = {};
    @Input() region: Region = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.branch) {
            this.branch = this.config.data.branch as Branch;
            this.editing = true;
        }
            
    }

    closeWindow() {
        this.ref.close();
    }

    saveBranch() {

        if (this.editing) {
            this.apiRoute = 'branches/branches/';
            this.repository.update(this.apiRoute, this.branch).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.branch });
                    this.branch = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );

            this.editing = false;
        }
        else {
            // Set default values
            this.branch.isActive = true;

            this.apiRoute = 'branches/branches/';
            this.repository.create(this.apiRoute, this.branch).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.branch });
                    this.branch = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }
        
    }
}
