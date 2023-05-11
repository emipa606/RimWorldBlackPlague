using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

internal class ThoughtWorker_TuurngaitOpinionThought : ThoughtWorker
{
    protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
    {
        if (pawn.def != ThingDefOf.BlackPlague_TuurngaitRace)
        {
            return other.def == ThingDefOf.BlackPlague_TuurngaitRace ? ThoughtState.ActiveAtStage(0) : false;
        }

        if (pawn.Faction == null || other.Faction == null || pawn.Faction != other.Faction)
        {
            return ThoughtState.ActiveAtStage(1);
        }

        if (other.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BlackPlague_TuurngaitVirus) != null)
        {
            return ThoughtState.ActiveAtStage(3);
        }

        if (other.def != ThingDefOf.BlackPlague_TuurngaitRace)
        {
            return ThoughtState.ActiveAtStage(1);
        }

        if (other.def == ThingDefOf.BlackPlague_TuurngaitRace)
        {
            return ThoughtState.ActiveAtStage(2);
        }

        return other.def == ThingDefOf.BlackPlague_TuurngaitRace ? ThoughtState.ActiveAtStage(0) : false;
    }
}