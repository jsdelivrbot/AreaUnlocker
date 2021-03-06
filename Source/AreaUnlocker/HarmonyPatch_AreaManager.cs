﻿// HarmonyPatch_AreaManager.cs
// Copyright Karel Kroeze, 2018-2018

using Harmony;
using Verse;

namespace AreaUnlocker
{
    [HarmonyPatch(typeof(AreaManager))]
    [HarmonyPatch("CanMakeNewAllowed")]
    public static class AreaManager_CanMakeNewAllowed
    {
        static bool Prefix( ref bool __result )
        {
            __result = true;
            return false;
        }
    }
}