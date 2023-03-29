namespace AngularDemoSeeds.Model.DTO
{
    public class OrderDetailsProductWiseDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
