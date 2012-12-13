using System.Configuration;
using System.Data;
using Microsoft.AspNet.SignalR;
using StructureMap.Configuration.DSL;

namespace MvcKickstart.Infrastructure
{
	public class IocRegistry : Registry
	{
		public IocRegistry()
		{
			Scan(scan =>
					{
						scan.TheCallingAssembly();
						scan.WithDefaultConventions();
					});

			For<IDependencyResolver>().Singleton().Use<StructureMapSignalrDependencyResolver>();
			For<IConnectionManager>().Singleton().Use(GlobalHost.ConnectionManager);
		}
	}
}
