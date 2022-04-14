namespace Loju.Services
{

    public interface ILocalKeystoreService
    {

        bool HasKey(string key);

        bool GetBool(string key);
        bool GetBool(string key, bool defaultValue);
        int GetInt(string key);
        int GetInt(string key, int defaultValue);
        string GetString(string key);
        string GetString(string key, string defaultValue);
        float GetFloat(string key);
        float GetFloat(string key, float defaultValue);
        T GetObject<T>(string key);

        void SetBool(string key, bool value);
        void SetInt(string key, int value);
        void SetString(string key, string value);
        void SetFloat(string key, float value);
        void SetObject(string key, object value);

        void Save();

    }

}