using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CustomerRebusHandlers.Custom;
using CustomerRebusHandlers.Custom.Internals;
using Rebus.Handlers;

namespace CustomerRebusHandlers.Installers
{
    public class CustomStuffInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ICustomBus>().ImplementedBy<CustomBus>(),

                Classes.FromThisAssembly()
                    .BasedOn(typeof(ICustomMessageHandler<>))
                    .WithServiceAllInterfaces()
                    .LifestyleTransient(),

                Component.For(typeof(IHandleMessages<string>))
                    .ImplementedBy(typeof(CustomHandlerWrapper<string>))
                    .LifestyleTransient()
                );
        }
    }
}