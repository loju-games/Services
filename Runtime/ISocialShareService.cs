using UnityEngine;

namespace Loju.Services
{
    public interface ISocialShareService
    {

        void Share(string message);
        void Share(string message, Texture2D texture);

    }
}

