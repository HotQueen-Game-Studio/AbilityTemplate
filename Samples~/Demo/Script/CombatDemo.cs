using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Combat;
using HotQueen.Combat.Hability;

public class CombatDemo : MonoBehaviour
{
    [SerializeField] private Attacker_Base attacker;
    [SerializeField] private Damageble_Base damageble;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
            attacker.UseHability(new AbilityUsageArgs(attacker, damageble, AbilityRegistry.FindHability("Attack_Punch")));
        }
    }
}
