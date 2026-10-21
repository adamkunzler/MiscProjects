using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSim_CS
{
    internal class Character
    {
        private string _name;
        private IAttackStrategy _attackStrategy;

        public Character(string name)
        {
            _name = name;
            _attackStrategy = new Fisticuffs(); // Default attack strategy
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            _attackStrategy.Attack();
        }   
    }
}
