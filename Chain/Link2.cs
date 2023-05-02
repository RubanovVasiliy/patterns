namespace Chain;

public class Link2
{
    public void Method()
    {
        var link = new Link1();
        link.Method();
        Console.WriteLine("Link2");
    }
}