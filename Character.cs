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
            return userName;
        }
        public int GetMaxPower()
        {
            Random rand = new Random();
            int maxPower = rand.Next(1, 101);
            return maxPower;
        }
        public int GetHealth() //should I return?
        {
            int health = 100;
            return health;
        }
        public void GetStrength(int maxPower)
        {
            Random rand = new Random();
            int maxStrength = rand.Next(0, maxPower);
        }
        public void GetDefensivePower(int maxPower)
        {
            Random rand = new Random();
            int maxDPower = rand.Next(0, maxPower);
        }

    }
    
}