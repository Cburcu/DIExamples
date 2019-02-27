using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorExample
{
    class CompositionRoot : ICompositionRoot
    {
        readonly IConsoleWriter consoleWriter;
        readonly ISingleton singleton;

        public CompositionRoot(IConsoleWriter consoleWriter, ISingleton singleton)
        {
            this.consoleWriter = consoleWriter;
            this.singleton = singleton;
            consoleWriter.LogMessage("CompositionRoot Constructor!");
        }

        public void LogMessage(string message)
        {
            var msg = $"CompositionRoot.LogMessage:  singleton.ObjectId={singleton.ObjectId}";
            consoleWriter.LogMessage(msg);
            consoleWriter.LogMessage(message);
        }
    }
}
