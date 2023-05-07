namespace ChainOfResponsibility
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}