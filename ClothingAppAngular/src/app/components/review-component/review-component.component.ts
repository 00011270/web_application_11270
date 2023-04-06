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
  review: IReview = new Review()
  @Input() product_id: any;

  constructor(private reviewService: ReviewService, private router: Router){

  }


  addReviewAction(){
    this.reviewService.addReview(this.review).subscribe({
      next: (review) =>{
        this.review = review;
        this.router.navigate(['/reviews'])
      },
      error: (response) =>{
        console.log(this.review)
        console.log(response);
        
      }
    })
  }
}
