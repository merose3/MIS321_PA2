using System;
using System.Collections.Generic;
using System.Linq;
using MIS321_PA2.Interfaces;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class DavyJones : Character //this is where you do the bonuses
    {
        public DavyJones() : base()
        {
            this.CharacterName = "Davy Jones";
            this.attackBehavior = new DistrackAttack();
        }
        
    }
}