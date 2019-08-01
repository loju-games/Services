namespace Loju.Services
{

    public interface ILocalKeystoreService
    {

        bool HasKey(string key);

        bool GetBool(string key);
        int GetInt(string key);
        string GetString(string key);
        T GetObject<T>(string key);

        void SetBool(string key, bool value);
        void SetInt(string key, int value);
        void SetString(string key, string value);
        void SetObject(string key, object value);
        void Save();

    }

}