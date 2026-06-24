using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Settings;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExternalMembershipRender
{
	bool IsSupported(IExternalMembershipModuleSettings settings);

	MvcHtmlString RenderDisplay(HtmlHelper html, IExternalMembershipModuleSettings settings);

	MvcHtmlString RenderEdit(HtmlHelper html, IExternalMembershipModuleSettings settings);
}
