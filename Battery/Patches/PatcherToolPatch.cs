using HarmonyLib;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(PatcherTool))]
    internal class PatcherToolPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyPatcherToolBatteryUsage(ref PatcherTool __instance)
        {
            if (ConfigSettings.EnablePatcherTool.Value)
            {
                __instance.itemProperties.batteryUsage = ConfigSettings.PatcherToolBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryPatcherTool.Value;
            }

        }
    }
}