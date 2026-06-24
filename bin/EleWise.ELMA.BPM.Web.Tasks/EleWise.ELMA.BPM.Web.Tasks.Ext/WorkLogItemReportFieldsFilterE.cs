using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class WorkLogItemReportFieldsFilterExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (filterModel.Entity.ObjectsType.TypeUid == new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}") && (filterModel.Entity.Code == new Guid("{12445703-C5A9-4946-AD1E-7E7B39E318D4}") || filterModel.Entity.Code == new Guid("{DE39923A-6F35-4890-B518-BB9A892C16C3}")) && property.PropertyUid == InterfaceActivator.PropertyUid((IWorkLogItemSearchFilter p) => p.EntityType))
		{
			return filterModel.Filter is IWorkLogItemSearchFilter;
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = ((IWorkLogItemSearchFilter)filterModel.Filter).EntityType;
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("id", (object)"DataFilter.Filter.EntityType");
		val.Add("width", (object)"100%");
		return PartialExtensions.Partial((HtmlHelper)(object)html, "EditorTemplates/WorkLogObjectTypeSelector", obj, val);
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
