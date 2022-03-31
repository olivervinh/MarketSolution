using Market.Domain.Base.Interfaces;
using Market.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Users.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
