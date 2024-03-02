using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Food_Delivery.Entities
{
    public class Customer
    {
        public int customerId {get; set;}
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String deliveryAddress { get; set; }
        public int phoneNumber { get; set; }
        public String paymentMethod { get; set; }
    }
}
