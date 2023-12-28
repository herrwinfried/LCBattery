using HarmonyLib;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(WalkieTalkie))]
    internal class WalkieTalkieItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPostfix]
        private static void ModifyWalkieTalkieBatteryUsage(ref WalkieTalkie __instance)
        {
            if (ConfigSettings.EnableWalkieTalkie.Value)
            {
                __instance.itemProperties.batteryUsage = ConfigSettings.WalkieTalkieBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryWalkieTalkie.Value;
            }

        }
    }
}