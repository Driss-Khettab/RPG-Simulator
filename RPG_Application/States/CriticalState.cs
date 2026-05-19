using System;
using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States
{
    public class CriticalState : CharacterState
    {
        public CriticalState(Character character) : base(character) { }

        public override void TakeDamage(int damage)
        {
            _character.Health = Math.Max(0, _character.Health - damage);

            if (_character.Health <= 0)
                _character.SetState(new DeadState(_character));
        }

        public override double GetAttackModifier() => 0.5;

        public override bool CanAttack() => true;

        public override string GetStateDescription() => "Critical";
    }
}
