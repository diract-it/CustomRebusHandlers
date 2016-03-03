using System.Threading.Tasks;
using Rebus.Bus;
using Rebus.Handlers;

namespace CustomerRebusHandlers.Custom.Internals
{
    /// <summary>
    /// This handler delegates Rebus' handler invocation to the custom handler
    /// </summary>
    class CustomHandlerWrapper<TMessage> : IHandleMessages<TMessage>
    {
        readonly IBus _bus;

        public CustomHandlerWrapper(IBus bus)
        {
            _bus = bus;
        }

        // use property injection to make it optional
        public ICustomMessageHandler<TMessage> CustomMessageHandler { get; set; }

        public async Task Handle(TMessage message)
        {
            CustomMessageHandler?.Handle(message, new CustomMessageContext(_bus));
        }
    }
}