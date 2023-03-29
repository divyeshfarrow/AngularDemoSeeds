import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrderDetailsRoutingModule } from './order-details-routing.module';
import { OrderListComponent } from './order-list/order-list.component';
import { AddOrderComponent } from './add-order/add-order.component';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';

import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    OrderListComponent,
    AddOrderComponent
  ],
  imports: [
    CommonModule,
    OrderDetailsRoutingModule,
    MatTableModule,
    MatButtonModule,
    MatDividerModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatIconModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule

  ],
  exports: [
    OrderListComponent,
    AddOrderComponent
  ]
})
export class OrderDetailsModule { }
