import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BsModalService, ModalOptions } from 'ngx-bootstrap/modal';
import { ErrorModal } from '../modals/error-modal/error-modal';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandler {
  public errorMessage: string = '';

  constructor(private router: Router, /*private modal: BsModalService*/) {
    // problem: "no provider found for _Error-handler -> _BsModalService -> RendererFactory2"
    // copilot says avoid injecting BsModalService in a service unless necessary
    // do it in a contorller instead where Dependency Injection is more stable
   } 

  public handleError = (error: HttpErrorResponse) => {
    if (error.status === 500) {
      this.handle500Error(error);
    }
    else if (error.status === 404) {
      this.handle404Error(error)
    }
    else {
      this.handleOtherError(error);
    }
  }
  private handle500Error = (error: HttpErrorResponse) => {
    this.createErrorMessage(error);
    this.router.navigate(['/500']);
  }
  private handle404Error = (error: HttpErrorResponse) => {
    this.createErrorMessage(error);
    this.router.navigate(['/404']);
  }
  private handleOtherError = (error: HttpErrorResponse) => {
    this.createErrorMessage(error); //TODO: this will be fixed later; //DONE!

    // const config: ModalOptions = {
    //   initialState: {
    //     modalHeaderText: 'Error Message',
    //     modalBodyText: this.errorMessage,
    //     okButtonText: 'OK'
    //   }
    // };
    // this.modal.show(ErrorModal, config);
  }
  private createErrorMessage = (error: HttpErrorResponse) => {
    this.errorMessage = error.error ? error.error : error.statusText;
  }
}
