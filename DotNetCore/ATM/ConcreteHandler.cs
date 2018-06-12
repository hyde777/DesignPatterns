using System;

namespace ATM
{
    public class ConcreteHandler : Handler
    {
        private Handler nextHandler;
        public  void HandleRequest()
        {
            // doStuff
            nextHandler.HandleRequest();
        }
    }
}
