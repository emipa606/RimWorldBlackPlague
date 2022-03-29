using System;
using Verse;
using RimWorld;

namespace Mashed_BlackPlague
{
    class CompProperties_UseEffectTouchVessel : CompProperties_UseEffectArtifact
    {
        public CompProperties_UseEffectTouchVessel()
        {
            this.compClass = typeof(CompUseEffect_TouchVessel);
        }

        public float infectChance = 0.1f;
        public int cooldownTicksDays = 60000;   //1 day
    }
}
