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
        public int Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensivePower {get; set;}
        public IAttackBehavior attackBehavior {get; set;}
        public IDefendBehavior defendBehavior {get;set;}
        //Character newCharacter = new Character();
        public Character()
        {
            this.UserName = UserName;
            this.CharacterName = CharacterName;
            this.MaxPower = MaxPower;
            this.Health = Health;
            this.AttackStrength = AttackStrength;
            this.DefensivePower = DefensivePower;
        }
        public string GetUserName()
        {
            string userName = MenuOptions.GetUserName();
            UserName = userName;
            return UserName;
        }
        public string GetCharacterName()
        {
            string characterName = " hi";
            UserName = characterName;
            return CharacterName;
        }
        public int GetMaxPower()
        {
            Random rand = new Random();
            MaxPower = rand.Next(1, 101);
            return MaxPower;
        }
        public int GetHealth() //should I return?
        {
            Health = 100;
            return Health;
        }
        public int GetStrength()
        {
            Random rand = new Random();
            AttackStrength = rand.Next(0, MaxPower);

            return AttackStrength;
        }
        public int GetDefensivePower()
        {
            Random rand = new Random();
            DefensivePower = rand.Next(0, MaxPower);

            return DefensivePower;
        }     
        public void GetStats()
        {
            System.Console.WriteLine($"{UserName}/{CharacterName} Stats \nHealth: {Health} \nMax Power: {MaxPower}\nAttack Strength: {AttackStrength}\nDefensive Power: {DefensivePower}");
        }  


    }
    
}