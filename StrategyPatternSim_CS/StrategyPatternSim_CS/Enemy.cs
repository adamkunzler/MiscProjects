using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSim_CS
{
    internal class Enemy
    {
        private int _damage;
        private int _health;

        public Enemy(int damage)
        {
            _damage = damage;
            _health = 100;
        }

        public int Attack()
        {
            return _damage;
        }

        public int GetHealth()
        {
            return _health;
        }   
    }
}
