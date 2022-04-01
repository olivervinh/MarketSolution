using Market.Domain.Base;
using Market.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Catalogs.Models
{
    public class Product:AuditEntity<int>
    {  
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SellPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ImportPrice { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ProductImage> ImageProducts { get; set; }
        public int? FkCategoryId { get; set; }
        [ForeignKey(nameof(FkCategoryId))]
        public virtual Category Category { get; set; }
        public int? FkTagId { get; set; }
        [ForeignKey(nameof(FkTagId))]
        public virtual Tag Tag { get; set; }
    }
}
