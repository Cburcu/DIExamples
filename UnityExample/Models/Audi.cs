using UnityExample.Entities;

namespace UnityExample.Models
{
    class Audi : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
