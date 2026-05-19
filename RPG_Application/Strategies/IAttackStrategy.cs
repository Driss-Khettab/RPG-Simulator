using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.Strategies
{
    public interface IAttackStrategy
    {
        int CalculateDamage(int baseDamage);
        string GetAttackDescription();
    }
}
