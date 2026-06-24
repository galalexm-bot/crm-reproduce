using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Processes.Web.Portlets;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
internal class SecurityDefaultHomePagePortletProvider : ISecurityDefaultHomePagePortletsProvider
{
	public ProcessesHomePortlet ProcessesHomePortlet { get; set; }

	public IEnumerable<SecurityDefaultHomePagePortlet> Portlets()
	{
		yield return new SecurityDefaultHomePagePortlet(ProcessesHomePortlet, "Right", 50);
	}
}
