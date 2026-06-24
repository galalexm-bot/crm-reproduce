using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskActionRenderer
{
	bool CanRender(object model);

	MvcHtmlString Render(HtmlHelper html, object model);
}
