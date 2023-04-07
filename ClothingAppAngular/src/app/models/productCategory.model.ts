export interface IProductCategory{
    id: number,
    name: string,
}
export class ProductCategory implements IProductCategory{
    id: number
    name: string

    constructor(){
        this.id = 0,
        this.name = ''
    }
}