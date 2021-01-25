
namespace Loju.Services
{
    public interface IDataStoreService
    {

        bool IsDataStoreServiceLoaded { get; }

        void SaveData(string key, ISaveData data);
        void SaveData(string key, string data);
        void LoadData<T>(string key, System.Action<T> onComplete) where T : ISaveData, new();
        void LoadData(string key, System.Action<string> onComplete);

    }
}

