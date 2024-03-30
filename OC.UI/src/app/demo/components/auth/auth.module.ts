import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthRoutingModule } from './auth-routing.module';
import { NbAuthModule } from '@nebular/auth';

@NgModule({
    imports: [
        CommonModule,
        NbAuthModule,
        AuthRoutingModule
    ]
})
export class AuthModule { }
