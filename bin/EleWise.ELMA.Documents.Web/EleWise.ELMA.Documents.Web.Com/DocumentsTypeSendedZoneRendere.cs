using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component]
public class DocumentsTypeSendedZoneRenderer : IFilterPropertiesZoneRenderer
{
	public Guid ZoneUid => DocumentsTypeSendedZonePanel.UID;

	public void Render(HtmlHelper html, FilterPropertiesZone zone)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("ZoneUid", (object)ZoneUid);
		ViewDataDictionary val2 = val;
		val2.get_TemplateInfo().set_HtmlFieldPrefix(((html.get_ViewData().ContainsKey("postfix") && !string.IsNullOrWhiteSpace((string)html.get_ViewData().get_Item("postfix"))) ? string.Concat(html.get_ViewData().get_Item("postfix"), ".") : "") + "DataFilter");
		RenderPartialExtensions.RenderPartial(html, "FilterDocument/DocumentsTypeSendedZone", (object)zone, val2);
	}
}
