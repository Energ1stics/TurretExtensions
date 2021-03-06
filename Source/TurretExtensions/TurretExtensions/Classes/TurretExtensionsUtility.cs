﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;

namespace TurretExtensions
{
    static class TurretExtensionsUtility
    {

        public static bool IsUpgradableTurret(this ThingDef def, out CompProperties_Upgradable uCP)
        {
            uCP = def.GetCompProperties<CompProperties_Upgradable>();
            return uCP != null;
        }

        public static bool IsUpgradableTurret(this Thing thing, out CompUpgradable uC)
        {
            uC = thing.TryGetComp<CompUpgradable>();
            return uC != null;
        }

        public static bool IsUpgradedTurret(this Thing thing, out CompUpgradable uC)
        {
            bool isUpgradableTurret = thing.IsUpgradableTurret(out uC);
            return isUpgradableTurret && uC.upgraded;
        }

    }
}
