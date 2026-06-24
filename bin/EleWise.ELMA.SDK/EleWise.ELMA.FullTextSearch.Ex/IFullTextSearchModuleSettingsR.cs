using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFullTextSearchModuleSettingsRender
{
	IGlobalSettingsModule Module { get; }

	bool IsSupported(IFullTextSearchModuleSettings settings);

	MvcHtmlString RenderDisplay(HtmlHelper html);

	MvcHtmlString RenderEdit(HtmlHelper html);

	FullTextSettingsSaveResult SaveSettings(ControllerContext context);
}
