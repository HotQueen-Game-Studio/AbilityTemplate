using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace HotQueen.Combat
{
    public class Damageble_Base : MonoBehaviour
    {
        public UnityEvent<CombatArgs> damaged;
        public void Damage(CombatArgs args)
        {

        }
    }
}