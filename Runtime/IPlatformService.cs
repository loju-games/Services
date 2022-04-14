
namespace Loju.Services
{

    public interface IPlatformService
    {

        bool IsLoaded { get; }

        string LocalUserId { get; }
        string LocalUserDisplayName { get; }

        void Load(bool reconnect, System.Action<bool> onComplete);

    }
}

