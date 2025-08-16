import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-not-found',
  imports: [],
  templateUrl: './not-found.html',
  styleUrl: './not-found.css'
})
export class NotFound implements OnInit {
  notFoundText: string = `404 SORRY COULDN'T FIND IT!!!`;
  constructor() { }
  ngOnInit(): void {
  }
}