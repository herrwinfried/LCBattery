using HarmonyLib;
using LethalThings.MonoBehaviours;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(HackingTool))]
    public class HackingToolPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyHandheldRadarBatteryUsage(ref HackingTool __instance)
        { 
            if (ConfigSettings.EnableHackingTool.Value)
            {
                __instance.itemProperties.batteryUsage = ConfigSettings.HackingToolBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryHackingTool.Value;
                __instance.Update();
            }

        }
    }
}