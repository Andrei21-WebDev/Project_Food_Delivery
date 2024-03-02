using System;
using Project_Food_Delivery.DataBase;
using Project_Food_Delivery.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Food_Delivery.DataBase
{
    public class CustomerDB
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer
            {
                customerId = 1,
                firstName = "Will",
                lastName = "Smith",
                deliveryAddress = "Los Angeles, USA",
                phoneNumber = 123,
                paymentMethod = "Card"
            }
        };
    }
}
