namespace ClientService
{
    // Facade
    public class ClientService
    {
        private IOrdering _ordering;
        private IBilling _billing;

        public ClientService(IOrdering ordering, IBilling billing)
        {
            _ordering = ordering;
            _billing = billing;
        }

        void UpdateAdress(Client client, Adress adress)
        {
            _ordering.UpdateAdress(client, adress);
        }

        void AddOption(Order order, Option option)
        {
            _billing.AddOption(order, option);
        }
    }
}