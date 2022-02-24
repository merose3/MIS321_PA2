using System;
using MIS321_PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class WillTurner : Character //this is where you do the bonuses
    {
        public void Attack()
        {
            System.Console.WriteLine("Slash! *I am sword fighting you*");
        }
        public double WillBonus()
        {
            double willBonus = ((MaxPower - DefensivePower) * (0.2));
            return willBonus;
        }
    }
}