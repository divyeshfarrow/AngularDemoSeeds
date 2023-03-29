import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddOrderComponent } from './add-order/add-order.component';
import { OrderListComponent } from './order-list/order-list.component';

const routes: Routes = [
  { path: 'orderlist', component: OrderListComponent },
  { path: 'orderDetail/:id', component: AddOrderComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrderDetailsRoutingModule { }
