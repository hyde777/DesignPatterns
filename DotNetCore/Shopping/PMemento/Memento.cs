namespace Shopping
{
    public class Memento
    {
        public Memento(IOrderStatus status)
        {

        }

        IOrderStatus GetState()
        {
            return new OrderStatus();
        }
    }
}