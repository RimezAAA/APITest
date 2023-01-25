using Microsoft.AspNetCore.SignalR;

namespace APITest
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName, string email)
        {
            
            if (message == "/start")
            {
                await Clients.All.SendAsync("Receive", "Привет, готов к работе", "Bot", "Johan");
            }
            else if (message == "/end")
            {
                await Clients.All.SendAsync("Receive", "пока", "Bot", "Johan");
            }
            else if(message == "/download")
            {
                var users = MongoExamples.FindAll();
                Console.WriteLine("123");
                foreach(var user in users)
                {
                    await Clients.All.SendAsync("Receive", user.Message, user.Name, user.Email);
                }
            }
            else
            {
                MongoExamples.AddToDB(new User(userName, email, message));
                await Clients.All.SendAsync("Receive", message, userName, email);
            }
        }

        public async Task<List<User>> GetStr()
        {
            return MongoExamples.FindAll();
        }

    }
}
