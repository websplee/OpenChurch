import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { Member } from '../../api/members/member';


@Component({
  selector: 'app-member-details',
  templateUrl: './member-details.component.html',
  styleUrls: ['./member-details.component.scss']
})

export class MemberDetailsComponent implements OnInit {
    @Input() member: Member = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.member === undefined) { } else {
            this.member = this.config.data.member as Member;
            this.editing = true;
        }

    }

    closeWindow() {
        this.ref.close();
    }

    saveMember() {

        if (this.editing) {
            this.apiRoute = 'members/members/';
            this.repository.update(this.apiRoute, this.member).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.member });
                    this.member = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );

            this.editing = false;
        }
        else {
            // Set default values
            this.member.isActive = true;
            console.log("lets add");
            console.log(this.member);
            this.apiRoute = 'members/members/';
            this.repository.create(this.apiRoute, this.member).subscribe(
                (results) => {
                    console.log(results);
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.member });
                    this.member = {};
                },
                (error) => {
                    console.log(error);
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }

    }
}
