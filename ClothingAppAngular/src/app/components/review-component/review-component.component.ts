import { Component, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IReview, Review } from 'src/app/models/review.model';
import { ReviewService } from 'src/app/services/review.service';

@Component({
  selector: 'app-review-component',
  templateUrl: './review-component.component.html',
  styleUrls: ['./review-component.component.css']
})
export class ReviewComponentComponent {
  reviews: Review[] = [];
  review: IReview = new Review()

  constructor(private reviewService: ReviewService, private router: ActivatedRoute){
    this.getReviewsOfProduct();
  }

  addReviewAction(){
    //gets the id of the product by router paramMap and then creates a review for this product
    this.router.paramMap.subscribe({
      next:(params)=>{
        const productId = Number(params.get('id'))
        if(productId){
          this.review.productId = productId;
          this.reviewService.addReview(this.review).subscribe({
            next: (review) =>{
              this.review = review;
              console.log(this.review)
              location.reload();
            },
            error: (response) =>{
              console.log(this.review)
              console.log(response);
              
            }
          })
        }
      }
    })
    
  }

  removeReview(reviewId: number){
    console.log(reviewId)
    this.reviewService.removeReview(reviewId).subscribe({
      next:(review)=>{
        location.reload();
      }
    })
  }
  getReviewsOfProduct(){
    this.router.paramMap.subscribe({
      next:(params)=>{
        const productId =Number(params.get('id'))

        if(productId){
          this.reviewService.getReviewOfProduct(productId).subscribe({
            next:(reviews) =>{
              console.log(reviews)
              this.reviews = reviews
            },
            error: (response) =>{
              console.log(response);
            }
          })
        }
      }
    })
  }
}
