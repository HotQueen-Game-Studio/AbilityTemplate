using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Combat.Hability
{
    public static class HabilityRegistry
    {
        private static List<HabilityData> List_habilityData = new List<HabilityData>();

        public static void RegisterHability(HabilityData habilityData)
        {
            if (List_habilityData.Contains(habilityData))
            {
                return;
            }
            List_habilityData.Add(habilityData);
        }
        public static void UnregisterHability(HabilityData habilityData)
        {
            if (List_habilityData.Contains(habilityData))
            {
                List_habilityData.Remove(habilityData);
            }
        }
        public static HabilityData FindHability(string id)
        {
            HabilityData habilityData = List_habilityData.Find(h => h.ID_Name == id);
            return habilityData;
        }
    }
}
