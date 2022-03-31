using Market.Domain.Base.Interfaces;
using Market.Domain.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Orders.Repository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }
}
