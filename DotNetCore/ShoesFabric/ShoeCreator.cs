namespace ShoesFabric
{
    public class ShoeCreator : IShoeCreator
    {
        public IShoe CreateLeatherShoe()
        {
            return new StreetShoe(new Leather());
        }

        public IShoe CreateLeatherSandal()
        {
            return new Sandal(new Leather());
        }

        public IShoe CreateSyntheticShoe()
        {
            return new StreetShoe(new Synthetic());
        }

        public IShoe CreateSyntheticSandal()
        {
            return new Sandal(new Synthetic());
        }
    }
}
