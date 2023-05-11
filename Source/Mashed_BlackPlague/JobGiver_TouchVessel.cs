using RimWorld;
using Verse;
using Verse.AI;

namespace Mashed_BlackPlague;

internal class JobGiver_TouchVessel : ThinkNode_JobGiver
{
    protected override Job TryGiveJob(Pawn pawn)
    {
        if (pawn.MentalState is not MentalState_TouchVessel mentalState_TouchVessel ||
            mentalState_TouchVessel.vessel == null || mentalState_TouchVessel.alreadyTouchedVessel)
        {
            return null;
        }

        var vessel = mentalState_TouchVessel.vessel;

        if (!pawn.CanReserveAndReach(vessel, PathEndMode.Touch, Danger.Deadly))
        {
            return null;
        }

        var job = JobMaker.MakeJob(JobDefOf.UseArtifact, vessel);
        job.count = 1;
        return job;
    }
}