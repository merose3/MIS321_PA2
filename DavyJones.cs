using System;
using System.Collections.Generic;
using System.Linq;
using MIS321_PA2.Interfaces;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class DavyJones : Character
    {
        public IAttackBehavior cannonFire {get; set;}
        Character davyJones = new Character();
        public void CannonAttack()
        {

        }
    }
}