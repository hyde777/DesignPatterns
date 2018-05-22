namespace Shopping
{
    public class Client 
    {
        Order order;
        
        public Client()
        {
            order = new Order();
        }
        public void CreateOrderFromAnother()
        {
            Order newOrder = order.Clone();
        }
    }
}