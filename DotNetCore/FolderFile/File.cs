namespace FolderFile
{
    public class File : IElement
    {
        public string Name { get; set; }
        public void Accept(IWriter writer)
        {
            writer.Write(this);
        }
    }
}
