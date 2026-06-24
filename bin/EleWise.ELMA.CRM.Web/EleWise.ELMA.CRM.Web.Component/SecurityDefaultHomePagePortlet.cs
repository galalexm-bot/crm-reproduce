using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Web.Portlets;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
{
	public CRMHomePortlet CRMHomePortlet { get; set; }

	public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
	{
		yield return new SecurityDefaultHomePagePortlet(CRMHomePortlet, "Left", 40);
	}
}
