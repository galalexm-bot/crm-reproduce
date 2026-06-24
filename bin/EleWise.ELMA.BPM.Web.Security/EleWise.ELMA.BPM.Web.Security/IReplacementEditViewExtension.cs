using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementEditViewExtension
{
	string Id { get; }

	string Name { get; }

	bool SaveState { get; }

	bool Expanded { get; }

	MvcHtmlString Render(HtmlHelper html, ReplacementModel model);
}
