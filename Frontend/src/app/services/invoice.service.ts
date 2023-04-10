import { Injectable } from '@angular/core';
import {HttpClient,HttpRequest, HttpEvent} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class InvoiceService {
  private baseUrl = 'http://localhost:9000/api/';
  constructor(private _http:HttpClient) { }
   getAllInvoices() :Observable<any>{
    return this._http.get(this.baseUrl+'Invoice');
  }
  upload(file: File): Observable<HttpEvent<any>> {
    const formData: FormData = new FormData();

    formData.append('file', file);

    const req = new HttpRequest('POST', `${this.baseUrl}`+'upload', formData, {
      reportProgress: true,
      responseType: 'json'
    });

    return this._http.request(req);
  }
}
