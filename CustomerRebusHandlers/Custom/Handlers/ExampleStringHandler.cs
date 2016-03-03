using System;

namespace CustomerRebusHandlers.Custom.Handlers
{
    public class ExampleStringHandler : ICustomMessageHandler<string>
    {
        public void Handle(string message, ICustomMessageContext context)
        {
            Console.WriteLine("This is just me, handling a string...");
        }
    }
}