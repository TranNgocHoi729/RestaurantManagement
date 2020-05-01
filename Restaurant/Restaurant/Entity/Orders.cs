using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entity
{
    class Orders
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public String OrderDate { get; set; }
        public int NumTable { get; set; }
        public String Description { get; set; }

        public Orders(int iD, int customerID, string orderDate, int numTable, string description)
        {
            ID = iD;
            CustomerID = customerID;
            OrderDate = orderDate;
            NumTable = numTable;
            Description = description;
        }

        public Orders()
        {
            
        }


    }
}
