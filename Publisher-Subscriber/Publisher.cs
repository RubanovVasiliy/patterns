namespace Publisher_Subscriber;

public class Publisher
{
    public void Operation()
    {
        Console.WriteLine("Операция выполнена");
    }

    public void SendMessageTo(Subscriber subscriber)
    {
        subscriber.CallOperationsOn(this);
    }
}