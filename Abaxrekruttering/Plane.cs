using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    // Plane class inheriting from Vehicle
    class Plane : Vehicle
    {
        public double Wingspan { get; set; }
        public double PayloadCapacity { get; set; }

        public Plane(string registrationNumber, int power, double wingspan, double payloadCapacity)
            : base(registrationNumber, power)
        {
            Wingspan = wingspan;
            PayloadCapacity = payloadCapacity;
        }

        public void Fly()
        {
            Console.WriteLine("The plane is flying.");
        }
    }
}
