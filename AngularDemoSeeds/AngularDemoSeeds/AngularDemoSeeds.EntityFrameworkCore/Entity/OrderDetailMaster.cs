using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularDemoSeeds.EntityFrameworkCore.Entity
{
    public class OrderDetailMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderMasterId { get; set; }
        public OrderMaster OrderMaster { get; set; }
        public int ProductMasterId { get; set; }
        public ProductMaster ProductMaster { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
