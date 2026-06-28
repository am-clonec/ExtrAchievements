using AchievementsAPI.API;
using UnityEngine;

namespace ExtrAchievements.Achievements;

public class StatsAchievements : AchievementsTab
{
    public override string Name => "Statistic Achievements";
    public override Color GetTabColor()
    {
        return Color.yellow;
    }
    public override Sprite GetIcon()
    {
        return Assets.statsIcon;
    }

    public BaseAchievement LightsSabotageKill { get; } = new BaseAchievement("Where's he at??",
        "Kill someone in electrical while the lights are out.", "ExtrAchievements.Resources.stats.png");
    
    public CountAchievement Vent10 { get; } = new CountAchievement("VenTen",
        "Enter 10 vents (or one vent 10 times, whatever you want)", "ExtrAchievements.Resources.stats.png", 0, 10);
    public CountAchievement Vent100 { get; } = new CountAchievement("Lots of vents",
        "Enter 100 vents (or one vent 10 times, whatever you want)", "ExtrAchievements.Resources.stats.png", 0, 100, rarity:1);
    public CountAchievement Vent1000 { get; } = new CountAchievement("Ugh, even more vents",
        "Enter 1000 vents (or one vent 10 times, whatever you want)", "ExtrAchievements.Resources.stats.png", 0, 1000, rarity:2, hidden:true, hideProgress:true);
    public CountAchievement Pet100 { get; } = new CountAchievement("SuperPetter",
        "Pet your pet 100 times. Or try, at least.", "ExtrAchievements.Resources.stats.png", 0, 100);
    public CountAchievement Pet1000 { get; } = new CountAchievement("UltraPetter",
        "Pet your pet 100 times. At this point, how is it still alive?", "ExtrAchievements.Resources.stats.png", 0, 1000, rarity:1);
    public CountAchievement Pet10000 { get; } = new CountAchievement("HyperUltraMegaPetter",
        "Pet your pet 10000 times. Somehow. Get off the game. Please.", "ExtrAchievements.Resources.stats.png", 0, 10000, rarity:3, hidden:true, hideProgress:true);
}