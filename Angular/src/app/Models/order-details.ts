export interface OrderDetails {
    orderId: number,
    customerId: string,
    totalAmountofOrder: number,
    orderDetailsProductWise: product[]
}

export interface product {
    id: number,
    productId: string,
    quantity: number,
    price: number,
    totalAmount: number
}
