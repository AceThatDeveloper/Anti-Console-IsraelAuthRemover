using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace AntiConsoleAntiIAuth
{
    [BepInPlugin("Ace.Console.Blocker.NoMoreConsole", "Anti Console Anti IAuth", "1.0.0")]
    public class Blocker : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony harmony = new Harmony("1X.AntiConsoleAntiIAuth");
            harmony.PatchAll();
            Debug.Log("[Anti Console Anti IAuth] Initialized");
        }
    }
}