import { Component } from '@angular/core';
import { LoginService } from '../../services/login.service';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  
  user: any = {
    username: '',
    password: ''
  };

  constructor(private service: LoginService,private router:Router) { }
  
  onSubmit() {
    this.service.login(this.user.username, this.user.password)
      .subscribe((data: any) => {
        localStorage.setItem('token', data.token);
        this.router.navigate(['/dashboard']);
      });
  }

}
