using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace CategoryRepo
{
    class LogManager
    {
        readonly ILogger logger;

        [Inject]
        public LogManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void Handle(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
