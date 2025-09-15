import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModalModule } from 'ngx-bootstrap/modal';

import { ErrorModal } from './modals/error-modal/error-modal';
import { SuccessModal } from './modals/success-modal/success-modal';



@NgModule({
  declarations: [
    ErrorModal,
    SuccessModal
  ],
  imports: [
    CommonModule,
    ModalModule.forRoot()
  ],
  exports: [
    ErrorModal,
    SuccessModal
  ]
})
export class SharedModule { }
