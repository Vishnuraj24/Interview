import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  private baseUrl = 'https://localhost:44331/api/login';
  constructor(private client: HttpClient) { }

  login(username: string, password: string) {
    return this.client.post(this.baseUrl, { username, password });
  }


}
