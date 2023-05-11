using Verse;

namespace Mashed_BlackPlague;

internal class DeathActionWorker_Tuurngait : DeathActionWorker
{
    public override void PawnDied(Corpse corpse)
    {
        if (corpse?.InnerPawn == null || corpse.Map == null)
        {
            return;
        }

        var pawns = Utility.TuurngaitInFactionList(corpse.InnerPawn.Faction);
        foreach (var p in pawns)
        {
            p.needs.mood.thoughts.memories.TryGainMemory(ThoughtDefOf.BlackPlague_TuurngaitConnectionLost,
                corpse.InnerPawn);
        }
    }
}