using UnityEngine;

namespace Loju.Services
{

    public class LocalProgressService : IPlatformService, IDataStoreService
    {

        public bool IsLoaded { get; private set; }
        public bool IsDataStoreServiceLoaded { get { return IsLoaded; } }
        public string LocalUserId { get { return _localUserId; } }
        public string LocalUserDisplayName { get { return _localUserDisplayName; } set { _localUserDisplayName = value; } }

        private string _localUserId;
        private string _localUserDisplayName;
        private ILocalKeystoreService _keystoreService;

        public LocalProgressService() : this(new PlayerPrefsKeystoreService()) { }

        public LocalProgressService(ILocalKeystoreService keystoreService)
        {
            _keystoreService = keystoreService;
            _localUserDisplayName = "";
            _localUserId = LocalUserIdService.Get(_keystoreService);
        }

        public void Load(bool reconnect, System.Action<bool> OnComplete)
        {
            IsLoaded = true;
            if (OnComplete != null) OnComplete(true);
        }

        public void SaveData(string key, ISaveData data)
        {
            _keystoreService.SetString(key, JsonUtility.ToJson(data));
            _keystoreService.Save();
        }

        public void SaveData(string key, string data)
        {
            _keystoreService.SetString(key, data);
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

        public void LoadData(string key, System.Action<string> onComplete)
        {
            if (_keystoreService.HasKey(key))
            {
                try
                {
                    onComplete(_keystoreService.GetString(key));
                }
                catch
                {
                    onComplete(null);
                }
            }
            else
            {
                onComplete(null);
            }
        }

    }
}

