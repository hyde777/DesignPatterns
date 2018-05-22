namespace ShoesFabric
{
    internal class StreetShoe : IShoe
    {
        private IType type;

        public StreetShoe(IType leather)
        {
            this.type = leather;
        }
    }
}