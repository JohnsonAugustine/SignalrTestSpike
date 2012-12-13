using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Moq;
using MvcKickstart.Hubs;

namespace MvcKickstart.Tests.Hubs.Main
{
	public class TestableHub : MainHub
	{
		public const string ConnectionId = "1234";

		public TestableHub(HubConnectionContext clients)
		{
			var mockCookies = new Mock<IRequestCookieCollection>();

			var mockRequest = new Mock<IRequest>();
			mockRequest.Setup(r => r.Cookies).Returns(mockCookies.Object);

			Context = new HubCallerContext(mockRequest.Object, ConnectionId);

			Clients = clients;
		}
	}
}
