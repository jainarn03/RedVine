using Microsoft.AspNetCore.Mvc;
using RedVine.Models;

namespace RedVine.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            User user1 = new User() { Id = new Guid(), Name="Jawlessjman" };
            User user2 = new User() { Id = new Guid(), Name = "Wisepenguin" };
            User user3 = new() { Id = new Guid(), Name = "WatermelonInk" };
            User user4 = new() { Id = new Guid(), Name="D4v1d" };
            User user5 = new() { Id = new Guid(), Name = "DanTheMan" };

            Chat chat1 = new Chat(){ Id= new Guid(), Owner=user1.Name, Recipiant=user2.Name };
            Chat chat2 = new Chat() { Id = new Guid(), Owner=user1.Name, Recipiant=user3.Name };
            Chat chat3 = new() { Id=new Guid(), Owner=user1.Name, Recipiant=user4.Name };
            Chat chat4 = new() { Id= new Guid(), Owner=user1.Name, Recipiant=user5.Name };

            List<ChatMessage> messages = new() { new ChatMessage() { Id=new Guid(), Created=DateTime.Now, Message="Hello", Owner=user1.Name }, new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hello Jawlessjman", Owner = user2.Name } };

            List<ChatMessage> messages2 = new() { new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hello", Owner = user1.Name }, new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hi Jawlessjman", Owner = user3.Name } };

            List<ChatMessage> messages3 = new() { new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hello", Owner = user1.Name }, new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Yo Jawlessjman", Owner = user4.Name } };

            List<ChatMessage> messages4 = new() { new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hello", Owner = user1.Name }, new ChatMessage() { Id = new Guid(), Created = DateTime.Now, Message = "Hello there Jawlessjman", Owner = user5.Name } };

            messages.Reverse();
            messages2.Reverse();
            messages3.Reverse();
            messages4.Reverse();

            chat1.Messages = messages;
            chat2.Messages = messages2;
            chat3.Messages = messages3;
            chat4.Messages = messages4;

            List<Chat> chats = new List<Chat>() {
                chat1, chat2, chat3, chat4
            };
            return View(chats);
        }
    }
}
