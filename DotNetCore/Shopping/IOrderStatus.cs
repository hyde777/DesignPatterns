using System.Collections.Generic;

namespace Shopping
{
    public interface IOrderStatus
    {
        void AddItem(List<Item> items, Item item);
        
        void RemoveItem(List<Item> items, Item item);

        IOrderStatus NextStep();
    }
}