namespace Facade;

public class Facade
{
    public ElementA elementA;
    public ElementB elementB;

    public void HelloWorld()
    {
        elementA = new ElementA();
        elementB = new ElementB();
        
        elementA.Hello();
        elementB.World();
    }
}