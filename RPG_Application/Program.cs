using RPGCombatSimulator.Factories;

namespace RPGCombatSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RPG Combat Simulator ===\n");

            var mageFactory = new MageFactory();
            var rogueFactory = new RogueFactory();

            var mage = mageFactory.CreateCharacter("Mage");
            var rogue = rogueFactory.CreateCharacter("Rogue");

            Console.WriteLine("Combattants :");
            Console.WriteLine($"  {mage.GetStatus()}");
            Console.WriteLine($"  {rogue.GetStatus()}");
            Console.WriteLine();

            int round = 1;
            while (mage.IsAlive() && rogue.IsAlive())
            {
                Console.WriteLine($"=== Tour {round} ===");
                mage.Attack(rogue);
                if (rogue.IsAlive())
                    rogue.Attack(mage);
                Console.WriteLine();
                round++;
            }

            Console.WriteLine("=== Combat Finished ===");
            if (mage.IsAlive())
                Console.WriteLine($"Victoire de {mage.Name} !");
            else
                Console.WriteLine($"Victoire de {rogue.Name} !");
        }
    }
}
