using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using CustomerRebusHandlers.Custom;
using Rebus.CastleWindsor;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using Rebus.Transport.InMem;

namespace CustomerRebusHandlers
{
    class Program
    {
        static void Main()
        {
            using (var container = new WindsorContainer())
            {
                container.Install(FromAssembly.This());

                Configure.With(new CastleWindsorContainerAdapter(container))
                    .Transport(t => t.UseInMemoryTransport(new InMemNetwork(), "custom-handlers"))
                    .Routing(r => r.TypeBased().Map<string>("custom-handlers"))
                    .Start();

                var customBus = container.Resolve<ICustomBus>();

                customBus.Send("Hello there!!");

                Console.WriteLine("Press ENTER to quit");
                Console.ReadLine();
            }
        }
    }
}
