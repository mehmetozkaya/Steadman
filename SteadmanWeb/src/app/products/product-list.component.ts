import { Component, OnInit } from "@angular/core";
import { IProduct } from "./product";
import { ProductService } from "./product.service";

@Component({    
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  
  constructor(private productService : ProductService) {
    
  }

    pageTitle: string = 'Product List';    
    imageWidth: number = 50;
    imageMargin: number = 2;
    showImage: boolean = false;
    errorMessage: string = '';

    _listFilter: string;
    get listFilter(): string {
      return this._listFilter;
    }
    set listFilter(value: string) {
      this._listFilter = value;
      this.filteredProducts = this.listFilter ? this.performFilter(this.listFilter) : this.products;
    }

    filteredProducts: IProduct[];
    products: IProduct[] = [];  

    ngOnInit(): void {
      console.log('aspnetrun-angular');

      this.productService.getProducts()
            .subscribe(products => this.products = products,
              error => this.errorMessage = <any>error,
              () => this.filteredProducts = this.products);      
    }
    
    performFilter(filterBy: string): IProduct[] {
      filterBy = filterBy.toLocaleLowerCase();
      return this.products.filter((product: IProduct) => 
              product.productName.toLocaleLowerCase().indexOf(filterBy) !== -1);
    }

    onRatingClicked(message: string): void {
      console.log(message);
      this.pageTitle = this.pageTitle + ' ' + message;
    }

    toggleImage(): void {
      this.showImage = !this.showImage;
    }

    writeFirstOfProductName(): void {
      if(this.filteredProducts.length > 0) {
        console.log(this.filteredProducts[0].productName);
      }
    }

}