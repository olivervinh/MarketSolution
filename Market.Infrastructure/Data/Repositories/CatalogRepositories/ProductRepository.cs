using Market.Domain.Catalogs.Models;
using Market.Infrastructure.Data.GenericRepository;
using Market.Domain.Catalogs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Data.Repositories.CatalogRepositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}