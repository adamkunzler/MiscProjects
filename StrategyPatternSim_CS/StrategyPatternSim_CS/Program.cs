namespace StrategyPatternSim_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern Simulation");

            Console.WriteLine("\nName your character:");
            var characterName = Console.ReadLine();
            var hero = new Character(characterName);

            Console.WriteLine("character created: " + characterName);

            AttackMenu(hero);

            hero.Attack();
        }

        private static void AttackMenu(Character character)
        {
            Console.WriteLine("Choose an attack strategy:");
            Console.WriteLine("1. Fisticuffs");
            Console.WriteLine("2. Sword Swing");
            Console.WriteLine("3. Fireball");
            Console.WriteLine("4. Heal");
            
            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    character.SetAttackStrategy(new Fisticuffs());
                    break;
                case "2":
                    character.SetAttackStrategy(new SwordSwing());
                    break;
                case "3":
                    character.SetAttackStrategy(new Fireball());
                    break;
                case "4":
                    character.SetAttackStrategy(new Heal());
                    break;
                default:
                    Console.WriteLine("Invalid choice, using default attack strategy.");
                    character.SetAttackStrategy(new Fisticuffs());
                    break;
            }
        }
    }
}
