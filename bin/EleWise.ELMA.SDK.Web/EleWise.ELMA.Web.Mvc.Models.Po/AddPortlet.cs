using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Models.Portal;

public sealed class AddPortlet
{
	public IPortlet Portlet { get; set; }

	public bool CanAdd { get; set; }
}
