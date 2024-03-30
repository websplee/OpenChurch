import {
  HttpErrorResponse,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
  HttpResponse
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, retry, tap } from 'rxjs/operators';
import { MessageService } from 'primeng/api';

@Injectable()
export class HttpErrorInterceptor implements HttpInterceptor {
    constructor(private messageService: MessageService) {}

  intercept(
    request: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      retry(1),
      catchError((error: HttpErrorResponse) => {
        let errorMessage = '';
        if (error.error instanceof ErrorEvent) {
          // client-side error
          errorMessage = `Error: ${error.error.message}`;
          if (errorMessage != null)
              this.messageService.add({ key: 'notification', severity: 'error', summary: 'Oops!! An Error!!', detail: errorMessage });            
        } else {
          if (error.status === 0) {
              this.messageService.add({ key: 'notification', severity: 'error', summary: 'API Failure', detail: '1. Ensure you are connected to API or 2. ' + error.statusText });
          }
          if (error.status === 401) {            
              this.messageService.add({ key: 'notification', severity: 'error', summary: 'Unauthorised Access', detail: 'Only authorized users are allow access to this resource!' });
          }
            if (error.status === 400) {
                console.log(error);
                this.messageService.add({ key: 'notification', severity: 'error', summary: 'Bad Request', detail: error.error });            
          }
            if (error.status === 404) {
                this.messageService.add({ key: 'notification', severity: 'error', summary: 'File Not Found', detail: error.message });            
          }
            if (error.status === 405) {
                this.messageService.add({ key: 'notification', severity: 'error', summary: '405 - Operation Forbidden', detail: error.message });            
          }
            if (error.status === 500) {
                console.log(error)
                this.messageService.add({ key: 'notification', severity: 'error', summary: 'Internal Server Error', detail: error.message });            
          }
          /*else {
               server-side error
              if (error.error.electionCandidateId != null)
                this.toastrService.showToast('danger', "Already Voted!!", error.error.electionCandidateId);
              if (error.error.dateReceived != null)
                this.toastrService.showToast('danger', `${error.statusText}`, error.error.dateReceived);
              if (error.error.quantity != null)
                this.toastrService.showToast('danger', `${error.statusText}`, error.error.quantity);
                if (error.error.dateReceived != null && error.error.quantity != null)
                  this.toastrService.showToast('danger', `${error.statusText}`, error.error);
            }*/
        }
        return throwError(error);
      }),
      tap((event: HttpEvent<any>) => {
          if (event instanceof HttpResponse && event.status === 201) {
              this.messageService.add({ key: 'notification', severity: 'success', summary: `${event.statusText}`, detail: 'Record successfully saved!' });          
        }
      })
    );
  }
}
