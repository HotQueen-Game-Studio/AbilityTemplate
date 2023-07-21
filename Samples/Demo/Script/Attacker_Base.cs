using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Combat;


public class Attacker_Base : MonoBehaviour, IAttacker
{
    public event Action<CombatArgs> OnAttack;

    public void Attack(CombatArgs args)
    {
        OnAttack?.Invoke(args);
        args.Target.Damage(args);
        args.Attack.Execute();
    }
}

