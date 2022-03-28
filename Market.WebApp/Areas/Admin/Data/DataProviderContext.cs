using Market.WebApp.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebApp.Areas.Admin.Data
{
    public class DataProviderContext : DbContext
    {
        public DataProviderContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ImageProduct> ImageProducts { get; set; }
    }
}
