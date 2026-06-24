using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISolveTaskViewer
{
	bool CheckType(ITaskBase task);

	MvcHtmlString Render(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings, bool forControl);
}
