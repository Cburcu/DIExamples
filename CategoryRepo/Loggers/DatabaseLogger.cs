using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryRepo.Loggers
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("DatabaseLogger : {0}", message);
        }
    }
}
