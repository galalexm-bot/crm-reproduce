using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class DefaultHomePagePortletsProvider : IDefaultHomePagePortletsProvider
{
	public TasksPortlet TasksPortlet { get; set; }

	public IEnumerable<DefaultHomePagePortlet> Portlets()
	{
		yield return new DefaultHomePagePortlet(TasksPortlet, "Left", 10);
	}
}
