using System;
using NLog;
using NLog.Fluent;

namespace CategoryRepo
{
    class PostgreDatabaseConnection : IDatabaseConnection
    {
        //public static Logger log = LogManager.GetCurrentClassLogger();

        public void ConnectDatabase()
        {
            //log.Info("Postgre connected");
            Console.WriteLine("Postgre Connected");
        }

        public void DisConnectDatabase()
        {
            //log.Info("Postgre disconnected");

            Console.WriteLine("Postgre Disconnected");
        }
    }
}