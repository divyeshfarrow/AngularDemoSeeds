import { Component } from '@angular/core';
import { FormArray, ReactiveFormsModule, FormsModule, FormBuilder, NgForm, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { OrderDetails, product } from 'src/app/Models/order-details';
import { OrderDataService } from 'src/app/services/order-data.service';


@Component({
  selector: 'app-add-order',
  templateUrl: './add-order.component.html',
  styleUrls: ['./add-order.component.css']
})

export class AddOrderComponent {
  productArray = new FormArray([new FormControl('', Validators.required)]);
  customerData:any = [];
  productData:any = [];
  orderDetails:any = [];
  orderid:any= '';
  lastindex:number = 0;

  product:product = {
    id:1,
    productId: "1",
    quantity: 0,
    price:0,
    totalAmount: 0
  }
  orderMaster:OrderDetails = { 
    orderId:0, 
    customerId: "1",
    totalAmountofOrder: 0,
    orderDetailsProductWise:[{
      id:0,
      productId: "0",
      quantity: 0,
      price:0,
      totalAmount: 0
    }]

  };

  constructor(private orderData:OrderDataService, private router:Router, private aroute:ActivatedRoute) {
    this.orderid = aroute.snapshot.paramMap.get('id');
    orderData.getCustomer().subscribe((data) => {
      this.customerData = data;
    })

    orderData.getProduct().subscribe((data) => {
      this.productData = data;
    })

    orderData.getorderDetailsById(this.orderid).subscribe((data) => {
    
      this.orderDetails = data;
      this.orderMaster.orderId = this.orderDetails.orderId;
      this.orderMaster.customerId = this.orderDetails.customerId.toString();

      this.orderDetails.orderDetailsProductWise.forEach((value:any, index:number) => {

        if(index > 0)
        {
          this.addInputControl();
        }

        this.lastindex = value.id;
        this.orderMaster.orderDetailsProductWise[index].id = value.id;
        this.orderMaster.orderDetailsProductWise[index].productId = value.productId.toString();
        this.orderMaster.orderDetailsProductWise[index].price = value.price;
        this.orderMaster.orderDetailsProductWise[index].quantity = value.quantity;
        this.orderMaster.orderDetailsProductWise[index].totalAmount = value.totalAmount;
        
      });
      console.warn(this.orderMaster.orderDetailsProductWise);
    })   
  }

  addInputControl() {
    this.lastindex++;
    this.productArray.push(new FormControl('', Validators.required));
    var newProduct:product = { id: (this.lastindex), productId: this.productData[0].id.toString(), quantity:0, price:this.productData[0].price, totalAmount:0 };
    this.orderMaster.orderDetailsProductWise.push(newProduct);
  }

  removeInputControl(idx: number) {
    this.productArray.removeAt(idx);
    this.orderMaster.orderDetailsProductWise.splice(idx,1);
  }

  displayPrice(idx: number) {
    var prodObj = this.productData.filter((a:any) => a.id == parseInt(this.orderMaster.orderDetailsProductWise[idx].productId));
    this.orderMaster.orderDetailsProductWise[idx].price = prodObj[0].price;
    this.orderMaster.orderDetailsProductWise[idx].totalAmount = prodObj[0].price * this.orderMaster.orderDetailsProductWise[idx].quantity;  
  }

  calculateAmt(idx:number) {
    this.orderMaster.orderDetailsProductWise[idx].totalAmount = this.orderMaster.orderDetailsProductWise[idx].price * this.orderMaster.orderDetailsProductWise[idx].quantity;
  }

  saveOrder() {
    let finalTotalAmount = 0;
    this.orderMaster.orderDetailsProductWise.forEach((value:any, index:number) => {
      finalTotalAmount += value.totalAmount;
    });
    this.orderMaster.totalAmountofOrder = finalTotalAmount;
    console.warn(this.orderMaster);

    this.orderData.saveOrderDetails(this.orderMaster).subscribe((data) => {
      console.warn(data);
      this.router.navigateByUrl('/orderlist');
    });
  }
}
