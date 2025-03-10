using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace SS14.Launcher.Models.ServerStatus;

public sealed class ServerStatusData : ObservableObject, IServerStatusData
{
    private string? _name;
    private TimeSpan? _ping;
    private int _playerCount;
    private ServerStatusCode _status = ServerStatusCode.FetchingStatus;

    public ServerStatusData(string address)
    {
        Address = address;
    }

    public string Address { get; }

    public string? Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    // BUG: This ping stat is completely wrong currently.
    // See the assignment in ServerStatusCache.cs for why.
    public TimeSpan? Ping
    {
        get => _ping;
        set => SetProperty(ref _ping, value);
    }

    public ServerStatusCode Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public int PlayerCount
    {
        get => _playerCount;
        set => SetProperty(ref _playerCount, value);
    }
}
