using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularDemoSeeds.EntityFrameworkCore.Entity
{
    public class CustomerMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }
        public string District { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public int DeletedBy { get; set; }

        public ICollection<OrderMaster> OrderMasters { get; set; } = new List<OrderMaster>();
    }
}
