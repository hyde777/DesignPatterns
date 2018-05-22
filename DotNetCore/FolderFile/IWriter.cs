public interface IWriter
{
    void Write(IElement element);
    void Write(Link link);
    void Write(File file);
    void Write(Folder folder);
}