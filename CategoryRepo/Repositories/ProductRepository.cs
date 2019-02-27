using System.Collections.Generic;
using Ninject;

namespace CategoryRepo.Repositories
{
    public class ProductRepository
    {
        private IDatabaseConnection _DatabaseConnection;
        private ILogger _Logger;

        [Inject]
        public ProductRepository(IDatabaseConnection databaseConnection, ILogger logger)
        {
            _DatabaseConnection = databaseConnection;
            _Logger = logger;
        }

        public List<Product> GetProducts()
        {
            this._Logger.WriteLog("Ürünler listelendi!");
            _DatabaseConnection.ConnectDatabase();
            return new List<Product>();
        }
    }
}
