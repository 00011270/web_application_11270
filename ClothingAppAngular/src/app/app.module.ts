import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBlockComponent } from './components/navigation/nav-block/nav-block.component';
import { ProductListComponent } from './components/products/product-list/product-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBlockComponent,
    ProductListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
