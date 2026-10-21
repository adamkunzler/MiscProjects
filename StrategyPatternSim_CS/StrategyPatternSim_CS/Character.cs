using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSim_CS
{
    internal class Character
    {        
        private string _name;

        private int _health;


        private IAttackStrategy _attackStrategy;

        public Character(string name)
        {
            _name = name;
            _health = 100;
            _attackStrategy = new Fisticuffs();
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            _attackStrategy.Attack();
        }   

        public void Battle(int damage)
        {
            _health -= damage;
        }

        public int GetHealth()
        {
            return _health;
        }
    }
}
