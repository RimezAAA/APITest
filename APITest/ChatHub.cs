using Microsoft.AspNetCore.SignalR;

namespace APITest
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName, string email)
        {
            await Clients.All.SendAsync("Receive", message, userName, email);
        }
    }
}
