import { Component, NgZone, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { Product, GenderType, ProductSize, ProductStatus, } from 'src/app/models/product.model';
import { ProductCategory } from 'src/app/models/productCategory.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-sell-product',
  templateUrl: './sell-product.component.html',
  styleUrls: ['./sell-product.component.css']
})
export class SellProductComponent {
  productCategories: ProductCategory[] =[];

  sellProduct: Product = {
    name: '',
    description: '', 
    price: 0,
    quantity: 0, 
    gender: GenderType.MALE,
    status: ProductStatus.AVAILABLE,
    size: ProductSize.S,
    categoryId: 0,
    createdAt: new Date(),
    updatedAt: new Date()
  }
  // genderType is the values of GenderType enum in string format
  genderTypes = Object.keys(GenderType).filter(k=>typeof GenderType[k as any] === 'number');
  productSizes = Object.keys(ProductSize).filter(k=>typeof ProductSize[k as any] === 'number');
  productStatus = Object.keys(ProductStatus).filter(k=>typeof ProductStatus[k as any] === 'number');

  constructor(private productCategory: ProductCategoryService,
              private productService: ProductsService,
              private router: Router){

  }

  ngOnInit(): void{
    this.productCategory.getCategoryList().subscribe({
      next:(productCategories) =>{
        this.productCategories = productCategories;
      },
      error:(Response) =>{
        console.log(Response);
      }
    })
  }

  sellProductAction(){
    console.log(this.sellProduct);
    
    this.productService.sellProduct(this.sellProduct).subscribe({
      next:(product) =>{
        this.sellProduct = product;
        this.router.navigate(['/products'])
        console.log(product);
        
      },
      error:(Response)=>{
        console.log(Response);
        
      }
    })
  }


}
