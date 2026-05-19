namespace RPGCombatSimulator.Strategies
{
    public class MagicAttackStrategy : IAttackStrategy
    {
        public int CalculateDamage(int baseDamage) => (int)(baseDamage * 1.5);

        public string GetAttackDescription() => "casts a devastating spell";
    }
}
