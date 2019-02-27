using System;
using NLog;

namespace CategoryRepo.DatabaseConnections
{
    class SqlServerDataConnection : IDatabaseConnection
    {
        //public static Logger log = LogManager.GetCurrentClassLogger();
        public void ConnectDatabase()
        {
            //log.Info("SqlServer connected");
            Console.WriteLine("SqlServer Connected");
        }

        public void DisConnectDatabase()
        {
            //log.Info("SqlServer Disconnected");
            Console.WriteLine("SqlServer Disconnected");
        }
    }
}
