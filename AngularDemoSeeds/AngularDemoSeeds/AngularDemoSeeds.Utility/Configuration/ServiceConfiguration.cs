using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Application.Services;
using AngularDemoSeeds.EntityFrameworkCore.DataContext;
using AngularDemoSeeds.Repository.InterfaceRepository;
using AngularDemoSeeds.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngularDemoSeeds.Utility.Configuration
{
    public static class ServiceConfiguration
    {
        /// <summary>
        /// AddInfrastructure used for registering services before build 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            #region database context register
            services.AddDbContext<AngularDemoSeedDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString")));
            #endregion

            #region manager
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>(); 
            services.AddTransient<ICustomerService, CustomerService>();
            #endregion

            #region repository
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            #endregion

        }
    }
}
