import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EnvironmentUrl {
  urlAddress: string = environment.urlAddress;

  constructor() { }
}