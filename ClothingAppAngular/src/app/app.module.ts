import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBlockComponent } from './components/navigation/nav-block/nav-block.component';
import { ProductListComponent } from './components/products/product-list/product-list.component';
import { SellProductComponent } from './components/products/sell-product/sell-product.component';
import { DetailedProductComponent } from './components/products/detailed-product/detailed-product.component';
import { ReviewComponentComponent } from './components/review-component/review-component.component';
import { HeroSectionComponent } from './components/hero-section/hero-section.component';
import { CategoryAddComponent } from './components/category/category-add/category-add.component';
import { CategoryListComponent } from './components/category/category-list/category-list.component';
import { EditProductComponent } from './components/products/edit-product/edit-product.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBlockComponent,
    ProductListComponent,
    SellProductComponent,
    DetailedProductComponent,
    ReviewComponentComponent,
    HeroSectionComponent,
    CategoryAddComponent,
    CategoryListComponent,
    EditProductComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
