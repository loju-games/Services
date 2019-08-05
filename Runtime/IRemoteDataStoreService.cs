using System;

namespace Loju.Services
{

    public interface IRemoteDataStoreService
    {

        event EventHandler RemoteDataAvailable;
        event EventHandler RemoteDataChanged;

        bool IsRemoteDataAvailable { get; }

        void Synchronize();

    }
}

