using RimWorld;
using Verse;

namespace Mashed_BlackPlague;

[DefOf]
public static class PawnKindDefOf
{
    public static PawnKindDef BlackPlague_TuurngaitKind;

    static PawnKindDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(PawnKindDefOf));
    }
}