using Market.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Catalogs.Models
{
    public class Category : AuditEntity<int>
    {
        public string Name { get; set; }  
        public virtual ICollection<Product> Products { get; set; }
    }
}
