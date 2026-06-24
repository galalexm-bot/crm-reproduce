using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.MarkupRendering;

public interface IMarkupRenderingService
{
	MvcHtmlString Render(HtmlHelper htmlHelper, string markup, string language, object model);
}
