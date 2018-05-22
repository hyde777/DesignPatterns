namespace ShoesFabric
{
    internal class Sandal : IShoe
    {
        private IType type;

        public Sandal(IType leather)
        {
            this.type = leather;
        }
    }
}