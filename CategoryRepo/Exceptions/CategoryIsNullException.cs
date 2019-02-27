using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryRepo.Exceptions
{
    class CategoryIsNullException : Exception
    {
        public override string Message => "Category stock is null!";
    }
}
