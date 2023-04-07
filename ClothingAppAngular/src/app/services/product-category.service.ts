import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductCategory } from '../models/productCategory.model';

@Injectable({
  providedIn: 'root'
})
export class ProductCategoryService {
  apiUrl: string = 'http://localhost:29367'
  constructor(private http: HttpClient) { }

  getCategoryList() : Observable<ProductCategory[]>{
    return this.http.get<ProductCategory[]>(this.apiUrl + '/api/productCategory')
  }

  addCategory(category: ProductCategory) : Observable<ProductCategory>{
    return this.http.post<ProductCategory>(this.apiUrl + '/api/productCategory', category)
  }
}
