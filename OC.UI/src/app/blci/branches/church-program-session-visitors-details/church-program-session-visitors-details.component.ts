import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { ChurchProgramSessionVisitor } from '../../api/branches/church-program-session-visitor';

@Component({
  selector: 'app-church-program-session-visitors-details',
  templateUrl: './church-program-session-visitors-details.component.html',
  styleUrls: ['./church-program-session-visitors-details.component.scss']
})
export class ChurchProgramSessionVisitorsDetailsComponent implements OnInit {
    @Input() visitor: ChurchProgramSessionVisitor = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.visitor === undefined) { } else {
            this.visitor = this.config.data.ChurchProgramSessionVisitor as ChurchProgramSessionVisitor;
            this.editing = true;
        }

    }

    closeWindow() {
        this.ref.close();
    }

    saveChurchProgramSessionVisitor() {

        if (this.editing) {
            this.apiRoute = 'branches/ChurchProgramSessionVisitors/';
            this.repository.update(this.apiRoute, this.visitor).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.visitor });
                    this.visitor = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );

            this.editing = false;
        }
        else {
            // Set default values
            console.log("lets add");
            console.log(this.visitor);
            this.apiRoute = 'branches/ChurchProgramSessionVisitors/';
            this.repository.create(this.apiRoute, this.visitor).subscribe(
                (results) => {
                    console.log(results);
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.visitor });
                    this.visitor = {};
                },
                (error) => {
                    console.log(error);
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }

    }
}
