using System.Collections.Generic;

namespace Loju.Services
{

    public enum LeaderboardType
    {
        Global,
        Friends
    }

    public class LeaderboardVO
    {

        public LeaderboardEntryVO playerScore { get; private set; }
        public bool HasPlayerEntry { get; private set; }
        public readonly int totalEntries;
        public readonly List<LeaderboardEntryVO> entries;
        public readonly LeaderboardType type;

        public LeaderboardVO(LeaderboardType type, int totalEntries)
        {
            this.type = type;
            this.HasPlayerEntry = false;
            this.playerScore = null;
            this.totalEntries = totalEntries;
            this.entries = new List<LeaderboardEntryVO>();
        }

        public void AddScore(int rank, long score, string userName, bool isFriend, bool isPlayer)
        {
            if (rank <= 0) return;

            LeaderboardEntryVO entry = new LeaderboardEntryVO(rank, score, userName, isFriend, isPlayer);
            if (isPlayer)
            {
                this.playerScore = entry;
                this.HasPlayerEntry = true;
            }

            this.entries.Add(entry);
        }

        public void AddPlayerScore(int rank, long score, string userName)
        {
            LeaderboardEntryVO entry = new LeaderboardEntryVO(rank, score, userName, false, true);
            this.HasPlayerEntry = true;
            this.playerScore = entry;
        }

    }
}

