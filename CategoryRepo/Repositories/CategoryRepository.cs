using System.Collections.Generic;

namespace CategoryRepo
{
    class CategoryRepository
    {
        public IDatabaseConnection _DataConnection;

        public CategoryRepository(IDatabaseConnection dataConnection)
        {
            _DataConnection = dataConnection;
        }

        public List<Category> GetCategories()
        {
            _DataConnection.ConnectDatabase();
            return new List<Category>();
        }
    }
}
