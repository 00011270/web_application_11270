import { Component } from '@angular/core';
import { ProductCategory } from 'src/app/models/productCategory.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductsService } from 'src/app/services/products.service';
import { CategoryAddComponent } from '../../category/category-add/category-add.component';
import { Product } from 'src/app/models/product.model';

@Component({
  selector: 'app-nav-block',
  templateUrl: './nav-block.component.html',
  styleUrls: ['./nav-block.component.css']
})
export class NavBlockComponent {
  
  products: Product[] = []
  constructor(
              private productService: ProductsService){
  }

  
  
}
