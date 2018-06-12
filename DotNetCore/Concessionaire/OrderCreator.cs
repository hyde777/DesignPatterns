using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public class SpotOrderCreator : OrderCreator
    {
        public override IOrder CreateOrder()
        {
            return new SpotOrder();
        }
    }
}