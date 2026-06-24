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

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component]
public class FolderFilterPropertyEditorExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (property.PropertyUid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.Folder) && filterModel.Entity != null)
		{
			return filterModel.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.get_TemplateInfo().set_HtmlFieldPrefix(((((ViewDataDictionary)html.get_ViewData()).ContainsKey("postfix") && !string.IsNullOrWhiteSpace((string)((ViewDataDictionary)html.get_ViewData()).get_Item("postfix"))) ? string.Concat(((ViewDataDictionary)html.get_ViewData()).get_Item("postfix"), ".") : "") + "DataFilter");
		return PartialExtensions.Partial((HtmlHelper)(object)html, "FilterDocument/FolderFilterSelector", (object)filterModel, val);
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
