export class UrlConfiguration {

    //URL Method
    public static get getAllOrder():string { return "Order/Get/" };
    public static get getAllProducts():string { return "Product/Get/" };
    public static get getCustomerDetails ():string { return "Customer/Get/" };
    public static get getOrderbyId():string { return "Order/GetById/" };
    public static get saveUpdateOrder():string { return "Order/SaveOrUpdate/" };
    public static get baseAPIURL():string { return "https://localhost:7245/api/" };

}
