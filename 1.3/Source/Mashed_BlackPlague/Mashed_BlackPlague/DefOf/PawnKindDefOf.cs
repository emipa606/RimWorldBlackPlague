using System;
using Verse;
using RimWorld;

namespace Mashed_BlackPlague
{
	[DefOf]
	public static class PawnKindDefOf
	{

		static PawnKindDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThoughtDefOf));
		}

		public static PawnKindDef BlackPlague_TuurngaitRace;
	}
}
