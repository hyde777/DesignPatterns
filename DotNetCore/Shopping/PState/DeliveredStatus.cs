using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class DeliveredStatus : IOrderStatus
    {
        public DeliveredStatus(ValidatedStatus status)
        {

        }

        public void AddItem(List<Item> items, Item item)
        {
            throw new System.NotSupportedException();
        }

        public void RemoveItem(List<Item> items, Item item)
        {
            throw new System.NotSupportedException();
        }

        public IOrderStatus NextStep()
        {
            throw new System.NotImplementedException();
        }
    }
}
