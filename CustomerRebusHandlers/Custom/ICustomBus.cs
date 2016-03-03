namespace CustomerRebusHandlers.Custom
{
    /// <summary>
    /// Just to show that the bus instance is wrapped on the sender's side too
    /// </summary>
    public interface ICustomBus
    {
        void Send(object message);
    }
}