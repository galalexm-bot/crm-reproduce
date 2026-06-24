using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Html;

public sealed class LabeledContainerModel
{
	public MvcHtmlString Label { get; set; }

	public RouteValueDictionary Attributes { get; set; }
}
