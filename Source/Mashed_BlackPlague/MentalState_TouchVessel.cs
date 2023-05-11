using Verse;
using Verse.AI;

namespace Mashed_BlackPlague;

internal class MentalState_TouchVessel : MentalState
{
    private const int AnyVesselStillValidCheckInterval = 500;

    public bool alreadyTouchedVessel;

    public Thing vessel;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_References.Look(ref vessel, "vessel");
        Scribe_Values.Look(ref alreadyTouchedVessel, "alreadyTouchedVessel");
    }

    public override void MentalStateTick()
    {
        if (alreadyTouchedVessel)
        {
            base.MentalStateTick();
            return;
        }

        var noVessel = false;
        if (pawn.IsHashIntervalTick(AnyVesselStillValidCheckInterval) &&
            !VesselObsessionMentalStateUtility.IsVesselValid(vessel, pawn))
        {
            vessel = VesselObsessionMentalStateUtility.GetClosestVessel(pawn);
            if (vessel == null)
            {
                RecoverFromState();
                noVessel = true;
            }
        }

        if (!noVessel)
        {
            base.MentalStateTick();
        }
    }

    public override void PostStart(string reason)
    {
        base.PostStart(reason);
        vessel = VesselObsessionMentalStateUtility.GetClosestVessel(pawn);
    }

    public void Notify_VesselTouched()
    {
        alreadyTouchedVessel = true;
    }
}