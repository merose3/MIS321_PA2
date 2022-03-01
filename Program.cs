using System;
using System.IO;

namespace MIS321_PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Character player1 = new Character();
            Character player2 = new Character();
            int userChoice = MenuOptions.Player1Option();
                while(userChoice != 4) //player 1 picking their character 
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
                        }
                    // MenuOptions.Player1OptionWrong();
                    userChoice = MenuOptions.Player1Option();
                }
                System.Console.WriteLine("You will now exit the system");
                userChoice = 5;
        }
        static Character GetCharacterName(int userChoice, Character player1)
        {
            string playerName = player1.GetUserName();
            Console.Clear();

            if(userChoice == 1)
            {
                player1.CharacterName = "Jack Sparrow";
                player1.attackBehavior = new DistrackAttack();
                player1 = new JackSparrow(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
                // player1 = new JackSparrow(){UserName = playerName};
            }
            else if(userChoice == 2)
            {
                player1.CharacterName = "Will Turner";
                player1.attackBehavior = new SwordAttack();
                player1 = new WillTurner(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
            }
            else if(userChoice == 3)
            {
                player1.CharacterName = "Davy Jones";
                player1.attackBehavior = new CannonAttack();
                player1 = new DavyJones(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player1.CharacterName}");
            }
            return player1;
        }
        static void Player2Choice(Character player1, Character player2)
        {
            int userChoice = MenuOptions.Player2Option(); 
            
            while(userChoice != 4) //player 2 picking their character 
            {
                switch(userChoice)
                {
                    case 1: //Jack Sparrow
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        userChoice = 4;
                        break;
                    case 2: //Will Turner
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        userChoice = 4;
                        break;
                    case 3: //Davy Jones
                        GetCharacterName2(userChoice, player2);
                        GamePlay(player1, player2);
                        userChoice = 4;
                        break;
                    case 4: 
                        System.Console.WriteLine("You will go back one menu option");
                        break;
                }
                 userChoice = MenuOptions.Player2Option();
           }
        }
        static Character GetCharacterName2(int userChoice, Character player2) //do I need two of these?
        {
            string playerName = player2.GetUserName();
            Console.Clear();

            if(userChoice == 1)
            {
                player2.CharacterName = "Jack Sparrow";
                player2.attackBehavior = new DistrackAttack();
                player2 = new JackSparrow(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
            }
            else if(userChoice == 2)
            {
                player2.CharacterName = "Will Turner";
                player2.attackBehavior = new SwordAttack();
                player2 = new WillTurner(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
            }
            else if(userChoice == 3)
            {
                player2.CharacterName = "Davy Jones";
                player2.attackBehavior = new CannonAttack();
                player2 = new DavyJones(){UserName = playerName};
                System.Console.WriteLine($"{playerName} chose {player2.CharacterName}");
            }
            return player2;
        }
        static int WhoGoesFirst() //generating a number either 1 or 2
        {
            System.Threading.Thread.Sleep(1000); 
            MenuOptions.WhoGoesFirstStatment();
            System.Threading.Thread.Sleep(1000); 
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
        static void GamePlay(Character player1, Character player2) //game play if user 1 goes first
        {
            int whoFirst = WhoGoesFirst();

            player1.GetStats(); //just to check rn
            System.Console.WriteLine(" ");
            player2.GetStats(); //just to check rn
            
            while(player1.Health > 0 && player2.Health > 0) 
            {
                if(whoFirst == 1)
                {
                    System.Console.WriteLine($"{player1.UserName} attacks first");
                    player1.attackBehavior.Attack();
                    DamageDone(player2, player1);
                    player1.GetStats();
                    player2.GetStats();
                    System.Console.WriteLine("Please press enter once you are ready for the next round");
                    Console.ReadKey();

                    if(player2.Health > 0) //checks to see if the other players health is below to get out of the loop for a winner/loser
                    {
                        System.Console.WriteLine($"{player2.UserName} now attacks");
                        player2.attackBehavior.Attack();
                        DamageDone(player2, player1); //this will switch the players 
                        player1.GetStats();
                        player2.GetStats();
                        System.Console.WriteLine("Please press enter once you are ready for the next round");
                        Console.ReadKey();
                    }
                }
                else
                {
                    System.Console.WriteLine($"{player2.UserName} attacks first");
                    player2.attackBehavior.Attack();
                    DamageDone(player2, player1);
                    player1.GetStats();
                    player2.GetStats();
                    System.Console.WriteLine("Please press enter once you are ready for the next round");
                    Console.ReadKey();
                    if(player1.Health > 0)
                    {
                        System.Console.WriteLine($"{player1.UserName} now attacks");
                        player1.attackBehavior.Attack(); 
                        DamageDone(player1, player2); //still switching it for me 
                        player1.GetStats();
                        player2.GetStats();
                        System.Console.WriteLine("Please press enter once you are ready for the next round");
                        Console.ReadKey();
                    }
                }
            }
            if(player1.Health > 0) //this will see who is the winner
            {
                System.Console.WriteLine($"Congrats to {player1.UserName}, you won!");
            }
            else
            {
                System.Console.WriteLine($"Congrats to {player2.UserName}, you won!");
            }
            // MainMenu();
            
        }
        static void DamageDone(Character attacker, Character defender)
        {
            if(attacker.CharacterName == "Jack Sparrow" && defender.CharacterName == "Will Turner") //special case
            {
                if(attacker.AttackStrength < defender.DefensivePower)
                {
                    double damageDelt = 1;
                    defender.Health = (defender.Health -(damageDelt*(1.2)));
                }
                else
                {
                    double damageDelt = (attacker.AttackStrength - defender.DefensivePower)*(.2);
                    defender.Health = (defender.Health -(damageDelt*(1.2)));;
                }
            }
            if(attacker.CharacterName == "Will Turner" && defender.CharacterName == "Davy Jones") //special case
            {
                if(attacker.AttackStrength < defender.DefensivePower)
                {
                    double damageDelt = 1;
                    defender.Health = (defender.Health -(damageDelt*(1.2)));
                }
                else
                {
                    double damageDelt = (attacker.AttackStrength - defender.DefensivePower)*(.2);
                    defender.Health = (defender.Health -(damageDelt*(1.2)));;
                }
            }
            if(attacker.CharacterName == "Davy Jones" && defender.CharacterName == "Jack Sparrow") //special case
            {
                if(attacker.AttackStrength < defender.DefensivePower)
                {
                    double damageDelt = 1;
                    defender.Health = (defender.Health -(damageDelt*(1.2)));
                }
                else
                {
                    double damageDelt = (attacker.AttackStrength - defender.DefensivePower)*(.2);
                    defender.Health = (defender.Health -(damageDelt*(1.2)));
                }
            }
            else //the regular stuff
            {
                if(attacker.AttackStrength < defender.DefensivePower)
                {
                    double damageDelt = 1;
                    defender.Health = (defender.Health -(damageDelt));
                }
                else
                {
                    double damageDelt = (attacker.AttackStrength - defender.DefensivePower);
                    defender.Health = (defender.Health -(damageDelt));
                }
            }
        }
        //make a file class
        //create a save to file method 
        //create a list in your menu class
        //pass in winner name 
        //pass list into winner name 
        //create a count 
        //empty out scoreboard 


    }
}
