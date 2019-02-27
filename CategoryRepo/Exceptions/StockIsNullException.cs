using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryRepo.Exceptions
{
    class StockIsNullException : Exception
    {
        public override string Message => "Stock is null!";
    }
}
