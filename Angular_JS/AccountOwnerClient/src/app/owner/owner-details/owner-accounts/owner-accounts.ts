import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

import { Account } from './../../../_interfaces/account.model';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-owner-accounts',
  imports: [DatePipe],
  templateUrl: './owner-accounts.html',
  styleUrls: ['./owner-accounts.css']
})
export class OwnerAccounts implements OnInit {
  @Input() accounts: Account[];
  @Output() onAccountClick: EventEmitter<Account> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  onAccountClicked = (account: Account) => {
    this.onAccountClick.emit(account);
  }

}