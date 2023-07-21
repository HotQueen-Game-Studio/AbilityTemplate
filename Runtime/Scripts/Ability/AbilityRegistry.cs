using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Hability
{
    public class AbilityRegistry
    {
        private static List<AbilityData> List_AbilityData = new List<AbilityData>();

        public void RegisterHability(AbilityData habilityData)
        {
            if (List_AbilityData.Contains(habilityData))
            {
                return;
            }
            List_AbilityData.Add(habilityData);
        }
        public void UnregisterHability(AbilityData habilityData)
        {
            if (List_AbilityData.Contains(habilityData))
            {
                List_AbilityData.Remove(habilityData);
            }
        }
        public static AbilityData FindHability(string id)
        {
            AbilityData habilityData = List_AbilityData.Find(h => h.ID_Name == id);
            return habilityData;
        }
    }
}
