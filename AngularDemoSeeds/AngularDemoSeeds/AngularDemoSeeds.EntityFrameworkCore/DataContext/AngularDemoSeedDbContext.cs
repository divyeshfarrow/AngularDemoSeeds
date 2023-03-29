using AngularDemoSeeds.EntityFrameworkCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace AngularDemoSeeds.EntityFrameworkCore.DataContext
{
    public class AngularDemoSeedDbContext : DbContext
    {
        public AngularDemoSeedDbContext(DbContextOptions<AngularDemoSeedDbContext> options) : base(options)
        {
        }
        
        public DbSet<CustomerMaster> CustomerMasters { get; set; }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetailMaster> OrderDetailMasters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductMaster>().HasData(
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 1, ProductName = "Product 1", Price = Convert.ToDecimal(12.15) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 2, ProductName = "Product 2", Price = Convert.ToDecimal(20.00) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 3, ProductName = "Product 3", Price = Convert.ToDecimal(92.50) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 4, ProductName = "Product 4", Price = Convert.ToDecimal(24.25) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 5, ProductName = "Product 5", Price = Convert.ToDecimal(27.89) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 6, ProductName = "Product 6", Price = Convert.ToDecimal(610.00) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 7, ProductName = "Product 7", Price = Convert.ToDecimal(1000.16) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 8, ProductName = "Product 8", Price = Convert.ToDecimal(85.74) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 9, ProductName = "Product 9", Price = Convert.ToDecimal(52.50) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 10, ProductName = "Product 10", Price = Convert.ToDecimal(66.79) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 11, ProductName = "Product 11", Price = Convert.ToDecimal(18.95) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 12, ProductName = "Product 12", Price = Convert.ToDecimal(63.67) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 13, ProductName = "Product 13", Price = Convert.ToDecimal(69.69) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 14, ProductName = "Product 14", Price = Convert.ToDecimal(69.17) },
                new ProductMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 15, ProductName = "Product 15", Price = Convert.ToDecimal(17.42) }
            );

            modelBuilder.Entity<CustomerMaster>().HasData(
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 1, CustomerName = "Customer 1", PhoneNumber = "9876543210", Address = "Customer 1", District = "Customer 1", Pincode = 1 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 2, CustomerName = "Customer 2", PhoneNumber = "9876543210", Address = "Customer 2", District = "Customer 2", Pincode = 2 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 3, CustomerName = "Customer 3", PhoneNumber = "9876543210", Address = "Customer 3", District = "Customer 3", Pincode = 3 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 4, CustomerName = "Customer 4", PhoneNumber = "9876543210", Address = "Customer 4", District = "Customer 4", Pincode = 4 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 5, CustomerName = "Customer 5", PhoneNumber = "9876543210", Address = "Customer 5", District = "Customer 5", Pincode = 5 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 6, CustomerName = "Customer 6", PhoneNumber = "9876543210", Address = "Customer 6", District = "Customer 6", Pincode = 6 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 7, CustomerName = "Customer 7", PhoneNumber = "9876543210", Address = "Customer 7", District = "Customer 7", Pincode = 7 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 8, CustomerName = "Customer 8", PhoneNumber = "9876543210", Address = "Customer 8", District = "Customer 8", Pincode = 8 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 9, CustomerName = "Customer 9", PhoneNumber = "9876543210", Address = "Customer 9", District = "Customer 9", Pincode = 9 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 10, CustomerName = "Customer 10", PhoneNumber = "9876543210", Address = "Customer 10", District = "Customer 10", Pincode = 10 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 11, CustomerName = "Customer 11", PhoneNumber = "9876543210", Address = "Customer 11", District = "Customer 11", Pincode = 11 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 12, CustomerName = "Customer 12", PhoneNumber = "9876543210", Address = "Customer 12", District = "Customer 12", Pincode = 12 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 13, CustomerName = "Customer 13", PhoneNumber = "9876543210", Address = "Customer 13", District = "Customer 13", Pincode = 13 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 14, CustomerName = "Customer 14", PhoneNumber = "9876543210", Address = "Customer 14", District = "Customer 14", Pincode = 14 },
                new CustomerMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 15, CustomerName = "Customer 15", PhoneNumber = "9876543210", Address = "Customer 15", District = "Customer 15", Pincode = 15 }
            );


            modelBuilder.Entity<OrderMaster>().HasData(
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 1, CustomerMasterId = 1, TotalOrderAmount = Convert.ToDecimal(12.15) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 2, CustomerMasterId = 2, TotalOrderAmount = Convert.ToDecimal(20.00) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 3, CustomerMasterId = 3, TotalOrderAmount = Convert.ToDecimal(92.50) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 4, CustomerMasterId = 4, TotalOrderAmount = Convert.ToDecimal(24.25) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 5, CustomerMasterId = 5, TotalOrderAmount = Convert.ToDecimal(27.89) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 6, CustomerMasterId = 6, TotalOrderAmount = Convert.ToDecimal(610.00) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 7, CustomerMasterId = 7, TotalOrderAmount = Convert.ToDecimal(1000.16) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 8, CustomerMasterId = 8, TotalOrderAmount = Convert.ToDecimal(85.74) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 9, CustomerMasterId = 9, TotalOrderAmount = Convert.ToDecimal(52.50) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 10, CustomerMasterId = 10, TotalOrderAmount = Convert.ToDecimal(78.94) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 11, CustomerMasterId = 11, TotalOrderAmount = Convert.ToDecimal(38.95) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 12, CustomerMasterId = 12, TotalOrderAmount = Convert.ToDecimal(156.17) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 13, CustomerMasterId = 13, TotalOrderAmount = Convert.ToDecimal(139.38) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 14, CustomerMasterId = 14, TotalOrderAmount = Convert.ToDecimal(138.34) },
                new OrderMaster { IsActive = true, IsDeleted = false, CreatedBy = 1, CreatedDate = DateTime.Now, Id = 15, CustomerMasterId = 15, TotalOrderAmount = Convert.ToDecimal(34.84) }
            );

            modelBuilder.Entity<OrderDetailMaster>().HasData(
                new OrderDetailMaster { Id = 1, OrderMasterId = 1, ProductMasterId = 1, Quantity = 1, TotalAmount = Convert.ToDecimal(12.15) },
                new OrderDetailMaster { Id = 2, OrderMasterId = 2, ProductMasterId = 2, Quantity = 1, TotalAmount = Convert.ToDecimal(20.00) },
                new OrderDetailMaster { Id = 3, OrderMasterId = 3, ProductMasterId = 3, Quantity = 1, TotalAmount = Convert.ToDecimal(92.50) },
                new OrderDetailMaster { Id = 4, OrderMasterId = 4, ProductMasterId = 4, Quantity = 1, TotalAmount = Convert.ToDecimal(24.25) },
                new OrderDetailMaster { Id = 5, OrderMasterId = 5, ProductMasterId = 5, Quantity = 1, TotalAmount = Convert.ToDecimal(27.89) },
                new OrderDetailMaster { Id = 6, OrderMasterId = 6, ProductMasterId = 6, Quantity = 1, TotalAmount = Convert.ToDecimal(610.00) },
                new OrderDetailMaster { Id = 7, OrderMasterId = 7, ProductMasterId = 7, Quantity = 1, TotalAmount = Convert.ToDecimal(1000.16) },
                new OrderDetailMaster { Id = 8, OrderMasterId = 8, ProductMasterId = 8, Quantity = 1, TotalAmount = Convert.ToDecimal(85.74) },
                new OrderDetailMaster { Id = 9, OrderMasterId = 9, ProductMasterId = 9, Quantity = 1, TotalAmount = Convert.ToDecimal(52.50) },
                new OrderDetailMaster { Id = 10, OrderMasterId = 10, ProductMasterId = 10, Quantity = 1, TotalAmount = Convert.ToDecimal(66.79) },
                new OrderDetailMaster { Id = 11, OrderMasterId = 11, ProductMasterId = 11, Quantity = 1, TotalAmount = Convert.ToDecimal(18.95) },
                new OrderDetailMaster { Id = 12, OrderMasterId = 12, ProductMasterId = 12, Quantity = 1, TotalAmount = Convert.ToDecimal(63.67) },
                new OrderDetailMaster { Id = 13, OrderMasterId = 13, ProductMasterId = 13, Quantity = 2, TotalAmount = Convert.ToDecimal(139.38) },
                new OrderDetailMaster { Id = 14, OrderMasterId = 14, ProductMasterId = 14, Quantity = 2, TotalAmount = Convert.ToDecimal(138.34) },
                new OrderDetailMaster { Id = 15, OrderMasterId = 15, ProductMasterId = 15, Quantity = 2, TotalAmount = Convert.ToDecimal(34.84) },
                new OrderDetailMaster { Id = 16, OrderMasterId = 10, ProductMasterId = 1, Quantity = 1, TotalAmount = Convert.ToDecimal(12.15) },
                new OrderDetailMaster { Id = 17, OrderMasterId = 11, ProductMasterId = 2, Quantity = 1, TotalAmount = Convert.ToDecimal(20.00) },
                new OrderDetailMaster { Id = 18, OrderMasterId = 12, ProductMasterId = 3, Quantity = 1, TotalAmount = Convert.ToDecimal(92.50) }
            );
        }
    }
}
