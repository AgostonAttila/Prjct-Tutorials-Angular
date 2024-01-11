using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Prjct_Chat_AngularNetCore.Hubs
{
   public class MessageHub : Hub
   {
      public async Task NewMessage(Models.Message msg)
      {
         await Clients.All.SendAsync("MessageReceived", msg);
      }
   }
}