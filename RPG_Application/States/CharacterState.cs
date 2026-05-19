using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States
{
    public abstract class CharacterState
    {
        protected Character _character;

        public CharacterState(Character character)
        {
            _character = character;
        }

        public abstract void TakeDamage(int damage);
        public abstract double GetAttackModifier();
        public abstract bool CanAttack();
        public abstract string GetStateDescription();
    }
}
