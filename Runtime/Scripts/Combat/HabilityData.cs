using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Attribute = HotQueen.Combat.Attribute;

namespace HotQueen.Combat.Hability
{
    public struct HabilityData
    {
        public string Name;
        public string ID_Name;
        public string Description;
        public Attribute Cost;
        public Attribute Damage;
        public event Action Function;

        public HabilityData(string name, string iD_Name, string description, Attribute cost, Attribute damage, Action function)
        {
            Name = name;
            ID_Name = iD_Name;
            Description = description;
            Cost = cost;
            Damage = damage;
            this.Function = function;
        }

        public void Execute()
        {
            Function?.Invoke();
        }
    }
}
