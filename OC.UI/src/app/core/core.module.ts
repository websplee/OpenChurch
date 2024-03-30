import { CommonModule } from '@angular/common';
import {
    ModuleWithProviders,
    NgModule,
    Optional,
    SkipSelf
} from '@angular/core';
import {
    NbAuthJWTToken,
    NbAuthModule,
    NbPasswordAuthStrategy
} from '@nebular/auth';
import { NbRoleProvider, NbSecurityModule } from '@nebular/security';
import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { environment } from '../../environments/environment';
import { throwIfAlreadyLoaded } from './module-import-guard';
import { RoleProviderService } from './services/role-provider.service';


const socialLinks = [
    {
        url: 'https://github.com/websplee',
        target: '_blank',
        icon: 'github'
    },
    {
        url: 'https://www.facebook.com/websplee/',
        target: '_blank',
        icon: 'facebook'
    },
    {
        url: 'https://twitter.com/websplee',
        target: '_blank',
        icon: 'twitter'
    }
];

export const NB_CORE_PROVIDERS = [
    NbAuthModule.forRoot({
        strategies: [
            NbPasswordAuthStrategy.setup({
                name: 'email',
                token: {
                    class: NbAuthJWTToken,
                    key: 'Result.token'
                },
                // baseEndpoint: `http://localhost:5003/api/v1/users`,
                baseEndpoint: `${environment.apiURL + '/' + environment.apiVersion
                    }/users/users`,
                login: {
                    endpoint: '/authenticate',
                    redirect: {
                        success: '/#/',
                        failure: null
                    }
                },
                logout: {
                    endpoint: '',
                    redirect: {
                        success: '/auth/logout',
                        failure: '/auth/logout'
                    }
                },
                register: {
                    // ...
                    endpoint: '/register'
                },
                resetPass: {
                    endpoint: '/resetpassword',
                    method: 'post',
                    resetPasswordTokenKey: 'token',
                    requireValidToken: false,
                    defaultErrors: ['Something went wrong, please try again.'],
                    defaultMessages: ['Your password has been successfully changed.']
                }
            })
        ],
        forms: {
            login: {
                redirectDelay: 0, // delay before redirect after a successful login,
                // while success message is shown to the user
                strategy: 'email', // strategy id key.
                rememberMe: false, // whether to show or not the `rememberMe` checkbox
                showMessages: {
                    // show/not show success/error messages
                    success: false,
                    error: true
                }
            }
        }
    }).providers,

    NbSecurityModule.forRoot({
        accessControl: {
            user: {
                view: ['deposits']
            },
            users_user: {
                view: ['users']
            },
            users_firstapprover: {
                parent: 'users_user',
                firstapprover: ['users']
            },
            users_secondapprover: {
                parent: 'users_user',
                secondapprover: ['users']
            },
            users_thirdapprover: {
                parent: 'users_user',
                thirdapprover: ['users']
            },
            users_fourthapprover: {
                parent: 'users_user',
                fourthapprover: ['users']
            },
            users_admin: {
                parent: 'users_user',
                create: 'users',
                edit: 'users',
                remove: 'users',
                approve: ['users']
            },
            transactions_user: {
                view: ['transactions']
            },
            transactions_firstapprover: {
                parent: 'transactions_user',
                firstapprover: ['transactions']
            },
            transactions_secondapprover: {
                parent: 'transactions_user',
                secondapprover: ['transactions']
            },
            transactions_thirdapprover: {
                parent: 'transactions_user',
                thirdapprover: ['transactions']
            },
            transactions_fourthapprover: {
                parent: 'transactions_user',
                fourthapprover: ['transactions']
            },
            transactions_admin: {
                parent: 'transactions_user',
                create: 'transactions',
                edit: 'transactions',
                remove: 'inventor',
                approve: ['transactions']
            },
            deposits_user: {
                view: ['deposits']
            },
            deposits_firstapprover: {
                parent: 'deposits_user',
                firstapprover: ['deposits']
            },
            deposits_secondapprover: {
                parent: 'deposits_user',
                secondapprover: ['deposits']
            },
            deposits_thirdapprover: {
                parent: 'deposits_user',
                thirdapprover: ['deposits']
            },
            deposits_fourthapprover: {
                parent: 'deposits_user',
                fourthapprover: ['deposits']
            },
            deposits_admin: {
                parent: 'deposits',
                create: 'deposits',
                edit: 'deposits',
                remove: 'deposits',
                approve: ['deposits']
            },
            agents_user: {
                view: ['agents']
            },
            agents_firstapprover: {
                parent: 'agents_user',
                firstapprover: ['agents']
            },
            agents_secondapprover: {
                parent: 'agents_user',
                secondapprover: ['agents']
            },
            agents_thirdapprover: {
                parent: 'agents_user',
                thirdapprover: ['agents']
            },
            agents_fourthapprover: {
                parent: 'agents_user',
                fourthapprover: ['agents']
            },
            agents_admin: {
                parent: 'agents_user',
                create: 'agents',
                edit: 'agents',
                remove: 'agents',
                approve: ['agents']
            },
            reports_user: {
                view: ['reports']
            },
            reports_secondapprover: {
                parent: 'reports_user',
                secondapprover: ['reports']
            },
            reports_thirdapprover: {
                parent: 'reports_user',
                thirdapprover: ['reports']
            },
            reports_fourthapprover: {
                parent: 'reports_user',
                fourthapprover: ['reports']
            },
            reports_admin: {
                parent: 'reports_user',
                create: 'reports',
                edit: 'reports',
                remove: 'reports',
                approve: ['reports']
            },
            admin_admin: {
                view: '*',
                create: '*',
                edit: '*',
                remove: '*',
                firstapprover: '*',
                secondapprover: '*',
                thirdapprover: '*',
                fourthapprover: '*',
                approver: '*',
                parent: '*'
            },
            admin: {
                view: '*',
                create: '*',
                edit: '*',
                remove: '*',
                firstapprover: '*',
                secondapprover: '*',
                thirdapprover: '*',
                fourthapprover: '*',
                approver: '*',
                parent: '*'
            }
        }
    }).providers,

    {
        provide: NbRoleProvider,
        /*useValue: {
          getRole: () => {
            // here we simply return a list of roles for current user
            token.isValid() ? token.getPayload()['role'] : 'guest';
          },
        },*/
        useClass: RoleProviderService
    }
];

@NgModule({
    imports: [CommonModule],
    exports: [NbAuthModule],
    declarations: []
})
export class CoreModule {
    constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
        throwIfAlreadyLoaded(parentModule, 'CoreModule');
    }

    static forRoot(): ModuleWithProviders<CoreModule> {
        return {
            ngModule: CoreModule,
            providers: [NB_CORE_PROVIDERS]
        };
    }
}
