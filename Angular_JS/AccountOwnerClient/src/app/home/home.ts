import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit {
  public homeText: string;
  constructor() { }
  ngOnInit(): void {
    this.homeText = "WELCOME TO ACCOUNT-OWNER APPLICATION";
  }
}
