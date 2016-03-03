using Rebus.Bus;

namespace CustomerRebusHandlers.Custom.Internals
{
    class CustomBus : ICustomBus
    {
        readonly IBus _bus;

        public CustomBus(IBus bus)
        {
            _bus = bus;
        }

        public void Send(object message)
        {
            _bus.Send(message).Wait();
        }
    }
}