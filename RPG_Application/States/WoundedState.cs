using System;
using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States
{
    public class WoundedState : CharacterState
    {
        public WoundedState(Character character) : base(character) { }

        public override void TakeDamage(int damage)
        {
            _character.Health = Math.Max(0, _character.Health - damage);

            if (_character.Health <= 0)
                _character.SetState(new DeadState(_character));
            else if (_character.Health < _character.MaxHealth * 0.25)
                _character.SetState(new CriticalState(_character));
        }

        public override double GetAttackModifier() => 0.8;

        public override bool CanAttack() => true;

        public override string GetStateDescription() => "Wounded";
    }
}
