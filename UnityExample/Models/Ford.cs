using UnityExample.Entities;

namespace UnityExample.Models
{
    class Ford : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
