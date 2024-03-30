import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LeadershipRolesListComponent } from './leadership-roles-list/leadership-roles-list.component';
import { MembersListComponent } from './members-list/members-list.component';

const routes: Routes = [
    { path: 'leadershipRolesList', component: LeadershipRolesListComponent },
    { path: 'membersList', component: MembersListComponent },
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MembersRoutingModule { }
