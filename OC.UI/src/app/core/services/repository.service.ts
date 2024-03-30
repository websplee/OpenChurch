import {
  HttpClient,
  HttpEvent,
  HttpHeaders,
  HttpRequest
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NbAuthService, NbAuthToken } from '@nebular/auth';
import { Observable, map } from 'rxjs';
import { environment } from '../../../environments/environment';

@Injectable({ providedIn: 'root' })
export class RepositoryService {
  private headers: HttpHeaders = new HttpHeaders();
    private JWT: any;
    private apiURL: string = environment.apiURL + '/' + environment.apiVersion;

  constructor(private http: HttpClient, private authService: NbAuthService) {}

  public getData(route: string, isDownload: boolean = false) {
    this.generateHeaders();
      if (isDownload)
          return this.http.get(this.createCompleteRoute(route, this.apiURL), {
              headers: this.headers,
              reportProgress: true
          });
      else {
          var response = this.http.get<any>(this.createCompleteRoute(route, this.apiURL), {
              headers: this.headers
          })

          if (response.pipe(map(d => d.IsSucess)))
              return response.pipe(map(data => data.Result))
          else
              return response.pipe(map(data => data))
      }
  }

  public getDataDownload(route: string): Observable<HttpEvent<Blob>> {
    this.generateHeaders();
    return this.http.request(
      new HttpRequest(
        'GET',
        this.createCompleteRoute(route, this.apiURL),
        null,
        {
          headers: this.headers,
          reportProgress: true,
          responseType: 'blob'
        }
      )
    );
  }

  public async createUpload(route: string, body: any, isUpload: boolean = false) {
    if (isUpload) {
      this.generateHeadersUpload();
      return await this.http
        .post(this.createCompleteRoute(route, this.apiURL), body, {
          headers: this.headers,
          reportProgress: true
        })
        .toPromise();
    } else {
      this.generateHeaders();
      return await this.http.post(
        this.createCompleteRoute(route, this.apiURL),
        body,
        { headers: this.headers }
      );
    }
  }

  public create(route: string, body: any, isUpload: boolean = false) {
    if (isUpload) {
      this.generateHeadersUpload();
      var response = this.http.post<any>(
        this.createCompleteRoute(route, this.apiURL),
        body,
        { headers: this.headers, reportProgress: true }
      );
        if (response.pipe(map(d => d.IsSucess)))
            return response.pipe(map(data => data.Result))
        else
            return response.pipe(map(data => data))
    } else {
      this.generateHeaders();
      return this.http.post(
        this.createCompleteRoute(route, this.apiURL),
        body,
        { headers: this.headers }
      );
    }
  }

  public update(route: string, body: any) {
    this.generateHeaders();
    return this.http.put(this.createCompleteRoute(route, this.apiURL), body, {
      headers: this.headers
    });
  }

  public delete(route: string) {
    this.generateHeaders();
    return this.http.delete(this.createCompleteRoute(route, this.apiURL), {
      headers: this.headers
    });
  }

  private createCompleteRoute(route: string, apiAddress: string) {
    return `${apiAddress}/${route}`;
  }

  private generateHeaders() {
    const authenticated = this.authService.isAuthenticatedOrRefresh();

    this.JWT = '';

    if (authenticated) {
      this.authService.getToken().subscribe((token: NbAuthToken) => {
        if (token.isValid()) {
          this.JWT = `Bearer ${token.getValue()}`;
        }
      });
    }

    this.headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': '*',
      Authorization: this.JWT
    });
  }

  private generateHeadersUpload() {
    const authenticated = this.authService.isAuthenticatedOrRefresh();

    this.JWT = '';

    if (authenticated) {
      this.authService.getToken().subscribe((token: NbAuthToken) => {
        if (token.isValid()) {
          this.JWT = `Bearer ${token.getValue()}`;
        }
      });
    }

    this.headers = new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
      Authorization: this.JWT
    });
  }
}
