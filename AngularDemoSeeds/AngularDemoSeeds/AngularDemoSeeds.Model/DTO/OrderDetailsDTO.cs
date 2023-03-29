namespace AngularDemoSeeds.Model.DTO
{
    public class OrderDetailsDTO
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmountofOrder { get; set; }
        public List<OrderDetailsProductWiseDTO> OrderDetailsProductWise { get; set; } = new List<OrderDetailsProductWiseDTO>();
    }
}
