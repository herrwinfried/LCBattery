using HarmonyLib;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(JetpackItem))]
    internal class JetpackItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyJetpackBatteryUsage(ref JetpackItem __instance)
        {
            if (ConfigSettings.EnableJetpack.Value)
            {
                __instance.itemProperties.batteryUsage = ConfigSettings.JetpackBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryJetpack.Value;
            }
            
        }
    }
}