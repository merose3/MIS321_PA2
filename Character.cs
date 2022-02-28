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
        public IDefendBehavior defendBehavior {get;set;}
        //Character newCharacter = new Character();
        public Character()
        {
            Random rand = new Random();
            Health = 100;
            MaxPower = rand.Next(1, 101);
            AttackStrength = rand.Next(0, MaxPower);
            DefensivePower = rand.Next(0, MaxPower);
        }
        // public void SetAttachBehavior(IAttackBehavior attackBehavior) //behavior is private so this will help call the pitch 
        // {
        //     this.attackBehavior = attackBehavior;
        // }
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
        public void GetStats()
        {
            System.Console.WriteLine($"{UserName}/{CharacterName} Stats \nHealth: {Health} \nMax Power: {MaxPower}\nAttack Strength: {AttackStrength}\nDefensive Power: {DefensivePower}\n");
        }  


    }
    
}