using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS321_PA2.Interfaces;

namespace MIS321_PA2
{
    public class DistrackAttack : IAttackBehavior
    {
        public void Attack()
        {
            System.Console.WriteLine("Look at the bird over there! *I am distracting you*\n");
        }
    }
}