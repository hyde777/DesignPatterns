namespace Shopping
{
    public interface IOriginator
    {
        void SetMemento(Memento memento);
        Memento CreateMemento();
    }
}