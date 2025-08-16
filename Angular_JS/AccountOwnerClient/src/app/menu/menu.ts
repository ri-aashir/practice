import { Component, OnInit } from '@angular/core';
import { CollapseModule } from 'ngx-bootstrap/collapse';

@Component({
  selector: 'app-menu',
  imports: [CollapseModule],
  templateUrl: './menu.html',
  styleUrl: './menu.css'
})
export class Menu implements OnInit {
  isCollapsed: boolean = false;
  
  constructor() { }

  ngOnInit(): void {
  }

}