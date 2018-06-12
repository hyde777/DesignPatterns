using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public class Context
    {
        IOrderCreator creator;
        public Context()
        {
            creator = new OrderCreator<ForwardOrder>();
        }
       
    }
}