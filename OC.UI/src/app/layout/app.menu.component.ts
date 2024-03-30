import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { LayoutService } from './service/app.layout.service';

@Component({
    selector: 'app-menu',
    templateUrl: './app.menu.component.html'
})
export class AppMenuComponent implements OnInit {

    model: any[] = [];

    constructor(public layoutService: LayoutService) { }

    ngOnInit() {
        this.model = [
            {
                label: 'Home',
                items: [
                    { label: 'Dashboard', icon: 'pi pi-fw pi-home', routerLink: ['/'] }
                ]
            },
            {
                label: 'Accounting',
                items: [
                    { label: 'Expenses', icon: 'pi pi-fw pi-id-card', routerLink: ['/blci/accounting/expensesList'] },
                    { label: 'Expense Types', icon: 'pi pi-fw pi-check-square', routerLink: ['/blci/accounting/expenseTypesList'] },
                    { label: 'Income', icon: 'pi pi-fw pi-bookmark', routerLink: ['/blci/accounting/incomesList'] },
                    { label: 'Income Types', icon: 'pi pi-fw pi-exclamation-circle', routerLink: ['/blci/accounting/incomeTypesList'] },
                ]
            },
            {
                label: 'Branches',
                items: [
                    { label: 'Branches', icon: 'pi pi-fw pi-eye', routerLink: ['/blocks'], badge: 'NEW' },
                    { label: 'Branch Leadership', icon: 'pi pi-fw pi-globe', url: ['https://crystalisedapps.com'], target: '_blank' },
                    { label: 'Branch Ministry', icon: 'pi pi-fw pi-box', routerLink: ['/uikit/button'] },
                    { label: 'Branch Staff', icon: 'pi pi-fw pi-table', routerLink: ['/uikit/table'] },
                    { label: 'Cell Groups', icon: 'pi pi-fw pi-list', routerLink: ['/uikit/list'] },
                    { label: 'Church Sessions', icon: 'pi pi-fw pi-share-alt', routerLink: ['/blci/branches/cpSessionsList'] },
                    { label: 'Transfers', icon: 'pi pi-fw pi-tablet', routerLink: ['/uikit/panel'] },
                    { label: 'Ministries', icon: 'pi pi-fw pi-clone', routerLink: ['/uikit/overlay'] },

                    
                    /*{ label: 'Menu', icon: 'pi pi-fw pi-bars', routerLink: ['/uikit/menu'], routerLinkActiveOptions: { paths: 'subset', queryParams: 'ignored', matrixParams: 'ignored', fragment: 'ignored' } },
                    { label: 'Message', icon: 'pi pi-fw pi-comment', routerLink: ['/uikit/message'] },
                    { label: 'File', icon: 'pi pi-fw pi-file', routerLink: ['/uikit/file'] },
                    { label: 'Chart', icon: 'pi pi-fw pi-chart-bar', routerLink: ['/uikit/charts'] },
                    { label: 'Misc', icon: 'pi pi-fw pi-circle', routerLink: ['/uikit/misc'] }*/
                ]
            },
            {
                label: 'Members',
                items: [
                    { label: 'Families', icon: 'pi pi-fw pi-prime', routerLink: ['/utilities/icons'] },
                    { label: 'Members', icon: 'pi pi-fw pi-desktop', routerLink: ['/blci/members/membersList']},
                    { label: 'Transactions', icon: 'pi pi-fw pi-image', routerLink: ['/uikit/media'] },
                ]
            },
            {
                label: 'Reports',
                items: [
                    {
                        label: 'Missions Report', icon: 'pi pi-fw pi-bookmark',
                        items: [
                            {
                                label: 'Quarterly Report', icon: 'pi pi-fw pi-bookmark',
                                items: [
                                    { label: 'Member Details', icon: 'pi pi-fw pi-bookmark' },
                                    { label: 'Leadership Details', icon: 'pi pi-fw pi-bookmark' },
                                    { label: 'Income/Earnings', icon: 'pi pi-fw pi-bookmark' },
                                    { label: 'Expenditure', icon: 'pi pi-fw pi-bookmark' },
                                ]
                            },
                            {
                                label: 'Branch Updates', icon: 'pi pi-fw pi-bookmark',
                                items: [
                                    { label: 'Cell', icon: 'pi pi-fw pi-bookmark' }
                                ]
                            },
                        ]
                    },
                    {
                        label: 'Overal Reports', icon: 'pi pi-fw pi-bookmark',
                        items: [
                            {
                                label: 'Submenu 2.1', icon: 'pi pi-fw pi-bookmark',
                                items: [
                                    { label: 'Submenu 2.1.1', icon: 'pi pi-fw pi-bookmark' },
                                    { label: 'Submenu 2.1.2', icon: 'pi pi-fw pi-bookmark' },
                                ]
                            },
                            {
                                label: 'Submenu 2.2', icon: 'pi pi-fw pi-bookmark',
                                items: [
                                    { label: 'Submenu 2.2.1', icon: 'pi pi-fw pi-bookmark' },
                                ]
                            },
                        ]
                    }
                ]
            },
            {
                label: 'Settings',
                icon: 'pi pi-fw pi-briefcase',
                items: [
                    {
                        label: 'Branches',
                        icon: 'pi pi-fw pi-globe',
                        routerLink: ['/blci/branches']
                    },
                    {
                        label: 'Locations',
                        icon: 'pi pi-fw pi-map',
                        items: [
                            {
                                label: 'Regions',
                                icon: 'pi pi-fw pi-map-marker',
                                routerLink: ['/blci/locations/']
                            },
                            {
                                label: 'Countries',
                                icon: 'pi pi-fw pi-sitemap',
                                routerLink: ['/auth/error']
                            },
                        ]
                    },
                    {
                        label: 'Church Core',
                        icon: 'pi pi-fw pi-sync',
                        items: [
                            {
                                label: 'Leadership Roles',
                                icon: 'pi pi-fw pi-telegram',
                                routerLink: ['/blci/members/leadershipRolesList']
                            },
                            {
                                label: 'Ministry',
                                icon: 'pi pi-fw pi-sun',
                                routerLink: ['/blci/branches/ministriesList']
                            },
                            {
                                label: 'Church Programs',
                                icon: 'pi pi-fw pi-reddit',
                                routerLink: ['/blci/branches/churchProgramsList']
                            }
                        ]
                    },
                    {
                        label: 'Users',
                        icon: 'pi pi-fw pi-users',
                        items: [
                            { label: 'PrimeIcons', icon: 'pi pi-fw pi-prime', routerLink: ['/utilities/icons'] },
                            { label: 'PrimeFlex', icon: 'pi pi-fw pi-desktop', url: ['https://www.primefaces.org/primeflex/'], target: '_blank' },
                        ]
                    },
                ]
            },
            {
                label: 'Help',
                items: [
                    {
                        label: 'Documentation', icon: 'pi pi-fw pi-question', routerLink: ['/documentation']
                    },
                    {
                        label: 'FAQ', icon: 'pi pi-fw pi-search', url: ['https://github.com/primefaces/sakai-ng'], target: '_blank'
                    }
                ]
            }
        ];
    }
}
