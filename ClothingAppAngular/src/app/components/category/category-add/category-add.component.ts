import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IProductCategory, ProductCategory } from 'src/app/models/productCategory.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { NavBlockComponent } from '../../navigation/nav-block/nav-block.component';

@Component({
  selector: 'app-category-add',
  templateUrl: './category-add.component.html',
  styleUrls: ['./category-add.component.css']
})
export class CategoryAddComponent {
  category: IProductCategory = new ProductCategory()

  constructor(private productCategoryService: ProductCategoryService,
              private router: Router){

  }

  addCategory(){
    this.productCategoryService.addCategory(this.category).subscribe({
      next:(category) =>{
        this.category = category;
        console.log(category);
        location.reload();
      },
      error:(Response)=>{
        alert('An error occurred while creating new category. Please check the fields before submitting.');
        console.log(Response);
      }
    })
  }
}
