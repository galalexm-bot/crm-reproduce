using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface ISubtaskSettingsWebRenderer
{
	CreateSubtaskSettingTypes SettingType { get; }

	bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property);

	MvcHtmlString Render(HtmlHelper html, ICreateSubtaskActionModel settings, PropertyMetadata property);
}
