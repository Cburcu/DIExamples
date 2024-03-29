﻿using System;
using UnityExample.Entities;

namespace UnityExample.Models
{
    class Driver
    {
        private ICar _car;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
