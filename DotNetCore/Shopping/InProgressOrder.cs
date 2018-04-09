using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class InProgressOrder : IOrder
    {
        private Status status = Status.InProgress;
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public IOrder NextStatus()
        {
            return new ValidatedOrder(this);
        }
    }
}
