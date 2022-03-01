using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS321_PA2.Interfaces;

namespace MIS321_PA2
{
    public class Character 
    {
        public string UserName {get; set;}
        public string CharacterName{get;set;}
        public int MaxPower {get; set;}
        public double Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensivePower {get; set;}
        public IAttackBehavior attackBehavior {get; set;}
        public IDefendBehavior defendBehavior {get;set;} //currently no functionality
        public Character()
        {
            Random rand = new Random(); //used for generating through all the parts of the constructor
            Health = 100; //given
            MaxPower = rand.Next(1, 101);
            AttackStrength = rand.Next(1, MaxPower); //strength can't be 0
            DefensivePower = rand.Next(1, MaxPower); //power can't be 0
        }
        public string GetUserName()
        {
            string userName = MenuOptions.GetUserName();
            UserName = userName;
            return UserName;
        }
        public void GetStats()
        {
            Console. ForegroundColor = ConsoleColor. Blue; //changes color to blue
            System.Console.WriteLine($"{UserName}/{CharacterName} Stats");
            Console. ForegroundColor = ConsoleColor. White; //changes back to white
            Console.WriteLine($"Health: {Health} \nMax Power: {MaxPower}\nAttack Strength: {AttackStrength}\nDefensive Power: {DefensivePower}\n");
        }  


    }
    
}