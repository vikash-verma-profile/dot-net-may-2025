import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { routes } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [BrowserModule, RouterModule.forRoot(routes),CommonModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
