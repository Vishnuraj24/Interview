import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from './employee.model';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-employee',
  imports: [FormsModule],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css'
})
export class EmployeeComponent {


  employees!: Employee[];

  newEmployee: Employee = {
    id: 0,
    name: "",
    department: ""
  };

  totalCount = 0;
  currentPage = 1;
  pageSize = 5;
  totalPages = Math.ceil(this.totalCount / this.pageSize);
  //for filtering purposes
  searchText: string = "";
  selecteddepartment: string = "";

  
  constructor(private service: EmployeeService) { }
  
  
  ngOnInit() {
    //this.getEmployees();
    this.loadEmployees();
  }

  loadEmployees() { 
    debugger;
    this.service.getPaginatedEmployees(this.currentPage, this.pageSize, this.searchText,this.selecteddepartment).subscribe((data: any) => {
      this.employees = data.items;
      this.totalCount = data.totalCount;
      this.totalPages = Math.ceil(this.totalCount / this.pageSize);
      console.log(this.employees);
    });
  }

  nextPage() {
    debugger;
    if (this.currentPage * this.pageSize < this.totalCount) {
      this.currentPage++;
      this.loadEmployees();
    }
    
  }

  prevPage() {
    debugger
    if (this.currentPage > 1) {
      this.currentPage--;
      this.loadEmployees();
    }
  } 

  onSearchChange() {
    this.currentPage = 1;
    this.loadEmployees();
  }
    



  getEmployees() {
    this.service.getAllEmployees().subscribe((data: any) => {
      this.employees = data;
      console.log(this.employees);
    });
  }

  addEmployee() {
    debugger; 
    this.service.createEmployee(this.newEmployee).subscribe((data: any) => {
      console.log(data);
      this.getEmployees();
      this.newEmployee = {
        id: 0,
        name: "",
        department: ""
      };
    });

   
    

  }

 


}
