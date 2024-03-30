import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { RepositoryService } from '../../../core/services/repository.service';
import { LeadershipRole } from '../../api/members/leadership-role';

@Component({
  selector: 'app-leadership-role-details',
  templateUrl: './leadership-role-details.component.html',
  styleUrls: ['./leadership-role-details.component.scss']
})
export class LeadershipRoleDetailsComponent  implements OnInit {
    @Input() leadershipRole: LeadershipRole = {};

    submitted: boolean = false;
    editing: boolean = false;

    apiRoute: string = '';

    constructor(private repository: RepositoryService, private messageService: MessageService,
        private ref: DynamicDialogRef, private config: DynamicDialogConfig) { }

    ngOnInit() {
        if (this.config.data.leadershipRole === undefined) { } else{
            this.leadershipRole = this.config.data.leadershipRole as LeadershipRole;
            this.editing = true;
        }

    }

    closeWindow() {
        this.ref.close();
    }

    saveLeadershipRole() {

        if (this.editing) {
            this.apiRoute = 'members/leadershipRoles/';
            this.repository.update(this.apiRoute, this.leadershipRole).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Edited Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.leadershipRole });
                    this.leadershipRole = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );

            this.editing = false;
        }
        else {
            // Set default values
            this.leadershipRole.isActive = true;

            this.apiRoute = 'members/leadershipRoles/';
            this.repository.create(this.apiRoute, this.leadershipRole).subscribe(
                (results) => {
                    this.messageService.add({ severity: 'success', summary: 'Record Added Successfully', detail: results.toString(), life: 3000 });
                    this.ref.close({ result: this.leadershipRole });
                    this.leadershipRole = {};
                },
                (error) => {
                    this.messageService.add({ severity: 'error', summary: 'Operation Failed', detail: error, life: 3000 });
                }
            );
        }

    }
}
