using System.Reflection;
using AchievementsAPI;
using UnityEngine;

namespace ExtrAchievements;

public class Assets
{
    public static Sprite statsIcon { get; set; } =
        SpriteTools.LoadSpriteFromPath("ExtrAchievements.Resources.stats.png", Assembly.GetCallingAssembly(),
            100);
}