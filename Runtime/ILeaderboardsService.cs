
namespace Loju.Services
{

    public enum LeaderboardLoadType
    {
        Global,
        GlobalAroundUser,
        Friends
    }

    public interface ILeaderboardsService
    {

        bool IsLeaderboardsServiceLoaded { get; }

        void ShowLeaderboardWithID(string leaderboardID, bool allTime);
        void ReportScore(string leaderboardID, long score, System.Action<bool> onComplete);
        void LoadScores(string leaderboardID, System.Action<LeaderboardVO> onComplete, int startRange = 0, int endRange = 10, LeaderboardLoadType type = LeaderboardLoadType.Global);

    }
}

