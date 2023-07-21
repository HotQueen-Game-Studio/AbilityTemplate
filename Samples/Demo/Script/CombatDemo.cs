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
            HabilityData dataA = new HabilityData(
                name: "PunchAttack",
                iD_Name: "Attack_PunchAttack",
                description: "Simple attack",
                cost: new Attribute(0, 1, 0),
                damage: new Attribute(1, 0, 0),
                function: () => { Debug.Log("HA!!"); }
            );
            attacker.Attack(new CombatArgs(attacker, damageble, dataA));
        }
    }
}
