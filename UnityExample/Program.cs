using System;
using Unity;
using UnityExample.Entities;
using UnityExample.Models;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver= new Driver(new Audi());
            //driver.RunCar();

            var container = new UnityContainer();
            container.RegisterType<ICar, Audi>();

            Driver driver = container.Resolve<Driver>();
            driver.RunCar();

            Console.ReadLine();
        }
    }
}
