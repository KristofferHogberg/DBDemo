using System;
using DemoLibrary;

namespace DependencyInjectionDemo
{
    public class Application : IApplication
    {
        IBusinessLogic _businesLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businesLogic = businessLogic;
        }

       public void Run()
        {
            _businesLogic.ProcessData();
        }
    }
}
