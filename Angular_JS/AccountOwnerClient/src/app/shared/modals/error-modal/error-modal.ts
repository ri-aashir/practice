import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-error-modal',
  standalone: false,
  //imports: [],
  templateUrl: './error-modal.html',
  styleUrl: './error-modal.css'
})
export class ErrorModal implements OnInit {
  modalHeaderText: string;
  modalBodyText: string;
  okButtonText: string;

  constructor(public bsModalRef: BsModalRef) { }

  ngOnInit(): void {

  }

}
