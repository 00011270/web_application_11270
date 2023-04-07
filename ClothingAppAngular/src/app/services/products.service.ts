import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';
import { ProgramDriver } from '@angular/compiler-cli/src/ngtsc/program_driver';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  

  apiUrl: string = 'http://localhost:29367'
  constructor(private http: HttpClient) { }

  // creating a method that will get the list of products
  // from api and return it as an Observable object of Product array
  getProductList() : Observable<Product[]>{
    return this.http.get<Product[]>(this.apiUrl + '/api/product')
  }

  //function that will take Product from frontend and then pass it
  // to the API
  sellProduct(sellProduct: Product):Observable<Product>{
    return this.http.post<Product>(this.apiUrl +'/api/product', sellProduct)
  }

  getProductById(id: string): Observable<Product>{
    return this.http.get<Product>(this.apiUrl +'/api/product/' + id)
  }

  getProductsByCategory(categoryId: number):Observable<Product[]>{
    return this.http.get<Product[]>(this.apiUrl+`/api/product/category/${categoryId}`)
  }

  deleteProduct(prodId: number) :Observable<Product> {
    return this.http.delete<Product>(this.apiUrl +`/api/product/${prodId}`)
  }
}
