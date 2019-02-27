using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwDIExamples
{
    public class CustomerRepository
    {
        private readonly IDatabaseConnection _databaseConnection;

        public CustomerRepository(IDatabaseConnection databaseConnection)
        {
            if (databaseConnection == null)
            {
                throw new ArgumentNullException("databaseConnection");
            }

            _databaseConnection = databaseConnection;
        }

        public Customer[] GetCustomers()
        {
            // uses _databaseConnection to retrieve customers.
            return new Customer[5];
        }
    }
}
