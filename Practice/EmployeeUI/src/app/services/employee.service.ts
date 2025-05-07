import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private baseUrl = 'https://localhost:44331/api/employee';
  constructor(private httpclient: HttpClient) { }


  getAllEmployees() {
    debugger;
    return this.httpclient.get(this.baseUrl);
  }

  createEmployee(employee: any) { 
    return this.httpclient.post(this.baseUrl, employee);
  }

  getPaginatedEmployees(page: number, pageSize: number, search:string, department:string) { 
    const params = new HttpParams()
      .set('page', page.toString())
      .set('pageSize', pageSize.toString())
      .set('search', search)
      .set('department',department);
    return this.httpclient.get(this.baseUrl, { params });

  }

}
