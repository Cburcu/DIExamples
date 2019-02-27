using CategoryRepo.DatabaseConnections;
using CategoryRepo.Loggers;
using Ninject.Modules;

namespace CategoryRepo
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<DatabaseLogger>();
            Bind<IDatabaseConnection>().To<SqlServerDataConnection>();
        }
    }
}
