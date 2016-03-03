using System;

namespace CustomerRebusHandlers.Custom.Handlers
{
    /// <summary>
    /// This is what an actual handler could look like
    /// </summary>
    public class ExampleStringHandler : ICustomMessageHandler<string>
    {
        public void Handle(string message, ICustomMessageContext context)
        {
            Console.WriteLine("This is just me, handling a string...");
        }
    }
}