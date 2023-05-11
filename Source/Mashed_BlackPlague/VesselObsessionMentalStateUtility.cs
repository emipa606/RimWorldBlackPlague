using Verse;
using Verse.AI;

namespace Mashed_BlackPlague;

public static class VesselObsessionMentalStateUtility
{
    public static Thing GetClosestVessel(Pawn pawn)
    {
        if (!pawn.Spawned)
        {
            return null;
        }

        var vessel = GenClosest.ClosestThingReachable(pawn.Position, pawn.Map,
            ThingRequest.ForDef(ThingDefOf.BlackPlague_Vessel), PathEndMode.ClosestTouch, TraverseParms.For(pawn),
            9999f, x => x.TryGetComp<CompUseEffect_TouchVessel>().cooldownTicks == 0);
        return vessel;
    }

    public static bool IsVesselValid(Thing vessel, Pawn pawn, bool ignoreReachability = false)
    {
        return vessel is { Spawned: true } && pawn.CanReserve(vessel) &&
               vessel.TryGetComp<CompUseEffect_TouchVessel>().cooldownTicks == 0 && (ignoreReachability ||
                   pawn.CanReach(vessel, PathEndMode.InteractionCell, Danger.Deadly));
    }
}