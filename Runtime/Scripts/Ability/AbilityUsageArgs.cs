using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HotQueen.Hability;

namespace HotQueen.Hability
{
    [System.Serializable]
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
