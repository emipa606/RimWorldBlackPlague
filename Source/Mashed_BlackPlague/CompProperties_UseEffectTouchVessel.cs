using RimWorld;

namespace Mashed_BlackPlague;

internal class CompProperties_UseEffectTouchVessel : CompProperties_UseEffectArtifact
{
    public int cooldownTicksDays = 60000; //1 day
    public RecordDef recordDef;

    public CompProperties_UseEffectTouchVessel()
    {
        compClass = typeof(CompUseEffect_TouchVessel);
    }
}