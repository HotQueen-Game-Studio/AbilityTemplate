using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Hability;

namespace HotQueen.Combat
{
    public struct CombatArgs
    {
        public IAttacker attacker;
        public IDamageble target;
        public HabilityData<Attribute> cost;
        public int damage;

        public CombatArgs(IAttacker attacker, IDamageble target, HabilityData<Attribute> cost, int damage)
        {
            this.attacker = attacker;
            this.target = target;
            this.cost = cost;
            this.damage = damage;
        }
    }
}
