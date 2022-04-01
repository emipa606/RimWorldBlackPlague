using RimWorld;
using Verse;

namespace Mashed_BlackPlague
{
    class ThoughtWorker_TuurngaitOpinionThought : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
        {
            if (pawn.def == ThingDefOf.BlackPlague_TuurngaitRace)
            {
                if (other.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BlackPlague_TuurngaitVirus) != null)
                {
                    return ThoughtState.ActiveAtStage(3);
                }
                if(other.def != ThingDefOf.BlackPlague_TuurngaitRace)
                {
                    return ThoughtState.ActiveAtStage(1);
                }
                if (other.def == ThingDefOf.BlackPlague_TuurngaitRace)
                {
                    return ThoughtState.ActiveAtStage(2);
                }
            }

            if (other.def == ThingDefOf.BlackPlague_TuurngaitRace)
            {
                return ThoughtState.ActiveAtStage(0);
            }
            return false;
        }
    }
}
