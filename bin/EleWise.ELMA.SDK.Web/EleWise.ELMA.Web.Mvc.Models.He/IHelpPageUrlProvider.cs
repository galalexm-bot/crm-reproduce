using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.Help;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web | ComponentType.Test)]
public interface IHelpPageUrlProvider
{
	bool IsGlobalModuleProvider { get; }

	string IconUrl(UrlHelper url);

	string IndexUrl(UrlHelper url);

	MvcHtmlString RenderHeader(HtmlHelper html);

	MvcHtmlString RenderDescription(HtmlHelper html);

	string FindUrl(ControllerContext controllerContext);
}
