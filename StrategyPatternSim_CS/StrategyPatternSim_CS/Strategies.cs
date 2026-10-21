using StrategyPatternSim_CS;

namespace StrategyPatternSim_CS
{
    internal abstract class IAttackStrategy
    {
        private int _damage;

        protected IAttackStrategy(int damage)
        {
            _damage = damage;
        }

        public abstract void Attack();
    }    

    internal class Fisticuffs : IAttackStrategy
    {
        public Fisticuffs() : base(10)
        {        
        }

        public override void Attack()
        {
            Console.WriteLine("Punching!");
        }        
    }

    internal class  SwordSwing : IAttackStrategy
    {
        public SwordSwing() : base(20)
        {
        }       

        public override void Attack()
        {
            Console.WriteLine("Swinging sword!");
        }
    }

    internal class Fireball : IAttackStrategy
    {        
        public Fireball() : base(30)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Casting fireball!");
        }
    }

    internal class Heal : IAttackStrategy
    {
        public Heal() : base(-20)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Healing!");
        }
    }
}
