using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

[DefOf]
public static class ThingDefOf
{
    public static ThingDef BlackPlague_TuurngaitRace;
    public static ThingDef BlackPlague_Vessel;

    static ThingDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
    }
    //public static ThingDef BlackPlague_FinisSpecialis;
}