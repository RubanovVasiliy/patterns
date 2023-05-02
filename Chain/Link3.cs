namespace Chain;

public class Link3
{
    public void Method()
    {
        var link = new Link2();
        link.Method();
        Console.WriteLine("Link3");
    }
}