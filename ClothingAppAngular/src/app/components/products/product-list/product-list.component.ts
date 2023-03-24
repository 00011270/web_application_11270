import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit{
  
  //Creating a variable that will store product list
  // that will get from API
  products: Product[] = [];
  
  //Injecting Product Service class by constructor
  constructor(private productService: ProductsService){

  }

  ngOnInit(): void {
    // As getProductList method is of type Observable, the subscribe method of Observable will be executed
    // whenever any change is made in this Observable
    this.productService.getProductList().subscribe({
      // with next I am console logging product list
      next: (products) => {
        this.products = products;
      },
      // with error, console logging any error is made from Response body
      error: (Response) =>{
        console.log(Response);
      }
    })
  }
}
