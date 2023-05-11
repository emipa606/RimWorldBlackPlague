using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

internal class HediffComp_TuurngaitVirus : HediffComp
{
    public override void CompPostTick(ref float severityAdjustment)
    {
        if (parent.Severity >= 0.9f)
        {
            MakeTheChange(parent.pawn);
        }

        base.CompPostTick(ref severityAdjustment);
    }

    public void MakeTheChange(Pawn originalPawn)
    {
        originalPawn.DropAndForbidEverything();
        originalPawn.Strip();


        var newPawn = PawnGenerator.GeneratePawn(PawnKindDefOf.BlackPlague_TuurngaitKind, Faction.OfPlayer);
        newPawn.Name = originalPawn.Name;
        newPawn.story.traits = originalPawn.story.traits;
        newPawn.ageTracker.AgeBiologicalTicks = originalPawn.ageTracker.AgeBiologicalTicks;
        if (ModsConfig.IdeologyActive)
        {
            newPawn.ideo.SetIdeo(originalPawn.Ideo);
        }

        //newPawn.gender = originalPawn.gender;
        originalPawn.Kill(null);
        PawnUtility.TrySpawnHatchedOrBornPawn(newPawn, originalPawn.Corpse);
        originalPawn.Corpse.Destroy();
    }
}