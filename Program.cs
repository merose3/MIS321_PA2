using System;
using System.IO;

namespace MIS321_PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = MenuOptions.Player1Option();
            MainMenu(userChoice);
        }
        static void MainMenu(int userChoice)
        {
            while(userChoice != 4) //player 1 picking their character 
            {
                switch(userChoice)
                {
                    case 1: //Jack Sparrow
                        GetCharacterName(userChoice);
                        Player2Choice();
                        break;
                    case 2: //Will Turner
                        GetCharacterName(userChoice);
                        Player2Choice();
                        break;
                    case 3: //Davy Jones
                         GetCharacterName(userChoice);
                         Player2Choice();
                        break;
                }
                userChoice = MenuOptions.Player1Option();
            }
        }
        static void Player2Choice()
        {
            int userChoice = MenuOptions.Player2Option();
            while(userChoice != 4) //player 2 picking their character 
            {
                switch(userChoice)
                {
                    case 1: //Jack Sparrow
                        GetCharacterName(userChoice);
                        GamePlay();
                        break;
                    case 2: //Will Turner
                        GetCharacterName(userChoice);
                        GamePlay();
                        break;
                    case 3: //Davy Jones
                        GetCharacterName(userChoice);
                        GamePlay();
                        break;
                }
                userChoice = MenuOptions.Player2Option();
            }
            Player2Choice();
        }
         static void GetCharacterName(int userChoice)
        {
            Character setting = new Character();
            if(userChoice == 1)
            {
                string name = "Jack Sparrow";
                setting.CharacterName = name;
                System.Console.WriteLine(name);
            }
            else if(userChoice == 2)
            {
                string name = "Will Turner";
                setting.CharacterName = name;
                System.Console.WriteLine(name);
            }
            else if(userChoice == 3)
            {
                string name = "Davy Jones";
                setting.CharacterName = name;
                System.Console.WriteLine(name);
            }
            
        }
        static void WhoGoesFirst() //generating a number either 1 or 2
        {
            Random rand = new Random();
            int number = rand.Next(1,3);
            System.Console.WriteLine(number);
        }
        static void GamePlay()
        {

        }


    }
}
