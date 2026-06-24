using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal class SubtaskHiddenSettingsWebRenderer : ISubtaskSettingsWebRenderer
{
	public CreateSubtaskSettingTypes SettingType => CreateSubtaskSettingTypes.HiddenSetting;

	public bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		return true;
	}

	public MvcHtmlString Render(HtmlHelper html, ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		object value = settings.GetType().GetProperty(property.Name).GetValue(settings, null);
		return MvcHtmlString.Create($"<tr><td>{InputExtensions.Hidden(html, property.Name, value)}</td></tr>");
	}
}
