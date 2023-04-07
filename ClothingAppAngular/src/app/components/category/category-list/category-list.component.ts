import { Component } from '@angular/core';
import { ProductCategory } from 'src/app/models/productCategory.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent {
  productCategories: ProductCategory[] =[]

  constructor(private categoryService: ProductCategoryService,){
    this.getCategories();
  }

  getCategories(){
    this.categoryService.getCategoryList().subscribe({
      next:(productCategories) =>{
        this.productCategories = productCategories;
        console.log(this.productCategories)
      },
      error:(Response) =>{
        console.log(Response);
      }
    })
  }



}
