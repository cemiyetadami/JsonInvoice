import { Component } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import {InvoiceDeteailComponent} from "./invoice-deteail/invoice-deteail.component";
import {InvoiceService} from "./services/invoice.service";
import {UploaderComponent} from "./uploader/uploader.component";


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'fupload2';
  constructor(private _dialog:MatDialog,
              private _invoiceService:InvoiceService) {
  }

  openDetailForm(){
    this._dialog.open(UploaderComponent);
  }


}
