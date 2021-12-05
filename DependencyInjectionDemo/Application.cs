using System;
using DemoLibrary;

namespace ConsoleUI
{
    public class Application
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
