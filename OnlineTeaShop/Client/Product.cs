using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTeaShop.Client
{
    public class Product
    {
        public int? ProductId { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public DateTime DeliveryOn { get; set; }

        public Product()
        {
        }


    }
}
