using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Food_Delivery.Entities;

namespace Project_Food_Delivery.DataBase
{
    public class OrderDB
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order
            {
                orderId = 1,
                productName = "McCombo",
                restaurant = "McDonalds",
                quantity = 5,
                price = 5,
                deliveryCost = 10,
                //totalCost = 35
            }
        };
    }
}
