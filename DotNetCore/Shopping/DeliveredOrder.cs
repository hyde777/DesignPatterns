using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class DeliveredOrder : IOrder
    {
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public DeliveredOrder(ValidatedOrder vo)
        {
            items = vo.Items;
        }
        public void AddItem(Item item)
        {
            throw new System.NotSupportedException();
        }

        public void RemoveItem(Item item)
        {
            throw new System.NotSupportedException();
        }

        public IOrder NextStatus()
        {
            throw new System.NotSupportedException();
        }
    }
}
