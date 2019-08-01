
namespace Loju.Services
{
    public interface IProgressService
    {

        bool IsProgressServiceLoaded { get; }
        void Connect(bool reconnect, System.Action<bool> onComplete);

        void SaveProgress(string key, object data);
        void LoadProgress<T>(string key, System.Action<T> onComplete) where T : IProgressData, new();

    }
}

