﻿using BepInEx;
using HarmonyLib;
using BepInEx.Logging;
using BepInEx.Configuration;
namespace Battery
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("evaisa.lethalthings", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony _harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        public static Plugin Instance;

        private void Awake()
        {
            Instance = this;
            _harmony.PatchAll();

            ConfigSettings.Init();

            Log($"Plugin {PluginInfo.PLUGIN_NAME}-{PluginInfo.PLUGIN_VERSION} loaded!");
        }

        public static void Log(string message) => Instance.Logger.LogInfo(message);
    }
}