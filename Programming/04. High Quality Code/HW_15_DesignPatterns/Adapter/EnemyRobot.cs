﻿namespace Adapter
{
    using System;

    // This is the adaptee.
    public class EnemyRobot
    {
        private Random generator = new Random();

        public void SmashWithHands()
        {
            int attackDamage = this.generator.Next(10) + 1;
            Console.WriteLine("Enemy Robot Causes {0} Damage With Its Hands", attackDamage);
        }

        public void WalkForward()
        {
            int movement = this.generator.Next(5) + 1;
            Console.WriteLine("Enemy Robot Walks Forward {0} spaces", movement);
        }

        public void ReactToHuman(String driverName)
        {
            Console.WriteLine("Enemy Robot Tramps on {0}", driverName);
        }
    }
}
