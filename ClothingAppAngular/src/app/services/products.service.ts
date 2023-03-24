import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';

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
}
