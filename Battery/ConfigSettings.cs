using BepInEx.Configuration;

namespace Battery
{
    public static class ConfigSettings
    {
        public static ConfigEntry<float> FlashlightBatteryUsage;
        public static ConfigEntry<float> ProFlashlightBatteryUsage;
        public static ConfigEntry<float> LaserPointerBatteryUsage;
        public static ConfigEntry<float> WalkieTalkieBatteryUsage;
        public static ConfigEntry<float> JetpackBatteryUsage;
        public static ConfigEntry<float> PatcherToolBatteryUsage;
        public static ConfigEntry<float> BoomboxItemBatteryUsage;
        public static ConfigEntry<float> HandheldRadarBatteryUsage;
        public static ConfigEntry<float> HackingToolBatteryUsage;

        public static ConfigEntry<bool> EnableFlashLight;
        public static ConfigEntry<bool> EnableProFlashLight;
        public static ConfigEntry<bool> EnableLaserPointer;
        public static ConfigEntry<bool> EnableWalkieTalkie;
        public static ConfigEntry<bool> EnableJetpack;
        public static ConfigEntry<bool> EnablePatcherTool;
        public static ConfigEntry<bool> EnableBoomboxItem;
        public static ConfigEntry<bool> EnableHandheldRadar;
        public static ConfigEntry<bool> EnableHackingTool;
       
        public static ConfigEntry<bool> requiresBatteryFlashLight;
        public static ConfigEntry<bool> requiresBatteryProFlashLight;
        public static ConfigEntry<bool> requiresBatteryLaserPointer;
        public static ConfigEntry<bool> requiresBatteryWalkieTalkie;
        public static ConfigEntry<bool> requiresBatteryJetpack;
        public static ConfigEntry<bool> requiresBatteryPatcherTool;
        public static ConfigEntry<bool> requiresBatteryBoomboxItem;
        public static ConfigEntry<bool> requiresBatteryHandheldRadar;
        public static ConfigEntry<bool> requiresBatteryHackingTool;
        public static void Init()
        {
            EnableFlashLight = Plugin.Instance.Config.Bind("Battery", "EnableFlashLight", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryFlashLight = Plugin.Instance.Config.Bind("Battery", "requiresBatteryFlashLight", true, "Is Battery Required? (True - yes | False - no)");
            FlashlightBatteryUsage = Plugin.Instance.Config.Bind("Battery", "FlashlightBatteryUsage", 150.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 140)");

            EnableProFlashLight = Plugin.Instance.Config.Bind("Battery", "EnableProFlashLight", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryProFlashLight = Plugin.Instance.Config.Bind("Battery", "requiresBatteryProFlashLight", true, "Is Battery Required? (True - yes | False - no)");
            ProFlashlightBatteryUsage = Plugin.Instance.Config.Bind("Battery", "ProFlashlightBatteryUsage", 350.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 300)");
            
            EnableLaserPointer = Plugin.Instance.Config.Bind("Battery", "EnableLaserPointer", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryLaserPointer = Plugin.Instance.Config.Bind("Battery", "requiresBatteryLaserPointer", true, "Is Battery Required? (True - yes | False - no)");
            LaserPointerBatteryUsage = Plugin.Instance.Config.Bind("Battery", "LaserPointerBatteryUsage", 350.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 300)");
            
            EnableWalkieTalkie = Plugin.Instance.Config.Bind("Battery", "EnableWalkieTalkie", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryWalkieTalkie = Plugin.Instance.Config.Bind("Battery", "requiresBatteryWalkieTalkie", true, "Is Battery Required? (True - yes | False - no)");
            WalkieTalkieBatteryUsage = Plugin.Instance.Config.Bind("Battery", "WalkieTalkieBatteryUsage", 1000.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 820)");
            
            EnableJetpack = Plugin.Instance.Config.Bind("Battery", "EnableJetpack", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryJetpack = Plugin.Instance.Config.Bind("Battery", "requiresBatteryJetpack", true, "Is Battery Required? (True - yes | False - no)");
            JetpackBatteryUsage = Plugin.Instance.Config.Bind("Battery", "JetpackBatteryUsage", 100.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 60)");
            
            EnablePatcherTool = Plugin.Instance.Config.Bind("Battery", "EnablePatcherTool", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryPatcherTool = Plugin.Instance.Config.Bind("Battery", "requiresBatteryPatcherTool", true, "Is Battery Required? (True - yes | False - no)");
            PatcherToolBatteryUsage = Plugin.Instance.Config.Bind("Battery", "PatcherToolBatteryUsage", 30.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 22)");
            
            EnableBoomboxItem = Plugin.Instance.Config.Bind("Battery", "EnableBoomboxItem", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryBoomboxItem = Plugin.Instance.Config.Bind("Battery", "requiresBatteryBoomboxItem", true, "Is Battery Required? (True - yes | False - no)");
            BoomboxItemBatteryUsage = Plugin.Instance.Config.Bind("Battery", "BoomboxItemBatteryUsage", 350.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: 350)");
           
            EnableHandheldRadar = Plugin.Instance.Config.Bind("Battery", "EnableHandheldRadar", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryHandheldRadar = Plugin.Instance.Config.Bind("Battery", "requiresBatteryHandheldRadar", true, "Is Battery Required? (True - yes | False - no)");
            HandheldRadarBatteryUsage = Plugin.Instance.Config.Bind("Battery", "HandheldRadarBatteryUsage", 1000.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: ...)");
           
            EnableHackingTool = Plugin.Instance.Config.Bind("Battery", "EnableHackingTool", true, "Should the Values of the Game prevail or yours? If you want Your value to be valid, set it to True.");
            requiresBatteryHackingTool = Plugin.Instance.Config.Bind("Battery", "requiresBatteryHackingTool", true, "Is Battery Required? (True - yes | False - no)");
            HackingToolBatteryUsage = Plugin.Instance.Config.Bind("Battery", "HackingToolBatteryUsage", 1000.0f, "The battery usage per update. The lower the value, the shorter the battery life. (Game Default: ...)");

        }
    }
}