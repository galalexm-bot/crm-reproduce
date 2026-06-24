using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Portlets;

[Component]
public class DefaultHomePagePortletsProvider : IDefaultHomePagePortletsProvider
{
	public CalendarPortlet CalendarPortlet { get; set; }

	public IEnumerable<DefaultHomePagePortlet> Portlets()
	{
		yield return new DefaultHomePagePortlet(CalendarPortlet, "Right", 10);
	}
}
