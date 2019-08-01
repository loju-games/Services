
namespace Loju.Services
{
    public interface IAchievementsService
    {

        bool IsAchievementsServiceLoaded { get; }
        bool HasAchievementBanner { get; }

        void ShowAchievementsUI();
        void ReportAchievement(string achievementID, float progress, System.Action<bool> onComplete);
        void LoadAchievements(System.Action<AchievementVO[]> onComplete);
        void ResetAchievements();

    }
}