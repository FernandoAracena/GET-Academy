using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class UpgradeCommand : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.Upgrade();
        }
    }
}
