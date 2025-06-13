import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthService } from '../modules/auth/services/auth.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterModule,CommonModule],
  templateUrl: './app.component.html',
  standalone: true,
})
export class AppComponent {
  constructor(private auth: AuthService) {}

  get isLoggedIn(): boolean {
    return this.auth.isLoggedIn();
  }
  logout() {
    this.auth.removeToken();
  }
}
