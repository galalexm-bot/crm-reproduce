using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public interface IMainMenuItemCustomContent
{
	MvcHtmlString RenderContent(HtmlHelper html);
}
