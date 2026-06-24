using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Content.Portlets;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
{
	public PortalHomePortlet PortalHomePortlet { get; set; }

	public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
	{
		yield return new SecurityDefaultHomePagePortlet(PortalHomePortlet, "Left", 25);
	}
}
