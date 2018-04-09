using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public interface IOrder
    {
         List<Item> Items { get ; }

        void AddItem(Item item);
        
        void RemoveItem(Item item);

        IOrder NextStatus();
    }
}
