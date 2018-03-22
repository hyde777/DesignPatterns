namespace CarDealer
{
    public abstract class BasePays : IPays
    {
        
        public double CalculateTTC()
        {
            return CalculateHt() + CalculateTva();
        }

        public abstract double CalculateHt();
        public abstract double CalculateTva();
    }
}