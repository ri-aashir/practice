import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';

import { OwnerRoutingModule } from './owner-routing-module';
import { SharedModule } from '../shared/shared-module';
import { ReactiveFormsModule } from '@angular/forms';
import { OwnerCreate } from './owner-create/owner-create';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  declarations: [OwnerCreate],
  imports: [
    CommonModule,
    OwnerRoutingModule,
    SharedModule,
    ReactiveFormsModule,
    BsDatepickerModule.forRoot(),
  ],
  providers: [DatePipe],
  exports: [ // Not necessary since it's not a shared module
    //OwnerCreate 
  ]
})
export class OwnerModule { }
