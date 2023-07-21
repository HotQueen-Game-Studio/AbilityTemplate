using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HotQueen.Combat
{
    public interface IAttacker
    {
        public event Action<CombatArgs> OnAttack;
        public void Attack(CombatArgs args);

    }
}