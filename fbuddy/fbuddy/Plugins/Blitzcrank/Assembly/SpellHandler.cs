using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Spells;

namespace fbuddy.Plugins.Blitzcrank.Assembly
{
   public static class SpellHandler
    {
        public static Spell.Skillshot Q;
        public static Spell.Active W, E, R;

        public static void Load()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 900, SkillShotType.Linear, 250, 1800, 70);
            Q.AllowedCollisionCount = 0;
            W = new Spell.Active(SpellSlot.W, 600);
            E = new Spell.Active(SpellSlot.E, 250);
            R = new Spell.Active(SpellSlot.R, 550);
            
        }
    }
}
