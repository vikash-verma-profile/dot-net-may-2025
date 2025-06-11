import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class ProductService {
  private products = [
    {
      id: 1,
      name: 'Laptop',
      price: 80000,
      description: 'Gaming Laptop',
    },
    {
      id: 2,
      name: 'Headphone',
      price: 2000,
      description: 'Wireless Headphone',
    },
    {
      id: 3,
      name: 'Keyboard',
      price: 1200,
      description: 'Mechanical Keyboard',
    },
  ];
  getProducts() {
    return this.products;
  }
  getproductById(id: number) {
    return this.products.find((p) => p.id === id);
  }
}
