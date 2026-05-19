using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States
{
    public class DeadState : CharacterState
    {
        public DeadState(Character character) : base(character) { }

        public override void TakeDamage(int damage) { }

        public override double GetAttackModifier() => 0.0;

        public override bool CanAttack() => false;

        public override string GetStateDescription() => "Dead";
    }
}
