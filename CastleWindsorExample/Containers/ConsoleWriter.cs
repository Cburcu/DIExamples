using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorExample
{
    class ConsoleWriter : IConsoleWriter
    {
        readonly ISingleton singleton;

        public ConsoleWriter(ISingleton singleton)
        {
            this.singleton = singleton;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("ConsoleWriter.LogMessage:  singleton.ObjectId={0}",
                singleton.ObjectId);
            Console.WriteLine(message);
        }
    }
}
