using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    class ClickCommand : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.Click();
        }
    }
}
