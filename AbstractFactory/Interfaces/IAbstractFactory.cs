namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractMobile Build(string mobileType);
    }
}