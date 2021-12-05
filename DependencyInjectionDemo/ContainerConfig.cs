using System;
using System.Linq;
using System.Reflection;
using Autofac;
using DemoLibrary;

namespace DependencyInjectionDemo
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Länkar interface med klassen
            // "IBusinessLogic" returnerar en instans av "BusinessLogic"
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            // Nedan är samma sak fast för alla klasser och interface i mappen "Utilities"

            // I mappen "Utilities" hitta alla klasser, och knyt dom till matchande interfaces
            // Matcningen sker på följande sätt:
            // När "i.Name (namnet på interfacet) är lika med "I" + t.Name (namnet på själva klassen)
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));


            return builder.Build();
        } 
    }
}
