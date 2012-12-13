using System;
using Microsoft.AspNet.SignalR.Hubs;

namespace MvcKickstart.Hubs
{
	public class MainHub : Hub
	{
		public void DoSomething(string connection)
		{
			Clients.Client(connection).funkyChickenDance();
		}
	}
}