using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotQueen.Hability
{
    [System.Serializable]
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

        public Attribute Sum(Attribute attribute)
        {
            Attribute sum = new Attribute(0, 0, 0);
            sum.health = this.health + attribute.health;
            sum.stamina = this.stamina + attribute.stamina;
            sum.ki = this.ki + attribute.ki;
            return sum;
        }
    }
}
