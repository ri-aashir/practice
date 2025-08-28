import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-internal-server',
  imports: [],
  templateUrl: './internal-server.html',
  styleUrl: './internal-server.css'
})
export class InternalServer implements OnInit {
  errorMessage: string = "500 SERVER ERROR, CONTACT ADMINISTRATOR!!!!";
  
  constructor() { }

  ngOnInit(): void {
  }

}
