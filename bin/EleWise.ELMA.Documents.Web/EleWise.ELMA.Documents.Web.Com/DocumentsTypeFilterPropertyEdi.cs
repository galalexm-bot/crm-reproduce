using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 10)]
public class DocumentsTypeFilterPropertyEditorExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (property.PropertyUid == FilterModel.ObjectsTypePropertyUid && filterModel.Entity != null)
		{
			return filterModel.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		MvcHtmlString obj = PartialExtensions.Partial((HtmlHelper)(object)html, "FilterDocument/DocumentsTypeChangedFunc", (object)filterModel);
		Guid guid = filterModel.MainTypeUid ?? filterModel.Entity.ObjectsType.TypeUid;
		IDocumentFilter documentFilter = (IDocumentFilter)filterModel.Filter;
		List<ReferenceOnEntityType> list = ((documentFilter.Types != null) ? documentFilter.Types.Where((ReferenceOnEntityType t) => t != null && t.TypeUid != Guid.Empty).ToList() : new List<ReferenceOnEntityType>());
		if (list.Count == 0 && guid != InterfaceActivator.UID<IDocument>())
		{
			list.Add(new ReferenceOnEntityType
			{
				TypeUid = guid
			});
		}
		string text = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((string)((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId")) : string.Empty);
		string text2 = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("postfix") ? ((string)((ViewDataDictionary)html.get_ViewData()).get_Item("postfix")) : ((text != null) ? text.Replace("-", "m") : ""));
		string text3 = (string.IsNullOrWhiteSpace(text2) ? "" : ("_" + text2));
		string htmlFieldPrefix = ((!string.IsNullOrWhiteSpace(text2)) ? (text2 + ".") : "") + "DataFilter.Filter.Types";
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("OnChangeHandler", (object)("DocumentsTypeChanged" + text3 + "();"));
		ViewDataDictionary val2 = val;
		val2.get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
		if (filterModel.ParentTypeUid.HasValue)
		{
			val2.Add("ParentTypeUid", (object)filterModel.ParentTypeUid.ToString());
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			val2.Add("filterGridId", (object)text);
		}
		return new MvcHtmlString(string.Concat(obj, PartialExtensions.Partial((HtmlHelper)(object)html, "EditorTemplates/DocumentTypeSet", (object)list, val2)));
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
