using Market.Domain.Catalogs.Models;
using Market.Domain.Catalogs.Repository;
using Market.Infrastructure.Data.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Data.Repositories.CatalogRepositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}