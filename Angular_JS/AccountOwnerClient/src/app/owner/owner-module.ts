import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OwnerRoutingModule } from './owner-routing-module';
import { OwnerList } from './owner-list/owner-list';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    OwnerList,
    OwnerRoutingModule
  ]
})
export class OwnerModule { }
