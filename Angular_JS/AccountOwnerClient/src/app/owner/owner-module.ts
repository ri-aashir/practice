import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OwnerRoutingModule } from './owner-routing-module';
import { SharedModule } from '../shared/shared-module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    OwnerRoutingModule,
    SharedModule,
  ]
})
export class OwnerModule { }
