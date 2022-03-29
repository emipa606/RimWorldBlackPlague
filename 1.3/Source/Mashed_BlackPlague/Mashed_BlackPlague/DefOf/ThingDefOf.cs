using System;
using Verse;
using RimWorld;

namespace Mashed_BlackPlague
{
	[DefOf]
	public static class ThingDefOf
	{

		static ThingDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThoughtDefOf));
		}

		public static ThingDef BlackPlague_TuurngaitRace;
		public static ThingDef BlackPlague_Vessel;
	}
}
