using Verse;
using Verse.AI;

namespace Mashed_BlackPlague;

internal class MentalStateWorker_TouchVessel : MentalStateWorker
{
    public override bool StateCanOccur(Pawn pawn)
    {
        return base.StateCanOccur(pawn) && Mashed_BlackPlague_ModSettings.Enable_VesselMentalBreak &&
               VesselObsessionMentalStateUtility.GetClosestVessel(pawn) != null
               && !Utility.PawnHasVesselThought(pawn) && !Utility.PawnIsTuurngait(pawn) &&
               !Utility.PawnIsNotValid(pawn);
    }
}