using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using HotQueen.Combat;

public class Damageble_Base : MonoBehaviour, IAffectable
{
    public event Action<AbilityUsageArgs> OnAffected;

    public void Affect(AbilityUsageArgs args)
    {
        Debug.Log("Damage:" + args.Ability.Effect.ToString());
        Debug.Log("Cost:" + args.Ability.Cost.ToString());
    }
}
