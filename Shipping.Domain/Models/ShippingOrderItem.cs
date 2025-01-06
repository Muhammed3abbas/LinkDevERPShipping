using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Domain.Models
{
    public class ShippingOrderItem
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int PalletCount { get; set; }
    }
}
