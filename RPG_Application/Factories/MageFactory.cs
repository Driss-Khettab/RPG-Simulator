using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Strategies;

namespace RPGCombatSimulator.Factories
{
    public class MageFactory : CharacterFactory
    {
        public override Character CreateCharacter(string name)
        {
            return new Character(name, 80, 15, new MagicAttackStrategy());
        }
    }
}
