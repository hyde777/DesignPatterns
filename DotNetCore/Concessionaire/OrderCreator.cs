using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public class OrderCreator<O>: IOrderCreator where O : IOrder, new()
    {
        public void CreateNewOrder(){
            IOrder order = CreateOrder();
            if(order.IsValid())
            {
                order.Pay();
            }
        }
        public IOrder CreateOrder()
        {
            return new O();
        }
    }
}