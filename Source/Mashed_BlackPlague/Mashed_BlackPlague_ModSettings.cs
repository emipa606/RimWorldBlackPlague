using Verse;

namespace Mashed_BlackPlague;

internal class Mashed_BlackPlague_ModSettings : ModSettings
{
    private static Mashed_BlackPlague_ModSettings _instance;
    public float BlackPlague_Chance_InfectedTouch = 0.1f;

    public bool BlackPlague_Enable_VesselMentalBreak = true;

    public Mashed_BlackPlague_ModSettings()
    {
        _instance = this;
    }

    public static bool Enable_VesselMentalBreak => _instance.BlackPlague_Enable_VesselMentalBreak;

    public static float Chance_InfectedTouch => _instance.BlackPlague_Chance_InfectedTouch;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref BlackPlague_Enable_VesselMentalBreak, "BlackPlague_Enable_VesselMentalBreak", true);
        Scribe_Values.Look(ref BlackPlague_Chance_InfectedTouch, "BlackPlague_Chance_InfectedTouch", 0.1f);
    }
}