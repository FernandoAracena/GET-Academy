using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    // Del 2: Baseklasse for formene (Base class for shapes)

    public abstract class BaseForm : IForm
    {
        public string Navn { get; set; }
        public string Farge { get; set; }
        public abstract double BeregnAreal();
    }
}
