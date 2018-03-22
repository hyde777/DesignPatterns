namespace CarDealer
{
    public class Luxembourg : BasePays
    {
        private double _horsTaxeMateriel;
        private double _horsTaxeService;
        private double _taxePercentMateriel;
        private double _taxePercentService;
        public Luxembourg(double horsTaxeMateriel, double horsTaxeService, double taxePercentMateriel, double taxePercentService)
        {
            _horsTaxeMateriel = horsTaxeMateriel;
            _horsTaxeService = horsTaxeService;
            _taxePercentMateriel = taxePercentMateriel;
            _taxePercentService = taxePercentService;
        }
        public override double CalculateHt()
        {
            return _horsTaxeMateriel + _horsTaxeService;
        }

        public override double CalculateTva ()
        {
            return _horsTaxeMateriel * 12 / 100 + (_horsTaxeService * 15)/100;
        }
    }
}