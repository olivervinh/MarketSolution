using Market.Domain.Base.Interfaces;
using Market.Domain.Catalogs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Catalogs.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
