import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetailedProductComponent } from './components/products/detailed-product/detailed-product.component';
import { ProductListComponent } from './components/products/product-list/product-list.component';
import { SellProductComponent } from './components/products/sell-product/sell-product.component';

const routes: Routes = [
  {
    path: '',
    component: ProductListComponent
  },
  {
    path: 'products',
    component: ProductListComponent
  },
  {
    path: 'products/sell',
    component: SellProductComponent
  },
  {
    path: 'product/:id',
    component: DetailedProductComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
