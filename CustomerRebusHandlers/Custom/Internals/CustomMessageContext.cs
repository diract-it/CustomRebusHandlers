using Rebus.Bus;

namespace CustomerRebusHandlers.Custom.Internals
{
    class CustomMessageContext : ICustomMessageContext
    {
        readonly IBus _bus;

        public CustomMessageContext(IBus bus)
        {
            _bus = bus;
        }

        public void Reply(object reply)
        {
            _bus.Reply(reply).Wait();
        }
    }
}