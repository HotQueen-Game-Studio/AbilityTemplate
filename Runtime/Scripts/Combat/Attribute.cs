using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Combat
{
    public struct Attribute
    {
        [Header("Attributes")]
        public int health;
        public int stamina;
        public int ki;

        public Attribute(int health, int stamina, int ki)
        {
            this.health = health;
            this.stamina = stamina;
            this.ki = ki;
        }
    }
}
