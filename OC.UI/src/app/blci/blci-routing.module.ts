import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: 'accounting', loadChildren: () => import('./accounting/accounting.module').then(m => m.AccountingModule) },
    { path: 'branches', loadChildren: () => import('./branches/branches.module').then(m => m.BranchesModule) },
    { path: 'locations', loadChildren: () => import('./locations/locations.module').then(m => m.LocationsModule) },
    { path: 'members', loadChildren: () => import('./members/members.module').then(m => m.MembersModule) },
    { path: 'regions', loadChildren: () => import('./regions/regions.module').then(m => m.RegionsModule) },
    { path: 'settings', loadChildren: () => import('./settings/settings.module').then(m => m.SettingsModule) },
    { path: 'users', loadChildren: () => import('./users/users.module').then(m => m.UsersModule) },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BlciRoutingModule { }
