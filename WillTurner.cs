using System;
using MIS321_PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class WillTurner : Character //this is where you do the bonuses
    {
        public WillTurner() : base()
        {
            this.CharacterName = "WilL Turner";
            this.attackBehavior = new DistrackAttack();
        }
       
    }
}