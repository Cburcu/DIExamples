using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace CategoryRepo.DatabaseConnections
{
    class MongoDatabaseConnection : IDatabaseConnection
    {
        //public static Logger log = LogManager.GetCurrentClassLogger();

        public void ConnectDatabase()
        {
            //log.Info("Mongodb connected");
            Console.WriteLine("Mondodb Connected");
        }

        public void DisConnectDatabase()
        {
            //log.Info("Mondodb disconnected");

            Console.WriteLine("Mondodb Disconnected");
        }
    }
}
