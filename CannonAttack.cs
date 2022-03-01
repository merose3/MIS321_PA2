using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS321_PA2.Interfaces;

namespace MIS321_PA2
{
    public class CannonAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console. ForegroundColor = ConsoleColor. Red;
            System.Console.WriteLine("BOOOMMMM *I blew you up*\n");
            Console. ForegroundColor = ConsoleColor. White;
        }
    }
}