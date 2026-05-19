using RPGCombatSimulator.States;
using RPGCombatSimulator.Strategies;

namespace RPGCombatSimulator.Characters
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int BaseDamage { get; set; }

        private IAttackStrategy _attackStrategy;
        private CharacterState _state;
    
        public Character(string name, int maxHealth, int baseDamage, IAttackStrategy attackStrategy)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            BaseDamage = baseDamage;
            _attackStrategy = attackStrategy;
            _state = new HealthyState(this);
        }

        public void SetState(CharacterState newState)
        {
            _state = newState;
        }

        public void Attack(Character target)
        {
            if (!_state.CanAttack())
            {
                Console.WriteLine($"{Name} cannot attack (state: {_state.GetStateDescription()})");
                return;
            }

            int damage = (int)(_attackStrategy.CalculateDamage(BaseDamage) * _state.GetAttackModifier());
            Console.WriteLine($"{Name} {_attackStrategy.GetAttackDescription()} dealing {damage} damage!");
            target.TakeDamage(damage);
        }

        public void TakeDamage(int damage)
        {
            _state.TakeDamage(damage);
            Console.WriteLine($"{Name} takes {damage} damage. Health: {Health}/{MaxHealth} ({_state.GetStateDescription()})");
        }

        public bool IsAlive() => _state.CanAttack();

        public string GetStatus()
        {
            return $"{Name} - HP: {Health}/{MaxHealth} - State: {_state.GetStateDescription()}";
        }
    }
}
