import {Component, Inject, Input, OnInit} from '@angular/core';
import {IProduct} from '../../../models/iproduct';
import {HttpClient} from '@angular/common/http';
import {ActivatedRoute} from '@angular/router';
import {UtilityService} from '../../../core/utility.service';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.scss']
})
export class InfoComponent implements OnInit {

  public product: IProduct;
  private article: number;

  constructor(
    private utility: UtilityService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(paramsId => {
      this.article = paramsId.id;
      this.getProduct(paramsId.id);
    });
  }

  private getProduct(article: number): void {
    this.utility.getProductByArticle(article).subscribe(result => {
      this.product = result;
    }, error => console.error(error));
  }

}
