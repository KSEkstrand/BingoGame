using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace AngSignalR2.Hubs
{
    public class SpinHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}