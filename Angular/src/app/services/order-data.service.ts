import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { UrlConfiguration } from '../urlConfiguration/url-configuration';
import { OrderDetails } from '../Models/order-details';

@Injectable({
  providedIn: 'root'
})
export class OrderDataService {

  httpOptions = { headers: new HttpHeaders({'Content-Type': 'application/json'}) };

  constructor(private http: HttpClient) { }

  getOrder() {
    return this.http.get(UrlConfiguration.baseAPIURL + UrlConfiguration.getAllOrder);
  }
  getProduct() {
    return this.http.get(UrlConfiguration.baseAPIURL + UrlConfiguration.getAllProducts);
  }
  getCustomer() {
    return this.http.get(UrlConfiguration.baseAPIURL + UrlConfiguration.getCustomerDetails);
  }
  getorderDetailsById(id:string) {
    return this.http.get(UrlConfiguration.baseAPIURL + UrlConfiguration.getOrderbyId + id);
  }
  saveOrderDetails(orderData:OrderDetails) {
    return this.http.post(UrlConfiguration.baseAPIURL + UrlConfiguration.saveUpdateOrder, orderData);
  }
  

}
