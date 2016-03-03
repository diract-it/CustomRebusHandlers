namespace CustomerRebusHandlers.Custom
{
    public interface ICustomMessageHandler<TMessage>
    {
        void Handle(TMessage message, ICustomMessageContext context);
    }
}