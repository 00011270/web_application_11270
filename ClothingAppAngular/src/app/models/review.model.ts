export interface IReview{
    id: number
    content: string
    rating: number
    productId: number
    createdAt: Date,
    updatedAt: Date
}

export class Review implements IReview{
    id: number
    content: string
    rating: number
    productId: number
    createdAt: Date
    updatedAt: Date

    constructor(){
         this.id = 0;
         this.content = '';
         this.rating = 0;
         this.productId = 0;
         this.createdAt = new Date();
         this.updatedAt = new Date();
    }
}