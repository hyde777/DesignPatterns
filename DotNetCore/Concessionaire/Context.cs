using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public class Context
    {
        OrderCreator creator;
        public Context()
        {
            Dictionary<EPaymentType, Func<IOrder>> regi = new Dictionary<EPaymentType, Func<IOrder>> 
            {
                {EPaymentType.Spot, () => new SpotOrder()},
                {EPaymentType.Forward, () => new ForwardOrder()}
            };
            creator = new OrderCreator(regi);
        }
        public void CreateNewOrder() 
        {
            IOrder order = creator.CreateOrder(EPaymentType.Forward);
            if(order.IsValid())
            {
                order.Pay();
            }
        }
    }
}