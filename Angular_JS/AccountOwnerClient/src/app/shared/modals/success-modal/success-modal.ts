import { Component, EventEmitter, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-success-modal',
  standalone: false,
  //imports: [],
  templateUrl: './success-modal.html',
  styleUrl: './success-modal.css'
})
export class SuccessModal implements OnInit {
  modalHeaderText: string;
  modalBodyText: string;
  okButtonText: string;
  redirectOnOk: EventEmitter<any> = new EventEmitter();

  constructor(private bsModalRef: BsModalRef) { }

  ngOnInit(): void {
  }
  
  onOkClicked = () => {
    this.redirectOnOk.emit();
    this.bsModalRef.hide();
  }


}
