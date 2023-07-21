using HotQueen.Combat.Hability;
using UnityEngine;
using Attribute = HotQueen.Combat.Attribute;

public class DebugHabilityRegistry : MonoBehaviour
{
    private AbilityRegistry habilityRegistry;
    private void Start()
    {
        habilityRegistry = new AbilityRegistry();
        InitRegistry();
    }

    private void InitRegistry()
    {
        AbilityData PunchAttack = new AbilityData(
                name: "Punch",
                iD_Name: "Attack_Punch",
                description: "Simple attack",
                cost: new Attribute(0, 1, 0),
                damage: new Attribute(1, 0, 0),
                function: () => { Debug.Log("HA!!"); }
            );

        habilityRegistry.RegisterHability(PunchAttack);
    }
}
