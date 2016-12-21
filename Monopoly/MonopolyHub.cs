using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Threading.Tasks;

namespace Monopoly
{
    [HubName("Monopoly")]
    public class MonopolyHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public void Test()
        {
            Random rand = new Random();
            
            base.Clients.All.receiveDiceRoll(rand.Next(1, 6), rand.Next(1, 6));
        }
    }
}