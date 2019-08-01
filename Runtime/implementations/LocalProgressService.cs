using UnityEngine;

namespace Loju.Services
{
    public class LocalProgressService : IProgressService
    {

        public bool IsProgressServiceLoaded { get; private set; }

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
            IsProgressServiceLoaded = true;
            if (OnComplete != null) OnComplete(true);
        }

        public void SaveProgress(string key, object data)
        {
            _keystoreService.SetString(key, JsonUtility.ToJson(data));
            _keystoreService.Save();
        }

        public void LoadProgress<T>(string key, System.Action<T> onComplete) where T : IProgressData, new()
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

