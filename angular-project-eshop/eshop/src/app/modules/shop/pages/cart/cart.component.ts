import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  standalone: false,
})
export class CartComponent implements OnInit {
  cartItems: any[] = [];
  ngOnInit(): void {
    this.cartItems = this.cartService.getCartItems();
  }
  constructor(private cartService: CartService,private router:Router) {}
  removeItem(index: number) {
    this.cartService.removeItem(index);
    this.cartItems = this.cartService.getCartItems();
  }
  clearCart() {
    this.cartService.clearCart();
    this.cartItems = [];
  }
  getTotal() {
    return this.cartItems.reduce((total, item) => total + item.price, 0);
  }
  checkout() {
     this.router.navigate(['/shop/checkout']);
  }
}
