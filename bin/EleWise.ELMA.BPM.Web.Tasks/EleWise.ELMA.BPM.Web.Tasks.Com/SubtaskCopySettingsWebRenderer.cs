using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal class SubtaskCopySettingsWebRenderer : ISubtaskSettingsWebRenderer
{
	public CreateSubtaskSettingTypes SettingType => CreateSubtaskSettingTypes.CopySetting;

	public bool CanRender(ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		return true;
	}

	public MvcHtmlString Render(HtmlHelper html, ICreateSubtaskActionModel settings, PropertyMetadata property)
	{
		MvcHtmlString result = MvcHtmlString.Empty;
		try
		{
			result = MvcHtmlString.Create($"<div>{html.ModernCheckBoxFor(property.Name, renderUncheckedInput: true, generateIdByName: true).Checked(true).LabelText(property.DisplayName)}</div>");
			return result;
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Не удалось отобразить свойство {0}", property.Name), exception);
			return result;
		}
	}
}
