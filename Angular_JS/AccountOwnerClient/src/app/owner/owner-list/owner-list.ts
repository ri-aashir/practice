import { Component, OnInit } from '@angular/core';

import { Owner } from '../../_interfaces/owner.model';
import { OwnerRepository } from './../../shared/services/owner-repository';
import { DatePipe } from '@angular/common';
import { ErrorHandler } from './../../shared/services/error-handler';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-owner-list',
  imports: [DatePipe],
  templateUrl: './owner-list.html',
  styleUrl: './owner-list.css'
})
export class OwnerList implements OnInit {
  owners: Owner[];
  errorMessage: string = '';

  constructor(private repository: OwnerRepository, private errorHandler: ErrorHandler) { }

  ngOnInit(): void {
    this.getAllOwners();
  }

  private getAllOwners = () => {
    const apiAddress: string = 'api/owner';
    this.repository.getOwners(apiAddress)
    .subscribe({
      next: (own: Owner[]) => this.owners = own,
      error: (err: HttpErrorResponse) => {
        this.errorHandler.handleError(err);
        this.errorMessage = this.errorHandler.errorMessage;
      }
    })
  }

}
