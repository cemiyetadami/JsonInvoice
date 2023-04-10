
import {AfterViewInit, Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import {InvoiceService} from "../../services/invoice.service";

@Component({
  selector: 'app-datagrid',
  templateUrl: './datagrid.component.html',
  styleUrls: ['./datagrid.component.css']
})
export class DatagridComponent implements  AfterViewInit,OnInit{

constructor(private _invoiceService:InvoiceService) {
}
  displayedColumns: string[] = ['ID', 'InvoiceId', 'SenderTitle', 'ReceiverTitle','Date'];
  dataSource!: MatTableDataSource<any>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;


ngOnInit() {

  this.getInvoiceList();
}
  ngAfterViewInit() {

  }
getInvoiceList(){
  this._invoiceService.getAllInvoices().subscribe({
    next:(res)=>{
      this.dataSource=new MatTableDataSource(res);
      this.dataSource.sort=this.sort;
      this.dataSource.paginator=this.paginator;
    },
    error:console.log,

    }
  )
}
}
