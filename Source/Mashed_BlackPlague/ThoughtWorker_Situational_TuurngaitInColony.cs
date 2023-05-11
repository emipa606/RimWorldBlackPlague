using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

internal class ThoughtWorker_Situational_TuurngaitInColony : ThoughtWorker
{
    protected override ThoughtState CurrentStateInternal(Pawn p)
    {
        return p.Faction != null && Utility.PawnIsTuurngait(p);
    }
}