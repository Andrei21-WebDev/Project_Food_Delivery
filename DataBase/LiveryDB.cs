using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Food_Delivery.Entities;

namespace Project_Food_Delivery.DataBase
{
    public class LiveryDB
    {
        public static List<Livery> Livery = new List<Livery>()
        {
            new Livery
            {
                liveryId = 1,
                firstName = "John",
                lastName = "Smith",
                phoneNumber = "0745 852 659",
                traveledDistance = 15
            }
        };
    }
}
