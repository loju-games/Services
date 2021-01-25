
namespace Loju.Services
{

    public interface IPlatformService
    {

        bool IsLoaded { get; }

        void Load(bool reconnect, System.Action<bool> onComplete);

    }
}

