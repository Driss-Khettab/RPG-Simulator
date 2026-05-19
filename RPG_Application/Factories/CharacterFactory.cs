using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.Factories
{
    public abstract class CharacterFactory
    {
        public abstract Character CreateCharacter(string name);
    }
}
