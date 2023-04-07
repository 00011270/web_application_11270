import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
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
  @Input() id: number = 0;

  constructor(private reviewService: ReviewService, private router: Router){
    this.getReviewsOfProduct(this.id);
  }

  addReviewAction(){
    this.review.productId = this.id
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

  getReviewsOfProduct(productId: number){
    this.reviewService.getReviewOfProduct(2).subscribe({
      next:(reviews) =>{
        this.reviews = reviews
      },
      error: (response) =>{
        console.log(response);
      }
    })
  }
}
