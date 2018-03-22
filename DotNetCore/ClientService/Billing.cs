using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService
{
    public class Billing : IBilling
    {
        public void AddOption(Order order, Option option)
        {
            order.AddNewOption(option);
        }

        public void Edit(Order order)
        {
            // Edit order
        }
    }
}
