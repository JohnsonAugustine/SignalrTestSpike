using System;
using Microsoft.AspNet.SignalR.Hubs;

namespace MvcKickstart.Tests.Hubs
{
	public class TestableHubConnectionContext : HubConnectionContext
	{
		public new dynamic Client(string connectionId)
		{
			throw new Exception("This will never throw....");
		}
	}
}
