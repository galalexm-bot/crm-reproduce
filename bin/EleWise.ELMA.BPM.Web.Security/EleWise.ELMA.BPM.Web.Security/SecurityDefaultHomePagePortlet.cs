using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints
{
	public class SecurityDefaultHomePagePortlet
	{
		public IPortlet Portlet { get; private set; }

		public string Zone { get; private set; }

		public int Order { get; private set; }

		public SecurityDefaultHomePagePortlet(IPortlet portlet, string zone, int order)
		{
			Portlet = portlet;
			Zone = zone;
			Order = order;
		}
	}
}
namespace EleWise.ELMA.BPM.Web.Security.Components
{
	[Component]
	internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
	{
		public UsersHomePortlet UsersHomePortlet { get; set; }

		public PermissionsHomePortlet PermissionsHomePortlet { get; set; }

		public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
		{
			yield return new SecurityDefaultHomePagePortlet(UsersHomePortlet, "Right", 10);
			yield return new SecurityDefaultHomePagePortlet(PermissionsHomePortlet, "Right", 30);
		}
	}
}
