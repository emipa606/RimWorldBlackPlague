using RimWorld;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Verse;

namespace Mashed_BlackPlague
{
    class HediffComp_TuurngaitVirus : HediffComp
    {
        public override void CompPostTick(ref float severityAdjustment)
        {
            if (parent.Severity >= 0.9f)
            {
                MakeTheChange(parent.pawn);
            }

            base.CompPostTick(ref severityAdjustment);
        }

        public Pawn MakeTheChange(Pawn originalPawn)
        {
            originalPawn.DropAndForbidEverything();
            originalPawn.Strip();

            originalPawn.Kill(null);
            Pawn newPawn = PawnGenerator.GeneratePawn(PawnKindDefOf.BlackPlague_TuurngaitRace, Faction.OfPlayer);
            newPawn.Name = originalPawn.Name;
            newPawn.ageTracker.AgeBiologicalTicks = originalPawn.ageTracker.AgeBiologicalTicks;
            //newPawn.gender = originalPawn.gender;
            PawnUtility.TrySpawnHatchedOrBornPawn(newPawn, originalPawn.Corpse);
            originalPawn.Corpse.Destroy();

            return newPawn;
        }
    }
}
