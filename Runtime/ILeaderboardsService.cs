
namespace Loju.Services
{
    public interface ILeaderboardsService
    {

        bool IsLeaderboardsServiceLoaded { get; }

        void ShowLeaderboardWithID(string leaderboardID, bool allTime);
        void ReportScore(string leaderboardID, long score, System.Action<bool> onComplete);
        void LoadScores(string leaderboardID, System.Action<LeaderboardVO> onComplete, int start = 0, int count = 10, bool friendsOnly = false);

    }
}

