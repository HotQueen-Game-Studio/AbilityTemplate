using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Combat.Hability;

namespace HotQueen.Combat
{
    public struct CombatArgs
    {
        public IAttacker Attacker;
        public IDamageble Target;
        public HabilityData Attack;

        public CombatArgs(IAttacker attacker, IDamageble target, HabilityData attack)
        {
            this.Attacker = attacker;
            this.Target = target;
            this.Attack = attack;
        }
    }
}
