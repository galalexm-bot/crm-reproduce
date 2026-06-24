using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 100)]
public class ObjectsTypeFilterPropertyEditorExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		return property.PropertyUid == FilterModel.ObjectsTypePropertyUid;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		HtmlAttributes htmlAttributes = new HtmlAttributes
		{
			@class = "default-width"
		};
		MvcHtmlString obj = PartialExtensions.Partial((HtmlHelper)(object)html, "Filter/ObjectsTypeChangedFunc", (object)filterModel);
		Guid typeUid = filterModel.MainTypeUid ?? filterModel.Entity.ObjectsType.TypeUid;
		IUniqueFilterExtension extension = UniqueFilterHelper.GetExtension(typeUid);
		ClassMetadata rootMetadata = ((extension != null) ? MetadataLoader.LoadMetadata(extension.EntityType) : MetadataLoader.LoadMetadata(typeUid)) as ClassMetadata;
		Func<ClassMetadata, bool> filter = (from f in ComponentManager.Current.GetExtensionPoints<IFilterTypeFilter>()
			where f.EntityTypeUid == typeUid
			select f.GetFilter()).FirstOrDefault();
		object obj2 = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId") : string.Empty);
		string postfix = ((obj2 != null) ? obj2.ToString().Replace("-", "m") : "");
		string selectedValue = null;
		MvcHtmlString val = MvcHtmlString.Create(((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentFactory)HtmlHelperExtension.Telerik<object>(html)).DropDownList()).Name(((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldName("") + "TypeSelector")).BindTo((IEnumerable<SelectListItem>)GridState.TypesTree(((HtmlHelper)(object)html).Url(), rootMetadata, filterModel.FilterTypeUid, ref selectedValue, (filter != null) ? ((Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>>)((IEnumerable<ClassMetadata> m) => m.Where(filter))) : null, (Guid u, Type t) => $"{{\"typeUid\":\"{u}\",\"typeName\":\"{t}\"}}", filterModel.TypesRootName))).Value(selectedValue)).ClientEvents((Action<DropDownClientEventsBuilder>)delegate(DropDownClientEventsBuilder events)
		{
			events.OnChange(((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId("ObjectsTypeChanged") + postfix);
		})).DropDownHtmlAttributes((IDictionary<string, object>)htmlAttributes)).Encode(false)).HtmlAttributes((IDictionary<string, object>)htmlAttributes)).ToHtmlString());
		return new MvcHtmlString(string.Concat(obj, val));
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
