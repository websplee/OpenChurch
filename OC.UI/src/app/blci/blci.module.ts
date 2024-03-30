import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BlciRoutingModule } from './blci-routing.module';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
      BlciRoutingModule,
      // SharedModule,
  ]
})
export class BlciModule { }
