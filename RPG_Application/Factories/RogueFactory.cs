using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Strategies;

namespace RPGCombatSimulator.Factories
{
    public class RogueFactory : CharacterFactory
    {
        public override Character CreateCharacter(string name)
        {
            return new Character(name, 100, 12, new RangedAttackStrategy());
        }
    }
}
