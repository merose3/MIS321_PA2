using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class BlackBeard : Character
    {
        public BlackBeard() : base() //base gets all the stuff for the character class contructor 
        {
            this.CharacterName = "BlackBeard";
            this.attackBehavior = new FearAttack();
        }
        
    }
}