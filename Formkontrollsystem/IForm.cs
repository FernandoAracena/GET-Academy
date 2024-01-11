using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    public interface IForm
{
    string Navn { get; set; }
    string Farge { get; set; }
    double BeregnAreal();
}
}
