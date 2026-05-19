using RPGCombatSimulator.Factories;

namespace RPGCombatSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RPG Combat Simulator ===\n");

            var warriorFactory = new WarriorFactory();
            var mageFactory = new MageFactory();

            var warrior = warriorFactory.CreateCharacter("Joueur 1");
            var mage = mageFactory.CreateCharacter("Joueur 2");

            Console.WriteLine("Combattants :");
            Console.WriteLine($"  {warrior.GetStatus()}");
            Console.WriteLine($"  {mage.GetStatus()}");
            Console.WriteLine();

            int round = 1;
            while (warrior.IsAlive() && mage.IsAlive())
            {
                Console.WriteLine($"=== Tour {round} ===");
                warrior.Attack(mage);
                if (mage.IsAlive())
                    mage.Attack(warrior);
                Console.WriteLine();
                round++;
            }

            Console.WriteLine("=== Combat Finished ===");
            if (warrior.IsAlive())
                Console.WriteLine($"Victoire de {warrior.Name} !");
            else
                Console.WriteLine($"Victoire de {mage.Name} !");
        }
    }
}
