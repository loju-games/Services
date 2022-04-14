
namespace Loju.Services
{
    public static class LocalUserIdService
    {
        private const string kKeyGUID = "LUIDS_GUID";

        public static string Get(ILocalKeystoreService keystoreService)
        {
            if (keystoreService.HasKey(kKeyGUID)) return keystoreService.GetString(kKeyGUID);
            else
            {
                string localUserId = System.Guid.NewGuid().ToString();
                keystoreService.SetString(kKeyGUID, localUserId);

                return localUserId;
            }
        }

    }
}