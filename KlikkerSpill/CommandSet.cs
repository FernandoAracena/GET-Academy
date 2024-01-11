using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    class CommandSet
    {
        private ICommand[] commands;

        public CommandSet()
        {
            commands = new ICommand[]
            {
            new ClickCommand(),
            new UpgradeCommand(),
            new SuperUpgradeCommand(),
            new ExitCommand()
            };
        }

        public void RunCommand(char commandKey, ClickerGame game)
        {
            foreach (var command in commands)
            {
                if (GetCommandKey(command) == commandKey)
                {
                    command.Run(game);
                    break;
                }
            }
        }

        private char GetCommandKey(ICommand command)
        {
            switch (command)
            {
                case ClickCommand _: return ' ';
                case UpgradeCommand _: return 'K';
                case SuperUpgradeCommand _: return 'S';
                case ExitCommand _: return 'X';
                default: return '\0';
            }
        }
    }
}
