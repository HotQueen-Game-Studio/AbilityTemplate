using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Hability
{
    public class HabilityData<T> where T : struct
    {
        public string Name;
        public string ID_Name;
        public string Description;
        public T Cost;
        public event Action Function;

        public HabilityData(string name, string iD_Name, string description, T cost)
        {
            Name = name;
            ID_Name = iD_Name;
            Description = description;
            Cost = cost;
        }
    }
}
