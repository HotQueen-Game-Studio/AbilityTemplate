using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HotQueen.Hability
{
    public interface IAbilityUser
    {
        public event Action<AbilityUsageArgs> OnUseAbility;
        public void UseHability(AbilityUsageArgs args);

    }
}