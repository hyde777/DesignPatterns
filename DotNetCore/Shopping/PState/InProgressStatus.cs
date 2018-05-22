using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class InProgressStatus : IOrderStatus
    {

        public InProgressStatus()
        {
        }
        public void AddItem(List<Item> items, Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(List<Item> items, Item item)
        {
            items.Remove(item);
        }

        public IOrderStatus NextStep()
        {
            return new ValidatedStatus(this);
        }
    }
}
