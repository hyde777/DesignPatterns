public class Writer
{
    void Write(IElement element)
    {
        element.Accept(this);
    }

    void Write(Link link)
    {
        Console.WriteLine(link.Name);
    }

    void Write(File file)
    {
        //
    }

    void Write(Folder folder)
    {
        //
    }
}