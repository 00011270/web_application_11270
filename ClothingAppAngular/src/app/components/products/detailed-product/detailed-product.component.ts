import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product, IProduct } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-detailed-product',
  templateUrl: './detailed-product.component.html',
  styleUrls: ['./detailed-product.component.css']
})
export class DetailedProductComponent implements OnInit{
  productDetails: IProduct = new Product();

  constructor(private route: ActivatedRoute, private productService: ProductsService){

  }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) =>{
        const id = params.get('id');

        if(id){
          this.productService.getProductById(id).subscribe({
            next:(Response) =>{
              this.productDetails = Response;
              console.log(this.productDetails);
            }
          })
        }
      }
    })
  }


}
