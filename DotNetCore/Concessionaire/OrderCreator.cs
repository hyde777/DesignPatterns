using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public class OrderCreator
    {
        Dictionary<EPaymentType, Func<IOrder>> registry;
        
        public OrderCreator(Dictionary<EPaymentType, Func<IOrder>> registry)
        {
            this.registry = registry;
        }

        public IOrder CreateOrder(EPaymentType paymentType) => registry[paymentType]();
    }
}