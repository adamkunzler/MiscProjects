namespace StrategyPatternSim_CS
{
    internal interface IAttackStrategy
    {
        void Attack();
    }

    internal class Fisticuffs : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Punching!");
        }
    }

    internal class  SwordSwing : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Swinging sword!");
        }
    }

    internal class Fireball : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Casting fireball!");
        }
    }

    internal class Heal : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Healing!");
        }
    }
}
