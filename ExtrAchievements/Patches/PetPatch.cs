using AchievementsAPI.API;
using HarmonyLib;
using ExtrAchievements.Achievements;

namespace ExtrAchievements.Patches;
[HarmonyPatch]
public class PetPatch
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.TryPet))]
    [HarmonyPostfix]
    public static void TryPetPostfix(PlayerControl __instance)
    {
        if (__instance == PlayerControl.LocalPlayer)
        {
            var show1000ui = AchievementsTabSingleton<StatsAchievements>.Instance.Pet100.Unlocked;
            var show10000ui = AchievementsTabSingleton<StatsAchievements>.Instance.Pet1000.Unlocked;
            AchievementsTabSingleton<StatsAchievements>.Instance.Pet100.Increment(1);
            AchievementsTabSingleton<StatsAchievements>.Instance.Pet1000.Increment(1, show1000ui);
            AchievementsTabSingleton<StatsAchievements>.Instance.Pet10000.Increment(1, show10000ui);
        }
    }
}