using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal interface ICommand
    {
        void Run(ClickerGame game);

    }
}
