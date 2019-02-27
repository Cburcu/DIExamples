using UnityExample.Entities;

namespace UnityExample.Models
{
    class BMW : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
