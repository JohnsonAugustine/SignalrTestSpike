using MvcKickstart.Hubs;
using NUnit.Framework;

namespace MvcKickstart.Tests.Hubs.Main
{
	public class DoSomethingTests
	{
		[Test]
		public void VerifyClientMethodIsCalled()
		{
			var clients = new TestableHubConnectionContext();

			var hub = new TestableHub(clients);
			hub.DoSomething("asdf234");
		}
	}
}
