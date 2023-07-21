using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace HotQueen.Combat
{
    public interface IDamageble
    {
        public event Action<CombatArgs> OnDamaged;
        public void Damage(CombatArgs args);
    }
}
