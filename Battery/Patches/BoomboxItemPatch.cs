﻿using HarmonyLib;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(BoomboxItem))]
    internal class BoomboxItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyBoomboxItemBatteryUsage(ref BoomboxItem __instance)
        {
            if (ConfigSettings.EnableBoomboxItem.Value)
            {
                __instance.itemProperties.batteryUsage = ConfigSettings.BoomboxItemBatteryUsage.Value;
                __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryBoomboxItem.Value;
            }
        }
    }
}