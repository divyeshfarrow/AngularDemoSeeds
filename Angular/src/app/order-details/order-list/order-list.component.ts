import { Component } from '@angular/core';
import { OrderDataService } from 'src/app/services/order-data.service';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent {
  displayedColumns: string[] = ['id', 'customerName', 'totalAmountofOrder','info'];
  orderDataList: any = [];

  constructor(private orderData:OrderDataService) {
    orderData.getOrder().subscribe((data) => {
      this.orderDataList = data;
    })
  }
}
