using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using MIS321_PA2.Interfaces;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class JackSparrow : Character
    {
        public IAttackBehavior distractBehavior {get; set;}
        Character jackSparrow = new Character();
        public void DistractAttack()
        {

        }
    }
}