import { Component } from '@angular/core';
import { EmployeeComponent } from "../employee/employee.component";
import { FileuploadComponent } from "../fileupload/fileupload.component";
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  imports: [EmployeeComponent, FileuploadComponent,RouterOutlet],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {

}
