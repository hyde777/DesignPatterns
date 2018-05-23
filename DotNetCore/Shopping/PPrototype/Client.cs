namespace Shopping
{
    public class Client 
    {
        IOrder order;
        public Client()
        {
            order = new Order();
        }
        public void CreateOrderFromAnother()
        {
            // Order newOrder = duplica.Duplicate(order);
        }
    }
}