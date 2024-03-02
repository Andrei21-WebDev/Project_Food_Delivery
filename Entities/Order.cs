using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Food_Delivery.Entities
{
    public class Order
    {
        public int orderId { get; set; }
        public String productName { get; set; }
        public String restaurant { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int deliveryCost { get; set; }
        public int totalCost
        {
            get
            {
                return price * quantity;
            }
        }
    }
}
