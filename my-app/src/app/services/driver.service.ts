import { Injectable } from '@angular/core';
import { Driver } from '../models/driver';


@Injectable({
  providedIn: 'root'
})
export class DriverService {

  constructor() { }

  public getDrivers(): Driver[]{
    let driver = new Driver();
    driver.name = "hello";
    driver.number = "130";
    driver.team = "Red Team";

    return [driver];
  }
}