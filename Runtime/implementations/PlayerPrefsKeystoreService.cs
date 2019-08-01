using UnityEngine;

namespace Loju.Services
{

    public sealed class PlayerPrefsKeystoreService : ILocalKeystoreService
    {

        public bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        public bool GetBool(string key)
        {
            return PlayerPrefs.GetInt(key) > 0;
        }

        public int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public T GetObject<T>(string key)
        {
            string json = PlayerPrefs.GetString(key);
            return JsonUtility.FromJson<T>(json);
        }

        public void SetBool(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }

        public void SetObject(string key, object value)
        {
            string json = JsonUtility.ToJson(value);
            PlayerPrefs.SetString(key, json);
        }

        public void Save()
        {
            PlayerPrefs.Save();
        }

    }

}