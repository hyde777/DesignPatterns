using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class ValidatedOrder : IOrder
    {
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public ValidatedOrder(InProgressOrder ipo)
        {
            this.items = ipo.Items;
        }
        public void AddItem(Item item)
        {
            throw new System.NotSupportedException();
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public IOrder NextStatus()
        {
            return new DeliveredOrder(this);
        }
    }
}
