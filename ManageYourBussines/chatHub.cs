using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines
{
    public class chatHub : Hub
    {
        public void send (string name,string message)
        {
            Clients.All.sendChart(name, message);
        }
    }
}