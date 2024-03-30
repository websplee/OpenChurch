import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LocationsRoutingModule } from './locations-routing.module';
import { ContinentsListComponent } from './continents-list/continents-list.component';
import { CountriesListComponent } from './countries-list/countries-list.component';
import { RegionsListComponent } from './regions-list/regions-list.component';
import { RegionsDetailsComponent } from './regions-details/regions-details.component';
import { CountriesDetailsComponent } from './countries-details/countries-details.component';
import { ContinentsDetailsComponent } from './continents-details/continents-details.component';
import { LocationsComponent } from './locations.component';
import { SharedModule } from '../../shared/shared.module';
import { RegionLeadershipListComponent } from './region-leadership-list/region-leadership-list.component';
import { RegionLeadershipEditComponent } from './region-leadership-edit/region-leadership-edit.component';
import { RegionLeadershipAddComponent } from './region-leadership-add/region-leadership-add.component';
import { LocationsHomeComponent } from './locations-home/locations-home.component';


@NgModule({
  declarations: [
    ContinentsListComponent,
    CountriesListComponent,
    RegionsListComponent,
    RegionsDetailsComponent,
    CountriesDetailsComponent,
    ContinentsDetailsComponent,
    LocationsComponent,
    RegionLeadershipListComponent,
    RegionLeadershipEditComponent,
    RegionLeadershipAddComponent,
    LocationsHomeComponent
  ],
  imports: [
    CommonModule,
      LocationsRoutingModule,
      SharedModule
  ]
})
export class LocationsModule { }
