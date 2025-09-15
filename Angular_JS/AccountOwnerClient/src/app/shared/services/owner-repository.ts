import { OwnerForCreation } from '../../_interfaces/ownerCreationModel';
import { Owner } from './../../_interfaces/owner.model';
import { EnvironmentUrl } from './environment-url';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OwnerRepository {

  constructor(private http: HttpClient, private envUrl: EnvironmentUrl) { }

  public getOwners = (route: string) => {
    return this.http.get<Owner[]>(this.createCompleteRoute(route, this.envUrl.urlAddress));
  }

  public getOwner = (route: string) => {
    return this.http.get<Owner>(this.createCompleteRoute(route, this.envUrl.urlAddress));
  }

  public createOwner = (route: string, owner: OwnerForCreation) => {
    return this.http.post<Owner>(this.createCompleteRoute(route, this.envUrl.urlAddress), owner, this.generateHeaders());
  }

  public updateOwner = (route: string, owner: Owner) => {
    return this.http.put(this.createCompleteRoute(route, this.envUrl.urlAddress), owner, this.generateHeaders());
  }

  public deleteOwner = (route: string) => {
    return this.http.delete(this.createCompleteRoute(route, this.envUrl.urlAddress));
  }

  private createCompleteRoute = (route: string, envAddress: string) => {
    return `${envAddress}/${route}`;
  }

  private generateHeaders = () => {
    return {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
  }
}