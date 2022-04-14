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

        public bool GetBool(string key, bool defaultValue)
        {
            if (HasKey(key))
                return PlayerPrefs.GetInt(key) > 0;
            else
                return defaultValue;
        }

        public int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public int GetInt(string key, int defaultValue)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }

        public float GetFloat(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }

        public float GetFloat(string key, float defaultValue)
        {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }

        public string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public string GetString(string key, string defaultValue)
        {
            return PlayerPrefs.GetString(key, defaultValue);
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

        public void SetFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
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