using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Combat.Hability;

namespace HotQueen.Combat
{
    public struct AbilityUsageArgs
    {
        public IAbilityUser User;
        public IAffectable Affected;
        public AbilityData Ability;

        public AbilityUsageArgs(IAbilityUser user, IAffectable affect, AbilityData ability)
        {
            this.User = user;
            this.Affected = affect;
            this.Ability = ability;
        }
    }
}
