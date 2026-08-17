using System.Reflection;
using EFT;
using SPT.Reflection.Patching;

namespace BlackDiv.Patches;

internal class BDNvgPatch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        // method_1 renamed to ManualUpdate in SPT 4.1.2
        return typeof(BotNightVisionData).GetMethod(nameof(BotNightVisionData.ManualUpdate), BindingFlags.Public | BindingFlags.Instance);
    }

    [PatchPrefix]
    protected static bool PatchPrefix(BotNightVisionData __instance)
    {
        // BotOwner_0 field removed in SPT 4.1.2 — cannot check bot role here.
        // TODO: re-implement via BotOwner-level patch to get WildSpawnType.
        // For now: run original for all bots (NVG suppression for BlackDiv temporarily disabled).
        return false;
    }
}
