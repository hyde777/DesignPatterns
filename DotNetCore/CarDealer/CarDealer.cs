namespace CarDealer
{
    public class CarDealer
    {
        IPays _pays;
        CarDealer(IPays pays)
        {
            _pays = pays;
        }
        void Command(Product prod)
        {
            _pays.CalculateTTC();
        }
    }
}