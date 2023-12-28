using System.Runtime.CompilerServices;
using HarmonyLib;
using LethalThings.MonoBehaviours;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(HandheldRadar))]
    public class HandheldRadarPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyHandheldRadarBatteryUsage(ref HandheldRadar __instance)
        { 
            if (ConfigSettings.EnableHandheldRadar.Value)
            {
               // __instance.itemProperties.automaticallySetUsingPower = false;
                __instance.itemProperties.batteryUsage = ConfigSettings.HandheldRadarBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryHandheldRadar.Value;
                __instance.Update();
            }

        }
    }
}