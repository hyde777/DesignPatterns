namespace FolderFile
{
    public class Writer : IWriter
    {
        public void Write(IElement element)
        {
            element.Accept(this);
        }

        public void Write(Link link)
        {
             // Console.WriteLine(link.Name);
        }

        public void Write(File file)
        {
            //
        }

        public void Write(Folder folder)
        {
            //
        }
    }
}