import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { OwnerList} from './owner-list/owner-list';

const routes: Routes = [
  { path:'list', component: OwnerList }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OwnerRoutingModule { }
