using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Strategies;

namespace RPGCombatSimulator.Factories
{
    public class WarriorFactory : CharacterFactory
    {
        public override Character CreateCharacter(string name)
        {
            return new Character(name, 150, 20, new MeleeAttackStrategy());
        }
    }
}
