import { ChangeDetectorRef, Component, OnInit } from '@angular/core';

import { Owner } from '../../_interfaces/owner.model';
import { OwnerRepository } from './../../shared/services/owner-repository';
import { DatePipe } from '@angular/common';
import { ErrorHandler } from './../../shared/services/error-handler';
import { HttpErrorResponse } from '@angular/common/http';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-owner-list',
  imports: [DatePipe, RouterLink],
  templateUrl: './owner-list.html',
  styleUrl: './owner-list.css'
})
export class OwnerList implements OnInit {
  owners: Owner[];
  errorMessage: string = '';

  constructor(private repository: OwnerRepository, private errorHandler: ErrorHandler, private router: Router, private cdr: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.getAllOwners();
  }

  private getAllOwners = () => {
    const apiAddress: string = 'api/owner';
    this.repository.getOwners(apiAddress)
    .subscribe({
      //next: (own: Owner[]) => this.owners = own,
      next: (own: Owner[]) => {
        this.owners = own;
        this.cdr.detectChanges();
      },
      error: (err: HttpErrorResponse) => {
        this.errorHandler.handleError(err);
        this.errorMessage = this.errorHandler.errorMessage;
      }
    })
  }

  public getOwnerDetails = (id) => { 
    const detailsUrl: string = `/owner/details/${id}`; 
    this.router.navigate([detailsUrl]); 
  }

}
