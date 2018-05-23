using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Order : IOrder, ICloneable<Order>, IOriginator
    {
        private IOrderStatus status;
        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }
        
        public Order()
        {
            status = new InProgressStatus();
        }

        public void AddItem(Item item)
        {
            status.AddItem(items, item);
        }

        public void RemoveItem(Item item)
        {
            status.RemoveItem(items, item);
        }

        public Order Clone()
        {
            return (Order)this.MemberwiseClone();
        }

        public void NextStatus()
        {
             
        }

         public void SetMemento(Memento memento)
        {

        }

        public Memento CreateMemento()
        {
            return new Memento(status);
        }
    }
}
