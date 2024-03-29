import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Review } from '../models/review.model';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {
  apiUrl: string = 'http://localhost:29367'
  constructor(private http: HttpClient) { }


  addReview(review: Review) : Observable<Review>{
    return this.http.post<Review>(this.apiUrl + '/api/review', review)
  }

  getReviewOfProduct(productId: number) :Observable<Review[]>{
    return this.http.get<Review[]>(this.apiUrl + `/api/review/${productId}`)
  }

  removeReview(reviewId: number):Observable<Review>{
    return this.http.delete<Review>(this.apiUrl+`/api/review/${reviewId}`)
  }
}
