namespace CustomerRebusHandlers.Custom
{
    public interface ICustomBus
    {
        void Send(object message);
    }
}