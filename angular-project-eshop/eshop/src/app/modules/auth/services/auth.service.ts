import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class AuthService {
  private baseUrl = 'https://localhost:7020';

  constructor(private http: HttpClient) {}

  login(username: string, password: string) {
    return this.http.post<any>(`${this.baseUrl}/login`, { username, password });
  }
  saveToken(token: string) {
    localStorage.setItem('token', token);
  }
  getToken(): string | null {
    return localStorage.getItem('token');
  }
  register(
    username: string,
    password: string,
    firstname: string,
    lastname: string,
    gender: Number
  ) {
    return this.http.post<any>(`${this.baseUrl}/register`, {
      username,
      password,
      firstname,
      lastname,
      gender,
    });
  }
}
