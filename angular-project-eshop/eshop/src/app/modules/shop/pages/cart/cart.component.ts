import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  standalone:false
})
export class CartComponent implements OnInit {
  cartItems: any[] = [];
  ngOnInit(): void {
    this.cartItems = this.cartService.getCartItems();
  }
  constructor(private cartService: CartService) {}
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
}
