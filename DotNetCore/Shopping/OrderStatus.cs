using System.Collections.Generic;

namespace Shopping
{
    public class OrderStatus : IOrderStatus
    {
         public void AddItem(List<Item> items, Item item)
        {

        }
        
        public void RemoveItem(List<Item> items, Item item)
        {

        }

        public IOrderStatus NextStep()
        {
            return new OrderStatus();
        }
    }
}