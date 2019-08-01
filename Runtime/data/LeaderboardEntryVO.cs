

namespace Loju.Services
{

    public class LeaderboardEntryVO
    {

        public readonly int rank;
        public readonly long score;
        public readonly string userName;
        public readonly bool isFriend;
        public readonly bool isPlayer;

        public LeaderboardEntryVO(int rank, long score, string userName, bool isFriend, bool isPlayer)
        {
            this.rank = rank;
            this.score = score;
            this.userName = userName;
            this.isFriend = isFriend;
            this.isPlayer = isPlayer;
        }

    }

}