using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class MenuOptions
    {
        public static int MainMenuOption()
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's maelstorm Game! Get ready to fight to the death for your chance to win (pride as the prize).");
            System.Console.WriteLine("Please select your character by selecting a number (1-4):\n1) Jack Sparrow \n2) Will Turner \n3) Davy Jones\n4) Exit the system");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }
    }
}