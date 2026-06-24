using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
{
	public SystemInfoPortlet SystemInfoPortlet { get; set; }

	public CommonHomePortlet CommonHomePortlet { get; set; }

	public SettingsHomePortlet SettingsHomePortlet { get; set; }

	public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
	{
		yield return new SecurityDefaultHomePagePortlet(SystemInfoPortlet, "Left", 10);
		yield return new SecurityDefaultHomePagePortlet(CommonHomePortlet, "Left", 20);
		yield return new SecurityDefaultHomePagePortlet(SettingsHomePortlet, "Right", 20);
	}
}
