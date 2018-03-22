namespace FolderFile
{
    public class Link : IElement
    {
        private IElement _original;
        public string Name { get; set; }

        public IElement Original => _original;

        public Link(IElement original)
        {
            _original = original;
        }
    }
}
