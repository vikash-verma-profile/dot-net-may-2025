import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { ActivatedRoute,Router } from '@angular/router';
import { CartService } from '../../services/cart.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  standalone:false
})
export class ProductDetailComponent implements OnInit {

    product:any;
  constructor(private route:ActivatedRoute,private router:Router,private productService: ProductService,private cartService:CartService) {}

  ngOnInit(): void {
      const id=Number(this.route.snapshot.paramMap.get('id'));
      this.product=this.productService.getproductById(id);
  }
  addToCartAndGo(){
    this.cartService.addToCart(this.product);
    this.router.navigate(['/shop/cart']);
  }
}
