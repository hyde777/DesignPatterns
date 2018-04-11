using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class ValidatedStatus : IOrderStatus
    {
        public ValidatedStatus(InProgressStatus ips)
        {

        }
        public void AddItem(List<Item> items, Item item)
        {
            throw new System.NotSupportedException();
        }

        public void RemoveItem(List<Item> items, Item item)
        {
            items.Remove(item);
        }

        public IOrderStatus NextStep()
        {
            return new DeliveredStatus(this);
        }
    }
}
