using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Portlets;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
{
	public DocumentsHomePortlet DocumentsHomePortlet { get; set; }

	public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
	{
		yield return new SecurityDefaultHomePagePortlet(DocumentsHomePortlet, "Left", 30);
	}
}
