using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using StructureMap;

namespace MvcKickstart
{
	public class MvcApplication : HttpApplication
	{
		public MvcApplication()
		{
			EndRequest += (sender, e) => ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
		}
		protected void Application_Start()
		{
			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(new RazorViewEngine());

			AreaRegistration.RegisterAllAreas();

			IocConfig.Bootstrap();
		}

		public override string GetVaryByCustomString(HttpContext context, string custom)
		{
			if (custom == "user")
			{
				if (context.User.Identity.IsAuthenticated)
					return context.User.Identity.Name;

				// Anonymous users should share the same cache. 
				return string.Empty;
			}
			return base.GetVaryByCustomString(context, custom);
		}
	}
}