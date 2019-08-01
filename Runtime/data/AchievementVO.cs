
namespace Loju.Services
{
    public sealed class AchievementVO
    {
        public readonly string id;
        public readonly float progress;

        public AchievementVO(string id, float progress)
        {
            this.id = id;
            this.progress = progress;
        }
    }

}