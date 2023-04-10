import { Component,OnInit } from '@angular/core';

import { DataManager, WebApiAdaptor  } from '@syncfusion/ej2-data';

@Component({
  selector: 'app-grid',
  template:'<ejs-grid [dataSource]="data"></ejs-grid>',
  //templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent implements OnInit{
  private dataManager: DataManager=new DataManager(
    {
    url:'http://localhost:9000/api/invoice',
    adaptor:new WebApiAdaptor (),
    crossDomain:true});
constructor(public data:DataManager) {
}


  ngOnInit():void {
    this.data=new DataManager(
      {
        url:'http://localhost:9000/api/invoice',
        adaptor:new WebApiAdaptor(),
        crossDomain:true
      }
    );

  }

}
