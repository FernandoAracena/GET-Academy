using System;
using System.Collections.Generic;
using KlikkerSpill;
class Program
{
    static void Main()
    {
        ClickerGame game = new ClickerGame();
        CommandSet commandSet = new CommandSet();

        while (true)
        {
            game.Display();
            var commandKey = Console.ReadKey().KeyChar;

            commandSet.RunCommand(commandKey, game);
        }
    }
}