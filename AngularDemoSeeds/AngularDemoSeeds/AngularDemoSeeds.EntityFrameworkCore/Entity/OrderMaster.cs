using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularDemoSeeds.EntityFrameworkCore.Entity
{
    public class OrderMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CustomerMasterId { get; set; }
        public CustomerMaster CustomerMaster { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public int DeletedBy { get; set; }

        public ICollection<OrderDetailMaster> OrderDetailMasters { get; set; } = new List<OrderDetailMaster>();
    }
}
