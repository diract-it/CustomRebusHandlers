namespace CustomerRebusHandlers.Custom
{
    /// <summary>
    /// This message handler type is our custom handler interface
    /// </summary>
    public interface ICustomMessageHandler<TMessage>
    {
        void Handle(TMessage message, ICustomMessageContext context);
    }
}