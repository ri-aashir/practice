import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { CollapseModule } from 'ngx-bootstrap/collapse';

@Component({
  selector: 'app-menu',
  imports: [CollapseModule, RouterLink, RouterLinkActive],
  templateUrl: './menu.html',
  styleUrl: './menu.css'
})
export class Menu implements OnInit {
  isCollapsed: boolean = false;
  
  constructor() { }

  ngOnInit(): void {
  }

}