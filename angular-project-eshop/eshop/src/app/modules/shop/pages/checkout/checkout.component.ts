import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  standalone: false,
})
export class CheckoutComponent implements OnInit {
  checkoutData={
    name:'',
    address:'',
    payment:'cod',
  }
  ngOnInit(): void {
    
  }
  constructor(private cartService: CartService,private router:Router) {}

  submitOrder(){
    const Order={
      ...this.checkoutData,
      items:this.cartService.getCartItems(),
    }
    this.cartService.clearCart();
    this.router.navigate(['/shop/order-confirmation']);
  }
}
