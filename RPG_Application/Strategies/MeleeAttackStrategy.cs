namespace RPGCombatSimulator.Strategies
{
    public class MeleeAttackStrategy : IAttackStrategy
    {
        public int CalculateDamage(int baseDamage) => (int)(baseDamage * 1.2);

        public string GetAttackDescription() => "performs a powerful melee strike";
    }
}
