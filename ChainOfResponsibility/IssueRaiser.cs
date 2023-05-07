namespace ChainOfResponsibility
{
    public class IssueRaiser
    {
        public IReceiver setFirstReceiver;
        public IssueRaiser(IReceiver firstReceiver)
        {
            this.setFirstReceiver = firstReceiver;
        }
        public void RaiseMessage(Message message)
        {
            if (setFirstReceiver != null)
                setFirstReceiver.HandleMessage(message);
        }
    }
}