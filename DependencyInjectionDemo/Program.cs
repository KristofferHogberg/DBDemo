using System;
using Autofac;
using DemoLibrary;

namespace DependencyInjectionDemo
{
    class Program
    {
        // Token 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

        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }


            Console.ReadLine();
        }
    }
}
