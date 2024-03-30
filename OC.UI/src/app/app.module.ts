import { NgModule } from '@angular/core';
import { HashLocationStrategy, LocationStrategy, Location } from '@angular/common';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AppLayoutModule } from './layout/app.layout.module';
import { NotfoundComponent } from './demo/components/notfound/notfound.component';
import { ProductService } from './demo/service/product.service';
import { CountryService } from './demo/service/country.service';
import { CustomerService } from './demo/service/customer.service';
import { EventService } from './demo/service/event.service';
import { IconService } from './demo/service/icon.service';
import { NodeService } from './demo/service/node.service';
import { PhotoService } from './demo/service/photo.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NbAuthJWTInterceptor } from '@nebular/auth';
import { HttpErrorInterceptor } from './core/utils/http-error-interceptor';
import { AuthGuard } from './core/utils/auth-guard';
import { CoreModule } from './core/core.module';
import { ConfirmationService, MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { MessageModule } from 'primeng/message';
import { DialogService } from 'primeng/dynamicdialog';

@NgModule({
    declarations: [
        AppComponent, NotfoundComponent
    ],
    imports: [
        AppRoutingModule,
        AppLayoutModule,
        HttpClientModule,
        ToastModule,
        MessageModule,
        CoreModule.forRoot(),

    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: NbAuthJWTInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: HttpErrorInterceptor, multi: true },
        AuthGuard,
        [Location, { provide: LocationStrategy, useClass: HashLocationStrategy }],
        CountryService, CustomerService, EventService, IconService, NodeService,
        PhotoService, ProductService, MessageService, DialogService, ConfirmationService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
