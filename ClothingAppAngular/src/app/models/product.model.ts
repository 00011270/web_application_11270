export interface IProduct{
     id: number
     name: string,
     description: string, 
     price: number,
     quantity: number, 
     gender: GenderType,
     status: ProductStatus
     size: ProductSize,
     categoryId: number,
     createdAt: Date,
     updatedAt: Date
}

export class Product implements IProduct{
     id: number
     name: string
     description: string
     price: number
     quantity: number
     gender: GenderType
     status: ProductStatus
     size: ProductSize
     categoryId: number
     createdAt: Date
     updatedAt: Date

     constructor(){
          this.id = 0;
          this.name ='';
          this.description = '';
          this.price = 0;
          this.quantity = 0;
          this.gender = 0;
          this.status = ProductStatus.AVAILABLE;
          this.size = 0;
          this.categoryId = 0;
          this.createdAt = new Date();
          this.updatedAt = new Date();
     }
}


export enum GenderType{
     MALE = 0,
     FEMALE = 1
}

export enum ProductStatus{
     AVAILABLE = 0, 
     OUT_OF_STOCK = 1
}

export enum ProductSize{
     S = 0,
     M = 1,
     L = 2,
     XL = 3,
     XXL = 4,
     XXXL = 5
}