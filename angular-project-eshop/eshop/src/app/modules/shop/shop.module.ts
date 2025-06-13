import { NgModule } from '@angular/core';
import { ProductListComponent } from './pages/product-list/product-list.component';
import { ProductDetailComponent } from './pages/product-detail/product-detail.component';
import { CartComponent } from './pages/cart/cart.component';
import { CommonModule } from '@angular/common';
import { ShopRoutingModule } from './shop-routing.module';
import { FormsModule } from '@angular/forms';
import { CheckoutComponent } from './pages/checkout/checkout.component';
import { OrderConfirmationComponent } from './pages/order-confirmation/order-confirmation.component';

@NgModule({
  declarations: [ProductListComponent, ProductDetailComponent, CartComponent,CheckoutComponent,OrderConfirmationComponent],
  imports: [CommonModule, ShopRoutingModule,FormsModule],
})
export class ShopModule {}
