using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS321_PA2.Interfaces;

namespace MIS321_PA2
{
    public class FearAttack : IAttackBehavior
    { 
        public void Attack()
        {
            Console. ForegroundColor = ConsoleColor. Red; //changes the color. So fun! 
            System.Console.WriteLine("BOO! *I am making you really really scared aka fear*\n");
            Console. ForegroundColor = ConsoleColor. White; //changing it back
        }
    }
}