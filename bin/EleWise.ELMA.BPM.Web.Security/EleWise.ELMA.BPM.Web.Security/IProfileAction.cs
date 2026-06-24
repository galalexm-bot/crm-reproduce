using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public interface IProfileAction
{
	int Order { get; set; }

	MvcHtmlString Render(HtmlHelper html);

	MvcHtmlString RenderIcons(HtmlHelper html);
}
