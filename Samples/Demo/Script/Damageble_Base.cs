using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using HotQueen.Combat;

public class Damageble_Base : MonoBehaviour, IDamageble
{
    public event Action<CombatArgs> OnDamaged;

    public void Damage(CombatArgs args)
    {
        Debug.Log("Damage:" + args.Attack.Damage.ToString());
        Debug.Log("Cost:" + args.Attack.Cost.ToString());
    }
}
