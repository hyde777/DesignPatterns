namespace CarDealer
{
    public class France : BasePays
    {
        double _horsTaxe;
        double _taxePercent;

        public France(double ht, double taxe)
        {
            _horsTaxe = ht;
            _taxePercent = taxe;
        }
        public override double CalculateHt()
        {
            return _horsTaxe;
        }

        public override double CalculateTva()
        {
            return _horsTaxe * _taxePercent / 100;
        }
    }
}