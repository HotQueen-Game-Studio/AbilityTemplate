using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Combat;


public class Attacker_Base : MonoBehaviour, IAbilityUser
{
    public event Action<AbilityUsageArgs> OnUseAbility;

    public void UseHability(AbilityUsageArgs args)
    {
        OnUseAbility?.Invoke(args);
        args.Affected.Affect(args);
        args.Ability.Execute();
    }
}

