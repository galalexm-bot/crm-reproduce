using System.Collections.Generic;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class PortletPageAttributesModel
{
	public IPortletPage Page { get; set; }

	public IEnumerable<IPortletLayout> Layouts { get; set; }

	public IEnumerable<string> Themes { get; set; }
}
