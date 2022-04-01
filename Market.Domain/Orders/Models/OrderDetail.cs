using Market.Domain.Base;
using Market.Domain.Catalogs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain.Orders.Models
{
    public class OrderDetail : AuditEntity<int>
    {      
        public int Quantity { get; set; }
        public decimal? TotalItemPrice { get; set; }
        public int? FkOrderId { get; set; }
        [ForeignKey(nameof(FkOrderId))]
        public virtual Order Order { get; set; }
        public int? FkProductId { get; set; }
        [ForeignKey(nameof(FkProductId))]
        public virtual Product Product { get; set; }
     
    }
}
