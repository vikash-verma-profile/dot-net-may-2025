import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class CartService {
  private cartItems:any[]=[];

  addToCart(product:any){
    this.cartItems.push(product);
  }

  getCartItems(){
    return this.cartItems;
  }
  clearCart(){
    this.cartItems=[];
  }
  removeItem(index:number){
    this.cartItems.splice(index,1);
  }
}
