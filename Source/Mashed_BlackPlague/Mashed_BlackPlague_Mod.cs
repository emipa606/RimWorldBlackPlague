using System;
using Mlie;
using UnityEngine;
using Verse;

namespace Mashed_BlackPlague;

internal class Mashed_BlackPlague_Mod : Mod
{
    private static string currentVersion;
    private readonly Mashed_BlackPlague_ModSettings settings;

    public Mashed_BlackPlague_Mod(ModContentPack contentPack) : base(contentPack)
    {
        settings = GetSettings<Mashed_BlackPlague_ModSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(contentPack.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "BlackPlague_ModName".Translate();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(inRect);
        listing_Standard.Gap();

        listing_Standard.CheckboxLabeled("BlackPlague_Enable_VesselMentalBreak".Translate(),
            ref settings.BlackPlague_Enable_VesselMentalBreak);
        listing_Standard.Gap();

        listing_Standard.Label(
            $"{"BlackPlague_Chance_InfectedTouch".Translate() + " ("}{settings.BlackPlague_Chance_InfectedTouch * 100}%)");
        settings.BlackPlague_Chance_InfectedTouch =
            (float)Math.Round(listing_Standard.Slider(settings.BlackPlague_Chance_InfectedTouch, 0f, 1f) * 20) / 20;
        listing_Standard.Gap();

        listing_Standard.GapLine();
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("BlackPlague_CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
        base.DoSettingsWindowContents(inRect);
    }
}