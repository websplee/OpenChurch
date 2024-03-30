import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { NbAuthJWTToken, NbAuthService, NbAuthToken } from '@nebular/auth';
import { NbAccessControl, NbAclService } from '@nebular/security';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private nbAclService: NbAclService, private authService: NbAuthService, private router: Router) {}
  permissions: NbAccessControl = {};

  canActivate() {
    /*return this.authService.isAuthenticated().pipe(
      tap((authenticated) => {
        if (!authenticated) {
          this.router.navigate(['auth/login']);
        }
      })
    );*/

    return this.authService.isAuthenticated()
      .pipe(
        tap(async authenticated => {
          this.authService.getToken().subscribe(
            (token: NbAuthToken) => {
              if (token.isValid()) {
                this.permissions = token.getPayload()['role'];
                this.nbAclService.setAccessControl(this.permissions);
              }
            }
          );
          if (!authenticated) {
            this.router.navigate(['auth/login']);
          }
        }),
      );
  }
}
