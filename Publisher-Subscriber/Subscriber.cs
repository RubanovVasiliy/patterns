namespace Publisher_Subscriber;

public class Subscriber
{
    public void CallOperationsOn(Publisher publisher)
    {
        publisher.Operation();
    }
}