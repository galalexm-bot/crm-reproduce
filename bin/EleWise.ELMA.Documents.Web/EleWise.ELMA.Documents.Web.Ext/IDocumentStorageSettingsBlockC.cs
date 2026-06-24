using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentStorageSettingsBlockController
{
	IDocumentStorageSettingsBlock Block { get; }

	MvcHtmlString Header(HtmlHelper html);

	MvcHtmlString RenderDisplay(HtmlHelper html);

	MvcHtmlString RenderEdit(HtmlHelper html);

	GlobalSettingsSaveResult SaveSettings(ControllerContext context);
}
