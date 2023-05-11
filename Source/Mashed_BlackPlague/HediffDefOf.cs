using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

[DefOf]
public static class HediffDefOf
{
    public static HediffDef BlackPlague_TuurngaitVirus;

    static HediffDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
    }
}