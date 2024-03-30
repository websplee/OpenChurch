import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BranchesListComponent } from './branches-list/branches-list.component';
import { ChurchProgramSessionsListComponent } from './church-program-sessions-list/church-program-sessions-list.component';
import { ChurchProgramsListComponent } from './church-programs-list/church-programs-list.component';
import { MinitriesListComponent } from './minitries-list/minitries-list.component';

const routes: Routes = [
    { path: '', component: BranchesListComponent },
    { path: 'ministriesList', component: MinitriesListComponent },
    { path: 'churchProgramsList', component: ChurchProgramsListComponent },
    { path: 'cpSessionsList', component: ChurchProgramSessionsListComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BranchesRoutingModule { }
