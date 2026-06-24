using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskStatusLinkDescription
{
	bool CheckType(ITaskBase task);

	MvcHtmlString Description(HtmlHelper htmlHelper, ITaskBase task);
}
