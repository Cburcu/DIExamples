using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace CastleWindsorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingleton>().ImplementedBy<Singleton>());


            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("LogMessage message");
            Console.ReadLine();
        }
    }
}
