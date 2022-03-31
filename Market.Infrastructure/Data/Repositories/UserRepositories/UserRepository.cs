using Market.Domain.Users.Models;
using Market.Domain.Users.Repository;
using Market.Infrastructure.Data.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Data.Repositories.UserRepositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
