using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    // Boat class inheriting from Vehicle
    class Boat : Vehicle
    {
        public int MaxSpeed { get; set; }
        public double GrossTonnage { get; set; }

        public Boat(string registrationNumber, int power, int maxSpeed, double grossTonnage)
            : base(registrationNumber, power)
        {
            MaxSpeed = maxSpeed;
            GrossTonnage = grossTonnage;
        }
    }
}
