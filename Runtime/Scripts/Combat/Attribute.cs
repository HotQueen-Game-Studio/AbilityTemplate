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

        [Header("Limit")]
        public int maxHealth;
        public int maxStamina;
        public int maxKi;

        public Attribute(int health, int stamina, int ki, int maxHealth, int maxStamina, int maxKi)
        {
            this.health = health;
            this.stamina = stamina;
            this.ki = ki;
            this.maxHealth = maxHealth;
            this.maxStamina = maxStamina;
            this.maxKi = maxKi;
        }
    }
}
