using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryRepo.Loggers
{
    class TextLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("TextLogger : {0}", message);
        }
    }
}
