using System;

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
                    case 1: //jack sparrow
                        
                        break;
                    case 2: //Will turner
                        
                        break;
                    case 3: //davy jones
                         
                        break;
                }
                userChoice = MenuOptions.Player1Option();
            }
            Player2Choice();
        }
        static void Player2Choice()
        {
            int userChoice = MenuOptions.Player2Option();
            while(userChoice != 4) //player 1 picking their character 
            {
                switch(userChoice)
                {
                    case 1: //jack sparrow
                        
                        break;
                    case 2: //Will turner
                        
                        break;
                    case 3: //davy jones
                        
                        break;
                }
                userChoice = MenuOptions.Player2Option();
            }
            Player2Choice();
        }
    }
}
