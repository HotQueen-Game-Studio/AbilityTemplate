using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace HotQueen.Combat
{
    public interface IAffectable
    {
        public event Action<AbilityUsageArgs> OnAffected;
        public void Affect(AbilityUsageArgs args);
    }
}
