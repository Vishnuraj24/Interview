import { CommonModule, JsonPipe } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-reactive',
  imports: [ReactiveFormsModule, JsonPipe, CommonModule, RouterModule],
  templateUrl: './reactive.component.html',
  styleUrl: './reactive.component.css',
  
})
export class ReactiveComponent {

  employeeForm: FormGroup = new FormGroup({
    fullName: new FormControl('',[Validators.required,Validators.minLength(5)]),
    email: new FormControl('',[Validators.required,Validators.email]),
    phone: new FormControl(''),
    address: new FormControl('',[Validators.required])
  });

  formValue: any;

  onSubmit() { 
    console.log(this.employeeForm.value);
    this.formValue = this.employeeForm.value;
  }

}
