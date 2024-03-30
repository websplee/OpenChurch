import { Injectable } from '@angular/core';
import { NbAccessControl, NbAclService, NbRoleProvider } from '@nebular/security';
import { NbAuthService, NbAuthJWTToken, NbAuthToken } from '@nebular/auth';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RoleProviderService implements NbRoleProvider {
  constructor(private nbAclService: NbAclService, private authService: NbAuthService) {}
  permissions: NbAccessControl = {};

  getRole(): Observable<string> {
    return this.authService.onTokenChange().pipe(
      map((token: NbAuthToken) => {
        this.permissions = token.getPayload()['role'];        
        this.nbAclService.setAccessControl(this.permissions);
        return token.isValid() ? token.getPayload()['role'] : 'guest';
      })
    );
  }
}
