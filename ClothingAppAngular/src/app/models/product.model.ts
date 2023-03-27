export interface Product{
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