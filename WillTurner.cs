using System;
using MIS321_PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class WillTurner : Character 
    {
        public WillTurner() : base()
        {
            this.CharacterName = "WilL Turner";
            this.attackBehavior = new DistrackAttack();
        }
       
    }
}