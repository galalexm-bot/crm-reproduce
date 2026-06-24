using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGlobalSettingsModuleController
{
	IGlobalSettingsModule Module { get; }

	bool Editable { get; }

	bool Visible { get; }

	MvcHtmlString Header(HtmlHelper html);

	MvcHtmlString RenderDisplay(HtmlHelper html);

	MvcHtmlString RenderEdit(HtmlHelper html);

	GlobalSettingsSaveResult SaveSettings(ControllerContext context);
}
