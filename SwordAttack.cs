using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS321_PA2.Interfaces;

namespace MIS321_PA2
{
    public class SwordAttack : IAttackBehavior
    {
        public void Attack()
        {
            System.Console.WriteLine("Slashhhh *I am sword fighting you*");
        }
    }
}