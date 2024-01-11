using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    // Car class inheriting from Vehicle
    class Car : Vehicle
    {
        public int MaxSpeed { get; set; }
        public string Color { get; set; }

        public Car(string registrationNumber, int power, int maxSpeed, string color)
            : base(registrationNumber, power)
        {
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public override void Move()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}
