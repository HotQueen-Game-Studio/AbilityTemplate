using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Combat
{
    public struct Skills
    {
        [Header("Skills")]
        public int strength;
        public int dexterity;
        public int inteligence;

        public Skills(int strength, int dexterity, int inteligence)
        {

            this.strength = strength;
            this.dexterity = dexterity;
            this.inteligence = inteligence;
        }

    }
}
