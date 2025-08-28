import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Owner } from './../../_interfaces/owner.model';
import { Router, ActivatedRoute } from '@angular/router';
import { OwnerRepository } from './../../shared/services/owner-repository';
import { ErrorHandler } from './../../shared/services/error-handler';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-owner-details',
  imports: [ DatePipe ],
  templateUrl: './owner-details.html',
  styleUrls: ['./owner-details.css']
})
export class OwnerDetails implements OnInit {
  owner: Owner;
  errorMessage: string = '';

  constructor(private repository: OwnerRepository, private router: Router, 
              private activeRoute: ActivatedRoute, private errorHandler: ErrorHandler) { }

  ngOnInit() {
    this.getOwnerDetails()
  }

  getOwnerDetails = () => {
    const id: string = this.activeRoute.snapshot.params['id'];
    const apiUrl: string = `api/owner/${id}/account`;

    this.repository.getOwner(apiUrl)
    .subscribe({
      next: (own: Owner) => this.owner = own,
      error: (err: HttpErrorResponse) => {
        this.errorHandler.handleError(err);
        this.errorMessage = this.errorHandler.errorMessage;
      }
    })
  }

}