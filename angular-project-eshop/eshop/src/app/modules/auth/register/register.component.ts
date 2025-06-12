import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  standalone: false,
})
export class RegisterComponent {
  username = '';
  password = '';
  firstName = '';
  lastName = '';
  gender = 1;
  error = '';
  constructor(private auth: AuthService, private router: Router) {}

  login() {
    this.auth
      .register(
        this.username,
        this.password,
        this.firstName,
        this.lastName,
        this.gender
      )
      .subscribe({
        next: (res) => {
         alert("Registertion successful!");
        },
        error: () => {
          this.error = 'Invalid username or password';
        },
      });
  }
}
