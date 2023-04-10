import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import { AppComponent } from './app.component';
import { OploaderComponent } from './components/oploader/oploader.component';
import { UploaderComponent } from './uploader/uploader.component';
import { GridModule, PagerModule } from '@syncfusion/ej2-angular-grids';
import { GridComponent } from './grid/grid.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatDialogModule} from "@angular/material/dialog";
import { InvoiceDeteailComponent } from './invoice-deteail/invoice-deteail.component';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInput, MatInputModule} from "@angular/material/input";
import {MatNativeDateModule} from "@angular/material/core";
import {MatTableDataSource, MatTableModule} from "@angular/material/table";
import { DatagridComponent } from './components/datagrid/datagrid.component';
import {MatCardModule} from "@angular/material/card";

@NgModule({
  declarations: [
    AppComponent,
    OploaderComponent,
    UploaderComponent,
    GridComponent,
    InvoiceDeteailComponent,
    DatagridComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    GridModule,
    PagerModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatNativeDateModule,
    MatTableModule,
    MatCardModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
