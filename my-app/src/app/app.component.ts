import { Component } from '@angular/core';
import { DriverService } from './services/driver.service';
import { Driver } from './models/driver';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-first-project';
  drivers: Driver[] = [];
  constructor(private dataService: DriverService){
  }

  ngOnInit(): void{
    this.dataService.getDrivers().subscribe((result: Driver[]) => (this.drivers = result) );
  }
}
