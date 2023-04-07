import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IProduct, Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit{
  productDetails: IProduct = new Product()
  constructor(private route: ActivatedRoute, private productService: ProductsService, private router: Router){

  }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next:(resp)=>{
        const id = resp.get('id');

        if(id){
          this.productService.getProductById(id).subscribe({
            next:(response)=>{
              this.productDetails = response
            }
          })
        }
      }
    })
  }

  updateProduct(){
    console.log(this.productDetails)
    this.productService.updateProduct(this.productDetails.id, this.productDetails).subscribe({
      next:(resp)=>{
        this.router.navigate([''])
      },
      error:(resp)=>{
        alert('Product Has Not Been Updated. Please check fields');
      }
    })
  }

}
