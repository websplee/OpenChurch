import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BranchesRoutingModule } from './branches-routing.module';
import { BranchesComponent } from './branches.component';
import { BranchesListComponent } from './branches-list/branches-list.component';
import { SharedModule } from '../../shared/shared.module';
import { BranchDetailsComponent } from './branch-details/branch-details.component';
import { MinitriesListComponent } from './minitries-list/minitries-list.component';
import { MinistryDetailsComponent } from './ministry-details/ministry-details.component';
import { ChurchProgramsListComponent } from './church-programs-list/church-programs-list.component';
import { ChurchProgramDetailComponent } from './church-program-detail/church-program-detail.component';
import { ChurchProgramSessionsListComponent } from './church-program-sessions-list/church-program-sessions-list.component';
import { ChurchProgramSessionDetailsComponent } from './church-program-session-details/church-program-session-details.component';
import { ChurchProgramSessionAttendanceDetailsComponent } from './church-program-session-attendance-details/church-program-session-attendance-details.component';
import { ChurchProgramSessionVisitorsDetailsComponent } from './church-program-session-visitors-details/church-program-session-visitors-details.component';
import { ChurchProgramSessionIncomeDetailsComponent } from './church-program-session-income-details/church-program-session-income-details.component';
import { ChurchProgramSessionExpensesDetailsComponent } from './church-program-session-expenses-details/church-program-session-expenses-details.component';
import { ChurchProgramSessionPledgesDetailsComponent } from './church-program-session-pledges-details/church-program-session-pledges-details.component';


@NgModule({
  declarations: [
    BranchesComponent,
    BranchesListComponent,
    BranchDetailsComponent,
    MinitriesListComponent,
    MinistryDetailsComponent,
    ChurchProgramsListComponent,
    ChurchProgramDetailComponent,
    ChurchProgramSessionsListComponent,
    ChurchProgramSessionDetailsComponent,
    ChurchProgramSessionAttendanceDetailsComponent,
    ChurchProgramSessionVisitorsDetailsComponent,
    ChurchProgramSessionIncomeDetailsComponent,
    ChurchProgramSessionExpensesDetailsComponent,
    ChurchProgramSessionPledgesDetailsComponent,
  ],
  imports: [
    CommonModule,
      BranchesRoutingModule,
    SharedModule
  ]
})
export class BranchesModule { }
