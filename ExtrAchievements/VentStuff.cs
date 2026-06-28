using System;
using AchievementsAPI.API;
using ExtrAchievements.Achievements;
using Reactor.Utilities.Attributes;
using UnityEngine;

namespace ExtrAchievements;

[RegisterInIl2Cpp]
public class VentStuff(IntPtr ptr) : MonoBehaviour(ptr)
{
    public static bool LastFrameInVent { get; set; } = false;
    public void Update()
    {
        if (LastFrameInVent && !PlayerControl.LocalPlayer.inVent)
        {
            LastFrameInVent = false;
        }

        if (!LastFrameInVent && PlayerControl.LocalPlayer.inVent)
        {
            LastFrameInVent = true;
            Vented();
        }
    }

    public static void Vented()
    {
        var show100UI = AchievementsTabSingleton<StatsAchievements>.Instance.Pet100.Unlocked;
        var show1000UI = AchievementsTabSingleton<StatsAchievements>.Instance.Pet1000.Unlocked;
        AchievementsTabSingleton<StatsAchievements>.Instance.Vent10.Increment(1);
        AchievementsTabSingleton<StatsAchievements>.Instance.Vent100.Increment(1, show100UI);
        AchievementsTabSingleton<StatsAchievements>.Instance.Vent1000.Increment(1, show1000UI);
    }
}