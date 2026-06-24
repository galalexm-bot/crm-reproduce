using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 10)]
public class DocumentsStatusFilterPropertyExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (property.PropertyUid == InterfaceActivator.PropertyUid((IDocumentFilter f) => f.ListCycleStatus) && filterModel.Entity != null)
		{
			return filterModel.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		IDocumentFilter documentFilter = (IDocumentFilter)filterModel.Filter;
		if (documentFilter.ListCycleStatus == null)
		{
			documentFilter.ListCycleStatus = (ISet<ILifeCycleStatus>)(object)new HashedSet<ILifeCycleStatus>();
		}
		string text = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((string)((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId")) : string.Empty);
		string text2 = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("postfix") ? ((string)((ViewDataDictionary)html.get_ViewData()).get_Item("postfix")) : ((text != null) ? text.Replace("-", "m") : ""));
		ViewDataDictionary val = new ViewDataDictionary();
		val.get_TemplateInfo().set_HtmlFieldPrefix((string.IsNullOrWhiteSpace(text2) ? "" : (text2 + ".")) + "DataFilter.Filter." + property.PropertyName);
		if (!string.IsNullOrWhiteSpace(text))
		{
			val.Add("filterGridId", (object)text);
		}
		return PartialExtensions.Partial((HtmlHelper)(object)html, "EditorTemplates/LifeCycleStatusSet", (object)documentFilter.ListCycleStatus, val);
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
