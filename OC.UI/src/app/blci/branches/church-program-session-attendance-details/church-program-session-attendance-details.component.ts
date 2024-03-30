import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { ChurchProgramSessionAttendance } from '../../api/branches/church-program-session-attendance';

@Component({
  selector: 'app-church-program-session-attendance-details',
  templateUrl: './church-program-session-attendance-details.component.html',
  styleUrls: ['./church-program-session-attendance-details.component.scss']
})
export class ChurchProgramSessionAttendanceDetailsComponent implements OnInit {
    @Input() attendance: ChurchProgramSessionAttendance = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.attendance === undefined) { } else {
            this.attendance = this.config.data.ChurchProgramSessionAttendance as ChurchProgramSessionAttendance;
            this.editing = true;
        }

    }

    closeWindow() {
        this.ref.close();
    }

    saveChurchProgramSessionAttendance() {

        if (this.editing) {
            this.apiRoute = 'branches/ChurchProgramSessionAttendances/';
            this.repository.update(this.apiRoute, this.attendance).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.attendance });
                    this.attendance = {};
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
            console.log(this.attendance);
            this.apiRoute = 'branches/ChurchProgramSessionAttendances/';
            this.repository.create(this.apiRoute, this.attendance).subscribe(
                (results) => {
                    console.log(results);
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.attendance });
                    this.attendance = {};
                },
                (error) => {
                    console.log(error);
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }

    }
}
