using UnityEngine;

namespace Loju.Services
{

    public class LocalProgressService : IDataStoreService
    {

        public bool IsDataStoreServiceLoaded { get; private set; }

        private ILocalKeystoreService _keystoreService;

        public LocalProgressService()
        {
            _keystoreService = new PlayerPrefsKeystoreService();
        }

        public LocalProgressService(ILocalKeystoreService keystoreService)
        {
            _keystoreService = keystoreService;
        }

        public void Connect(bool reconnect, System.Action<bool> OnComplete)
        {
            IsDataStoreServiceLoaded = true;
            if (OnComplete != null) OnComplete(true);
        }

        public void SaveData(string key, ISaveData data)
        {
            _keystoreService.SetString(key, JsonUtility.ToJson(data));
            _keystoreService.Save();
        }

        public void LoadData<T>(string key, System.Action<T> onComplete) where T : ISaveData, new()
        {
            if (_keystoreService.HasKey(key))
            {
                try
                {
                    onComplete(JsonUtility.FromJson<T>(_keystoreService.GetString(key)));
                }
                catch
                {
                    onComplete(new T());
                }
            }
            else
            {
                onComplete(new T());
            }
        }

    }
}

