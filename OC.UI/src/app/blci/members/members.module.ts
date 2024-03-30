import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MembersRoutingModule } from './members-routing.module';
import { MembersComponent } from './members.component';
import { LeadershipRolesListComponent } from './leadership-roles-list/leadership-roles-list.component';
import { LeadershipRoleDetailsComponent } from './leadership-role-details/leadership-role-details.component';
import { SharedModule } from '../../shared/shared.module';
import { MembersListComponent } from './members-list/members-list.component';
import { MemberDetailsComponent } from './member-details/member-details.component';


@NgModule({
  declarations: [
    MembersComponent,
    LeadershipRolesListComponent,
    LeadershipRoleDetailsComponent,
    MembersListComponent,
    MemberDetailsComponent
  ],
  imports: [
    CommonModule,
      MembersRoutingModule,
    SharedModule
  ]
})
export class MembersModule { }
