using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class SuperUpgradeCommand : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.SuperUpgrade();
        }
    }
}
