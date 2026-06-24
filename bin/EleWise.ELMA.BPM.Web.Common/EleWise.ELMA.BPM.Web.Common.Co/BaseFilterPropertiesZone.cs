using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public abstract class BaseFilterPropertiesZone : IFilterPropertiesZone
{
	public abstract Guid ZoneUid { get; }

	public virtual Guid? ParentZone => null;

	public virtual ZoneMode ZoneMode => ZoneMode.EditFilter;

	public abstract ZoneType ZoneType { get; }

	public abstract string DisplayName { get; }

	public virtual string FilterHtmlPrefix => "DataFilter.Filter";

	public virtual bool ShowHeader => true;

	public string HeaderCss => "separator-gray";

	public virtual bool UseSaveState => false;

	public abstract bool CheckType(FilterModel model);

	public abstract bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property);

	public virtual MvcHtmlString AdditionalContent(HtmlHelper html, FilterModel model)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		object obj = (html.get_ViewData().ContainsKey("filterGridId") ? html.get_ViewData().get_Item("filterGridId") : string.Empty);
		string text = (html.get_ViewData().ContainsKey("postfix") ? ((string)html.get_ViewData().get_Item("postfix")) : ((obj != null) ? obj.ToString().Replace("-", "m") : ""));
		val.get_TemplateInfo().set_HtmlFieldPrefix((string.IsNullOrWhiteSpace(text) ? "" : (text + ".")) + FilterHtmlPrefix);
		IEntityFilter filter = GetFilter(model);
		if (filter == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Filter/FilterPropertiesHiddenZone", (object)filter, val);
	}

	public virtual bool IsVisible(FilterModel model)
	{
		return true;
	}

	public virtual IEntityFilter GetFilter(FilterModel model)
	{
		return model.Filter;
	}

	public virtual string PreUpdateJS(FilterModel model)
	{
		return null;
	}
}
