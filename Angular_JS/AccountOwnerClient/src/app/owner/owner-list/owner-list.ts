import { Component, OnInit } from '@angular/core';

import { Owner } from '../../_interfaces/owner.model';
import { OwnerRepository } from './../../shared/services/owner-repository';

@Component({
  selector: 'app-owner-list',
  imports: [],
  templateUrl: './owner-list.html',
  styleUrl: './owner-list.css'
})
export class OwnerList implements OnInit {
  owners: Owner[];
  constructor(private repository: OwnerRepository) { }
  ngOnInit(): void {
    this.getAllOwners();
  }
  private getAllOwners = () => {
    const apiAddress: string = 'api/owner';
    this.repository.getOwners(apiAddress)
    .subscribe(own => {
      this.owners = own;
    })
  }

}
