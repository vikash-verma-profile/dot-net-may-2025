import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-order-confirmation',
  templateUrl: './order-confirmation.component.html',
  standalone: false,
})
export class OrderConfirmationComponent implements OnInit {
 order:any;
  ngOnInit(): void {
    
    
  }
  constructor(private cartService: CartService,private router:Router) {}
 
}
