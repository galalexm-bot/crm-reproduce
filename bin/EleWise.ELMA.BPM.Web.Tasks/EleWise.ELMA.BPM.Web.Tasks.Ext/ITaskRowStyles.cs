using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
internal interface ITaskRowStyles
{
	bool IsValid(ITaskBase task);

	string GetClass(ITaskBase task);

	MvcHtmlString GetIcon(HtmlHelper htmlHelper, ITaskBase task);
}
