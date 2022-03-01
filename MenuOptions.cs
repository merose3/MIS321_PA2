using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class MenuOptions
    {
        public static int Player1Option()
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's maelstorm Game! Get ready to fight to the death for your chance to win (pride as the prize).");
            System.Console.WriteLine("Player 1, please select your character by selecting a number (1-4):\n1) Jack Sparrow \n2) Will Turner \n3) Davy Jones\n4) Exit the system");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }
        public static int Player1OptionWrong()
        {

            System.Console.WriteLine("INVALID RESPONSE \nPlease select your character by selecting a number (1-4):\n1) Jack Sparrow \n2) Will Turner \n3) Davy Jones\n4) Exit the system");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }
        public static int Player2Option()
        {
            System.Console.WriteLine("Player 2, please select your character by selecting a number (1-3):\n1) Jack Sparrow \n2) Will Turner \n3) Davy Jones \n4) Go back one menu option");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }
        public static string GetUserName()
        {
            System.Console.WriteLine("Please enter your name as the user");
            string userName = Console.ReadLine();

            return userName;
        }
        public static void WhoGoesFirstStatment()
        {
            System.Console.WriteLine($"We will now see who will go first by rolling a dice. If the dice rolls a 1, player 1 will go first & if the dice rolls a 2, player 2 will go first. ");
        }
    }
}