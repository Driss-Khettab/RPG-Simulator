using System;

namespace RPGCombatSimulator.Strategies
{
    public class RangedAttackStrategy : IAttackStrategy
    {
        private static readonly Random _random = new Random();

        public int CalculateDamage(int baseDamage) => baseDamage + _random.Next(5, 16);

        public string GetAttackDescription() => "fires a precise ranged shot";
    }
}
