﻿using System;


namespace mRemoteNG.Config.Connections
{
    public interface IConnectionsUpdateChecker : IDisposable
    {
        bool IsUpdateAvailable();

        void IsUpdateAvailableAsync();

        event EventHandler UpdateCheckStarted;
        event UpdateCheckFinishedEventHandler UpdateCheckFinished;
        event ConnectionsUpdateAvailableEventHandler ConnectionsUpdateAvailable;
    }
}