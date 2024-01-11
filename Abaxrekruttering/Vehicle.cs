using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    // Base class for vehicles
    class Vehicle : IMovable
    {
        public string RegistrationNumber { get; set; }
        public int Power { get; set; }

        public Vehicle(string registrationNumber, int power)
        {
            RegistrationNumber = registrationNumber;
            Power = power;
        }

        public virtual void Move()
        {
            Console.WriteLine("The vehicle is moving.");
        }
    }
}
