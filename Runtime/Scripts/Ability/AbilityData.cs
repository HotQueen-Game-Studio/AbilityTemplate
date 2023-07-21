using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Attribute = HotQueen.Hability.Attribute;

namespace HotQueen.Hability
{
    public struct AbilityData
    {
        public string Name;
        public string ID_Name;
        public string Description;
        public Attribute Cost;
        public Attribute Effect;
        public event Action Function;

        public AbilityData(string name, string iD_Name, string description, Attribute cost, Attribute damage, Action function)
        {
            Name = name;
            ID_Name = iD_Name;
            Description = description;
            Cost = cost;
            Effect = damage;
            this.Function = function;
        }

        public void Execute()
        {
            Function?.Invoke();
        }
    }
}
