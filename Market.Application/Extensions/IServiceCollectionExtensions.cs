using Market.Application.Services.Catalogs;
using Market.Application.Services.Orders;
using Market.Application.Services.Users;
using Market.Domain.Base.Interfaces;
using Market.Domain.Catalogs.Repository;
using Market.Domain.Orders.Repository;
using Market.Domain.Users.Repository;
using Market.Infrastructure.Data;
using Market.Infrastructure.Data.GenericRepository;
using Market.Infrastructure.Data.Repositories.CatalogRepositories;
using Market.Infrastructure.Data.Repositories.OrderRepositories;
using Market.Infrastructure.Data.Repositories.UserRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Market.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure DbContext with Scoped lifetime
            services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("db"));
                    options.UseLazyLoadingProxies();
                }
            );

            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<IProductImageRepository, ProductImageRepository>()
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<IOrderDetailRepository, OrderDetailRepository>()
                .AddScoped<ITagRepository, TagRepository>()
                .AddScoped<ICategoryRepository, CategoryRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<OrderService>()
                .AddScoped<UserService>()
                .AddScoped<ProductService>();
        }
    }
}
