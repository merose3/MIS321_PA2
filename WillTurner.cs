using System;
using MIS321_PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class WillTurner : Character
    {
        public IAttackBehavior swordBehavior {get; set;}
        Character willTurner = new Character();
        public void SwordAttack()
        {
            
        }
    }
}