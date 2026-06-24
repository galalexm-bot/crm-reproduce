using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 5)]
public class FilterModelDocumentFilterHiddenZonePanel : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{B1BB3CD5-428F-4F34-ACF8-C862557870EB}");

	public override Guid ZoneUid => UID;

	public override ZoneType ZoneType => ZoneType.StaticPanel;

	public override ZoneMode ZoneMode => ZoneMode.FilterSerach;

	public override string DisplayName => string.Empty;

	public override bool CheckType(FilterModel model)
	{
		if (model != null && model.Entity != null && model.Entity is IFilterDocumentFolder)
		{
			return model.Entity.IsNew();
		}
		return false;
	}

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		return false;
	}
}
[Component]
public class FilterModelDocumentFilterHiddenZonePanelRenderer : IFilterPropertiesZoneRenderer
{
	public Guid ZoneUid => FilterModelDocumentFilterHiddenZonePanel.UID;

	public void Render(HtmlHelper html, FilterPropertiesZone zone)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("ZoneUid", (object)ZoneUid);
		ViewDataDictionary val2 = val;
		val2.get_TemplateInfo().set_HtmlFieldPrefix(((html.get_ViewData().ContainsKey("postfix") && !string.IsNullOrWhiteSpace((string)html.get_ViewData().get_Item("postfix"))) ? string.Concat(html.get_ViewData().get_Item("postfix"), ".") : "") + "DataFilter");
		RenderPartialExtensions.RenderPartial(html, "FilterDocument/CommonDocumentFilterHiddens", (object)zone.FilterModel, val2);
	}
}
