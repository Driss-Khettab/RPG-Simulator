using System;
using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States
{
    public class HealthyState : CharacterState
    {
        public HealthyState(Character character) : base(character) { }

        public override void TakeDamage(int damage)
        {
            _character.Health = Math.Max(0, _character.Health - damage);

            if (_character.Health <= 0)
                _character.SetState(new DeadState(_character));
            else if (_character.Health < _character.MaxHealth * 0.25)
                _character.SetState(new CriticalState(_character));
            else if (_character.Health < _character.MaxHealth * 0.50)
                _character.SetState(new WoundedState(_character));
        }

        public override double GetAttackModifier() => 1.0;

        public override bool CanAttack() => true;

        public override string GetStateDescription() => "Healthy";
    }
}
