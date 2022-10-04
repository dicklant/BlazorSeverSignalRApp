using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Hubs;

public class BuzzerHub : Hub
{
    public async Task StartBuzzer()
    {
        await Clients.All.SendAsync("StartBuzzer");
    }

    public async Task StopBuzzer()
    {
        await Clients.All.SendAsync("StopBuzzer");
    }
}
