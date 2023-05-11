using RimWorld;

namespace Mashed_BlackPlague;

internal class Thought_Situational_TuurngaitInColony : Thought_Situational
{
    public override float MoodOffset()
    {
        return BaseMoodOffset * Utility.TuurngaitInFaction(pawn.Faction);
    }
}