﻿// AreaUnlocker/SpecialInjector_AreaUnlocker.cs
// 
// Copyright Karel Kroeze, 2015.
// 
// Created 2015-11-25 10:55

using System;
using HugsLib.Source.Detour;
using RimWorld;
using Verse;

namespace AreaUnlocker
{
    public static class AreaUnlocker
    {
        // smallest mod ever
        [DetourMethod(typeof(AreaManager), "CanMakeNewAllowed" )]
        public static bool CanMakeNewAllowed( this AreaManager _this, AllowedAreaMode mode ) { return true; }
    }
}