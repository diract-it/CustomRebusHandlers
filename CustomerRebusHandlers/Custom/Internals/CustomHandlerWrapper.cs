using System.Threading.Tasks;
using Rebus.Bus;
using Rebus.Handlers;

namespace CustomerRebusHandlers.Custom.Internals
{
    public class CustomHandlerWrapper<TMessage> : IHandleMessages<TMessage>
    {
        readonly IBus _bus;
        readonly ICustomMessageHandler<TMessage> _customMessageHandler;

        public CustomHandlerWrapper(IBus bus, ICustomMessageHandler<TMessage> customMessageHandler)
        {
            _bus = bus;
            _customMessageHandler = customMessageHandler;
        }

        public async Task Handle(TMessage message)
        {
            _customMessageHandler.Handle(message, new CustomMessageContext(_bus));
        }
    }
}