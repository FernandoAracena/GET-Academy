using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    class ClickerGame
    {
        private int points;
        private int pointsPerClick;
        private int pointsPerClickIncrease;

        public ClickerGame()
        {
            points = 0;
            pointsPerClick = 1;
            pointsPerClickIncrease = 1;
        }

        public void Click()
        {
            points += pointsPerClick;
        }

        public void Upgrade()
        {
            if (points >= 10)
            {
                points -= 10;
                pointsPerClick += pointsPerClickIncrease;
            }
        }

        public void SuperUpgrade()
        {
            if (points >= 100)
            {
                points -= 100;
                pointsPerClickIncrease++;
            }
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n" +
                              "- SPACE = klikk (og få poeng)\r\n" +
                              "- K = kjøp oppgradering \r\n" +
                              "   øker poeng per klikk koster 10 poeng\r\n" +
                              "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                              "- X = avslutt applikasjonen");
            Console.WriteLine($"Du har {points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
        }
    }

}
