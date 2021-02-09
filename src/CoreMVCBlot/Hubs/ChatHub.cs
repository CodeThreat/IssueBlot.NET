using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CoreMVCBlot.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {

            // CTSECISSUE:Command Injection
            Process.Start("cmd.exe /C C:\\Collect.exe " + message);

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}