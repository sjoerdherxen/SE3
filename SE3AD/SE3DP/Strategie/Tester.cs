using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Strategie
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Strategy:");
            var p = new Player();
            Console.Write("player without powerup:\t\t");
            p.Jump();
            Console.Write("player with powerup: \t\t");
            p.PowerUp = true;
            p.Jump();

            Console.Write("enemy jump: \t\t\t");
            var e = new Enemy();
            e.Jump();
            Console.WriteLine("End Strategy");
        }
    }
}
