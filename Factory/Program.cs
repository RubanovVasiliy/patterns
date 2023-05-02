namespace Factory;

internal static class Program
{
    static void Main()
    {
        var factory = new Factory();
        var product = factory.FactoryMethod();
    }
}