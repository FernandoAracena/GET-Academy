using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class ExitCommand : ICommand
    {
        public void Run(ClickerGame game)
        {
            Environment.Exit(0);
        }
    }
}
