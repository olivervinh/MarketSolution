using Market.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Catalogs.Models
{
    public class ProductImage:AuditEntity<int>
    {    
        public string ImageName { get; set; }
        public bool IsThumbnail { get; set; }
        public int? FkProductId { get; set; }
        [ForeignKey(nameof(FkProductId))]
        public virtual Product Product { get; set; }
    }
}
