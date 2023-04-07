import { Component } from '@angular/core';
import { ProductCategory } from 'src/app/models/productCategory.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-nav-block',
  templateUrl: './nav-block.component.html',
  styleUrls: ['./nav-block.component.css']
})
export class NavBlockComponent {
  productCategories: ProductCategory[] =[]
  constructor(private categoryService: ProductCategoryService){
    this.getCategories();
  }

  getCategories(){
    this.categoryService.getCategoryList().subscribe({
      next:(productCategories) =>{
        this.productCategories = productCategories;
      },
      error:(Response) =>{
        console.log(Response);
      }
    })
  }
}
