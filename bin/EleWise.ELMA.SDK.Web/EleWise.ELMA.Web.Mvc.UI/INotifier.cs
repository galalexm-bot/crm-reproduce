using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.UI;

public interface INotifier : IFormNotifier
{
	void HtmlAction(string action, string controller, RouteValueDictionary routeValues);

	MvcHtmlString Render(HtmlHelper html);

	void RenderInPopup(string text);

	void RenderInPopup(MvcHtmlString text);
}
