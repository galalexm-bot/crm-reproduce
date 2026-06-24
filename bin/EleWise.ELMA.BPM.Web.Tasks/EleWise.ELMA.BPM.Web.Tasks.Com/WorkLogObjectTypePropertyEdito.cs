using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorkLogObjectTypePropertyEditorExtension : IFilterPropertyEditorExtension
{
	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filterModel.Filter;
		if (workLogItemSearchFilter != null)
		{
			property.PropertyDisplayName = SR.T("Объект трудозатрат");
			object obj = workLogItemSearchFilter.EntityType;
			ViewDataDictionary val = new ViewDataDictionary();
			val.Add("id", (object)"DataFilter.Filter.EntityType");
			val.Add("width", (object)"100%");
			val.Add("onchange", (object)"filterformSubmit");
			val.Add("cssClass", (object)"input-large");
			return PartialExtensions.Partial((HtmlHelper)(object)html, "EditorTemplates/WorkLogObjectTypeSelector", obj, val);
		}
		return MvcHtmlString.Empty;
	}

	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		return property.PropertyUid == InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter i) => i.EntityType);
	}
}
