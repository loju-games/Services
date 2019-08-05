
namespace Loju.Services
{
    public interface IDataStoreService
    {

        bool IsDataStoreServiceLoaded { get; }
        void Connect(bool reconnect, System.Action<bool> onComplete);

        void SaveData(string key, ISaveData data);
        void LoadData<T>(string key, System.Action<T> onComplete) where T : ISaveData, new();

    }
}

