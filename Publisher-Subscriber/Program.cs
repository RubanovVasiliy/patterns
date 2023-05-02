namespace Publisher_Subscriber;

class Program
{
    static void Main()
    {
        var publisher = new Publisher();
        var subscriber = new Subscriber();

        publisher.SendMessageTo(subscriber);
    }
}