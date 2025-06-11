import { NgModule } from '@angular/core';
import { ProductListComponent } from './pages/product-list/product-list.component';
import { ProductDetailComponent } from './pages/product-detail/product-detail.component';
import { CartComponent } from './pages/cart/cart.component';
import { CommonModule } from '@angular/common';
import { ShopRoutingModule } from './shop-routing.module';

@NgModule({
  declarations: [ProductListComponent, ProductDetailComponent, CartComponent],
  imports: [CommonModule, ShopRoutingModule],
})
export class ShopModule {}
