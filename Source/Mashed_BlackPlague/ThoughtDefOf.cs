using RimWorld;

namespace Mashed_BlackPlague;

[DefOf]
public static class ThoughtDefOf
{
    public static ThoughtDef BlackPlague_TouchedVessel;
    public static ThoughtDef BlackPlague_TouchedVessel_Infected;
    public static ThoughtDef BlackPlague_TuurngaitConnectionLost;
    public static ThoughtDef BlackPlague_TuurngaitHivemindThought;

    static ThoughtDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThoughtDefOf));
    }
}