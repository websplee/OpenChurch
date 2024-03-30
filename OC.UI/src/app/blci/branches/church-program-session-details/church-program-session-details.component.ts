import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-church-program-session-details',
  templateUrl: './church-program-session-details.component.html',
  styleUrls: ['./church-program-session-details.component.scss']
})
export class ChurchProgramSessionDetailsComponent implements OnInit {
    items: MenuItem[] = [];

    activeItem: MenuItem = {};
;

    ngOnInit() {
        this.items = [
            { label: 'Attendance', icon: 'pi pi-fw pi-check-circle' },
            { label: 'Vistors', icon: 'pi pi-fw pi-calendar-plus' },
            { label: 'Income', icon: 'pi pi-fw pi-sort-amount-up-alt' },
            { label: 'Pledges', icon: 'pi pi-fw pi-sort-amount-up-alt' },
            { label: 'Expenses', icon: 'pi pi-fw pi-sort-amount-down' }
        ];

        this.activeItem = this.items[0];
    }

    onActiveItemChange(event: any) {
        this.activeItem = event;
    }

    activateLast() {
        this.activeItem = this.items[this.items.length - 1];
    }
}
