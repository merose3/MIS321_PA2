using System;
using System.IO;

namespace MIS321_PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();
            Character player2 = new Character();
            MainMenu(player1, player2);
        }
        static void MainMenu(Character player1, Character player2)
        {
            int userChoice = MenuOptions.Player1Option();
                while(userChoice !=4) //player 1 picking their character 
                {
                    switch(userChoice)
                    {
                        case 1: //Jack Sparrow
                            GetCharacterName(userChoice, player1);
                            Player2Choice(player1, player2);
                            userChoice = 4;
                            break;
                        case 2: //Will Turner
                            GetCharacterName(userChoice, player1);
                            Player2Choice(player1, player2);
                            userChoice = 4;
                            break;
                        case 3: //Davy Jones
                            GetCharacterName(userChoice, player1);
                            Player2Choice(player1, player2);
                            userChoice = 4;
                            break;
                        default:
                            break;
                    }
                   userChoice = MenuOptions.Player1OptionWrong();
                }
                System.Console.WriteLine("You will now exit the system");
        }
        static Character GetCharacterName(int userChoice, Character player1)
        {
            string playerName = player1.GetUserName();
            Console.Clear();
            int maxPower = player1.GetMaxPower();
            int health = player1.GetHealth();
            int strength = player1.GetStrength();
            int maxDPower = player1.GetDefensivePower();

            if(userChoice == 1)
            {
                player1.CharacterName = "Jack Sparrow";
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
                player1 = new JackSparrow(){UserName = playerName, CharacterName = player1.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            else if(userChoice == 2)
            {
                player1.CharacterName = "Will Turner";
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
                player1 = new WillTurner(){UserName = playerName, CharacterName = player1.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            else if(userChoice == 3)
            {
                player1.CharacterName = "Davy Jones";
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
                player1 = new DavyJones(){UserName = playerName, CharacterName = player1.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            return player1;
        }
        static void Player2Choice(Character player1, Character player2)
        {
            int userChoice = MenuOptions.Player2Option(); //fix loops
            while(userChoice != 4) //player 2 picking their character 
            {
                switch(userChoice)
                {
                    case 1: //Jack Sparrow
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        break;
                    case 2: //Will Turner
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        break;
                    case 3: //Davy Jones
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        break;
                }
                userChoice = MenuOptions.Player2Option();
           }
        }
        static Character GetCharacterName2(int userChoice, Character player2) //do I need two of these?
        {
            string playerName = player2.GetUserName();
            Console.Clear();
            int maxPower = player2.GetMaxPower();
            int health = player2.GetHealth();
            int strength = player2.GetStrength();
            int maxDPower = player2.GetDefensivePower();

            if(userChoice == 1)
            {
                player2.CharacterName = "Jack Sparrow";
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
                player2 = new JackSparrow(){UserName = playerName, CharacterName = player2.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            else if(userChoice == 2)
            {
                player2.CharacterName = "Will Turner";
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
                player2 = new WillTurner(){UserName = playerName, CharacterName = player2.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            else if(userChoice == 3)
            {
                player2.CharacterName = "Davy Jones";
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
                player2 = new DavyJones(){UserName = playerName, CharacterName = player2.CharacterName, MaxPower = maxPower, Health = health, AttackStrength = strength, DefensivePower = maxDPower};
            }
            return player2;
        }
        static int WhoGoesFirst() //generating a number either 1 or 2
        {
            System.Threading.Thread.Sleep(4000); 
            MenuOptions.WhoGoesFirstStatment();
            System.Threading.Thread.Sleep(4000); 
            Random rand = new Random();
            int number = rand.Next(1,3);
            if(number == 1)
            {
                System.Console.WriteLine("Player 1 will go first!");
            }
            else if (number == 2)
            {
                System.Console.WriteLine("Player 2 will go first!");
            }
            return number;
        }
        static void GamePlay( Character player1, Character player2) //game play if user 1 goes first
        {
            int whoFirst = WhoGoesFirst();

            player1.GetStats();
            System.Console.WriteLine(" ");
            player2.GetStats();
            
            while(player1.Health > 0 && player2.Health > 0)
            {
                if(whoFirst == 1)
                {
                    System.Console.WriteLine($"{player1.UserName} attacks first");
                    whoFirst = 1;
                }
                else
                {
                    System.Console.WriteLine($"{player2.UserName} attacks first");
                    whoFirst = 2;
                }
            }
        }


    }
}
