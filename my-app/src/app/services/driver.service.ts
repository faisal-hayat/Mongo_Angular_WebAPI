import { Injectable } from '@angular/core';
import { Driver } from '../models/driver';
import { HttpClient } from "@angular/common/http"; // allows http web-calls
import { Observable } from "rxjs"; // async mechanism to wait for web call request
import { environment } from 'src/environments/environment'; // provides the apiUrl

@Injectable({
  providedIn: 'root'
})

export class DriverService {
  url = "Driver";

  constructor(private http: HttpClient) { 
  }

  public getDrivers(): Observable<Driver[]>{
    return this.http.get<Driver[]>(`${environment.apiUrl}/${this.url}`);
  }
}