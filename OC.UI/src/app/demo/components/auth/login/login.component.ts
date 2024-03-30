import { Component } from '@angular/core';
import { NbLoginComponent } from '@nebular/auth';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styles: [`
        :host ::ng-deep .pi-eye,
        :host ::ng-deep .pi-eye-slash {
            transform:scale(1.6);
            margin-right: 1rem;
            color: var(--primary-color) !important;
        }
    `]
})
export class LoginComponent  extends NbLoginComponent{

    /*valCheck: string[] = ['remember'];

    password!: string;

    constructor(public layoutService: LayoutService) { }*/
}
