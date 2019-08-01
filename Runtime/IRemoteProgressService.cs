using System;

namespace Loju.Services
{

    public interface IRemoteProgressService
    {

        event EventHandler RemoteProgressAvailable;
        event EventHandler RemoteProgressChanged;

        bool IsRemoteProgressAvailable { get; }

        void Synchronize();

    }
}

