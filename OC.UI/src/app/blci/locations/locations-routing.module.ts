import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContinentsDetailsComponent } from './continents-details/continents-details.component';
import { ContinentsListComponent } from './continents-list/continents-list.component';
import { CountriesDetailsComponent } from './countries-details/countries-details.component';
import { CountriesListComponent } from './countries-list/countries-list.component';
import { LocationsHomeComponent } from './locations-home/locations-home.component';
import { LocationsComponent } from './locations.component';

const routes: Routes = [
    { path: '', component: LocationsHomeComponent },
    { path: 'continents', component: ContinentsListComponent },
    { path: 'countries', component: CountriesListComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LocationsRoutingModule { }
