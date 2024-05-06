using HarmonyLib;

namespace Battery.Patches
{
    [HarmonyPatch(typeof(FlashlightItem))]
    internal class FlashlightItemPatch
    {
        [HarmonyPatch("ItemActivate")]
        [HarmonyPrefix]
        private static void ModifyFlashlightBatteryUsage(ref FlashlightItem __instance)
        {
            var type = (FlashlightType)__instance.flashlightTypeID;
            switch (type)
            {
                case FlashlightType.ProFlashlight:
                    if (ConfigSettings.EnableProFlashLight.Value)
                    {
                        __instance.itemProperties.batteryUsage = ConfigSettings.ProFlashlightBatteryUsage.Value;
                        __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryProFlashLight.Value;
                    }
                    break;
                case FlashlightType.Flashlight:
                    if (ConfigSettings.EnableFlashLight.Value)
                    {
                        __instance.itemProperties.batteryUsage = ConfigSettings.FlashlightBatteryUsage.Value;
                        __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryFlashLight.Value;
                    }
                    break;
                case FlashlightType.LaserPointer:
                    if (ConfigSettings.EnableLaserPointer.Value)
                    {
                        __instance.itemProperties.batteryUsage = ConfigSettings.LaserPointerBatteryUsage.Value;
                        __instance.itemProperties.requiresBattery = ConfigSettings.requiresBatteryLaserPointer.Value;
                    }
                    break;
                default:
                    Plugin.Log($"Unknown FlashlightType: {type}");
                    break;
            }
        }
    }
}