import { HttpErrorResponse } from '@angular/common/http';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Owner } from './../../_interfaces/owner.model';
import { Router, ActivatedRoute } from '@angular/router';
import { OwnerRepository } from './../../shared/services/owner-repository';
import { ErrorHandler } from './../../shared/services/error-handler';
import { DatePipe } from '@angular/common';
import { OwnerAccounts } from './owner-accounts/owner-accounts';
import { Account } from '../../_interfaces/account.model';
import { Append } from '../../shared/directives/append';

@Component({
  selector: 'app-owner-details',
  imports: [ DatePipe, OwnerAccounts, Append ],
  templateUrl: './owner-details.html',
  styleUrls: ['./owner-details.css']
})
export class OwnerDetails implements OnInit {
  owner: Owner;
  errorMessage: string = '';

  constructor(private repository: OwnerRepository, private router: Router, 
              private activeRoute: ActivatedRoute, private errorHandler: ErrorHandler,
              private cds: ChangeDetectorRef) { }

  ngOnInit() {
    this.getOwnerDetails()
  }

  getOwnerDetails = () => {
    const id: string = this.activeRoute.snapshot.params['id'];
    const apiUrl: string = `api/owner/${id}/account`;

    this.repository.getOwner(apiUrl)
    .subscribe({
      next: (own: Owner) => {
        this.owner = own;
        this.cds.detectChanges();
      },
      error: (err: HttpErrorResponse) => {
        this.errorHandler.handleError(err);
        this.errorMessage = this.errorHandler.errorMessage;
      }
    })
  }

  printToConsole = (param: Account) => {
  console.log('Account parameter from the child component', param)
  }

}