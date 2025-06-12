import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  standalone: false,
})
export class LoginComponent {

    username='';
    password='';
    error='';
  constructor(private auth: AuthService,private router:Router) {}

  login(){
    this.auth.login(this.username,this.password).subscribe({
        next:(res)=>{
            this.auth.saveToken(res.token);
            this.router.navigate([''])
        },
        error:()=>{
            this.error="Invalid username or password";
        }
    });
  }
}
