import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { Product, IProduct } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-detailed-product',
  templateUrl: './detailed-product.component.html',
  styleUrls: ['./detailed-product.component.css']
})
export class DetailedProductComponent implements OnInit{
  productDetails: IProduct = new Product();

  constructor(private route: ActivatedRoute, private productService: ProductsService, private router: Router){

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

  buyProduct(){
    this.route.paramMap.subscribe({
      next: (param) =>{
        const prodId = Number( param.get('id'))

        this.productService.deleteProduct(prodId).subscribe({
          next:(response)=>{
            this.router.navigate([''])
            alert('Product Bought');
          },
          error:(response)=>{
            console.log(response)
          }
        })
      }
    })
  }


}
