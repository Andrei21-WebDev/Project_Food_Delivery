using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Food_Delivery.DataBase;
using Project_Food_Delivery.Entities;
using Project_Food_Delivery.Repositories;


namespace Project_Food_Delivery.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAll()
        {
            return CustomerDB.Customers;
        }
    }
}
