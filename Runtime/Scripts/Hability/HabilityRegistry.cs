using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Hability
{
    public static class HabilityRegistry<T> where T : struct
    {
        private static List<HabilityData<T>> List_habilityData = new List<HabilityData<T>>();

        public static void RegisterHability(HabilityData<T> habilityData)
        {
            if (List_habilityData.Contains(habilityData))
            {
                return;
            }
            List_habilityData.Add(habilityData);
        }
        public static void UnregisterHability(HabilityData<T> habilityData)
        {
            if (List_habilityData.Contains(habilityData))
            {
                List_habilityData.Remove(habilityData);
            }
        }
        public static HabilityData<T> FindHability(string id)
        {
            HabilityData<T> habilityData = List_habilityData.Find(h => h.ID_Name == id);
            return habilityData;
        }
    }
}
