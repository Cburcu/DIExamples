using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorExample
{
    class Singleton : ISingleton
    {
        public Singleton()
        {
            ObjectId = Guid.NewGuid();
        }
        public Guid ObjectId { get; }
    }
}
