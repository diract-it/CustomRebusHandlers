using System.Threading.Tasks;
using Rebus.Bus;
using Rebus.Handlers;

namespace CustomerRebusHandlers.Custom.Internals
{
    public class CustomHandlerWrapper<TMessage> : IHandleMessages<TMessage>
    {
        readonly IBus _bus;

        public CustomHandlerWrapper(IBus bus)
        {
            _bus = bus;
        }

        public ICustomMessageHandler<TMessage> CustomMessageHandler { get; set; }

        public async Task Handle(TMessage message)
        {
            CustomMessageHandler?.Handle(message, new CustomMessageContext(_bus));
        }
    }
}