import { Component, Input, OnInit } from '@angular/core';

import { Account } from './../../../_interfaces/account.model';

@Component({
  selector: 'app-owner-accounts',
  imports: [],
  templateUrl: './owner-accounts.html',
  styleUrls: ['./owner-accounts.css']
})
export class OwnerAccounts implements OnInit {
  @Input() accounts: Account[];

  constructor() { }

  ngOnInit(): void {
  }

}