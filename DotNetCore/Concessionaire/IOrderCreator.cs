using System;
using System.Collections.Generic;

namespace Concessionaire
{
    public interface IOrderCreator
    {
        IOrder CreateOrder();
        void CreateNewOrder() ;
    }
}