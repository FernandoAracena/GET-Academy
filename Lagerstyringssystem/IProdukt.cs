using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    // Del 1: Interface
    public interface IProdukt
    {
        string Navn { get; set; }
        double Pris { get; set; }

        void SkrivUtInfo();
    }
}
