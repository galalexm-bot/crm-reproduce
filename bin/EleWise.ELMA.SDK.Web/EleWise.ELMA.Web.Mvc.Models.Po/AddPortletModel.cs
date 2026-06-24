using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.Portal;

public class AddPortletModel
{
	public IEnumerable<IPortlet> Portlets { get; set; }

	public IEnumerable<AddPortlet> AllPortlets { get; set; }

	public PersonalizationScope Scope { get; set; }
}
