using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class SerializedFilter : IExtensionZone
{
	private const string FilterModelZone = "EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId != "EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter")
		{
			return;
		}
		bool enableEqlQuery = false;
		Guid entityTypeUid;
		try
		{
			entityTypeUid = (Guid)html.get_ViewData().get_Item("EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-EntityTypeUid");
		}
		catch (Exception)
		{
			throw new Exception(SR.T("Некорректное значение EntityTypeUid, заданое ViewData[\"{0}\"]", "EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-EntityTypeUid"));
		}
		if (html.get_ViewData().get_Item("EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-EnableEqlQuery") != null)
		{
			try
			{
				enableEqlQuery = (bool)html.get_ViewData().get_Item("EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-EnableEqlQuery");
			}
			catch (Exception)
			{
				throw new Exception(SR.T("Некорректное значение EnableEqlQuery, заданое ViewData[\"{0}\"]", "EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-EnableEqlQuery"));
			}
		}
		object model = html.get_ViewData().get_Model();
		html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)ChildActionExtensions.Action(html, "Filter", "SerializedFilter", (object)new
		{
			entityTypeUid = entityTypeUid,
			serializedFilter = model,
			enableEqlQuery = enableEqlQuery,
			area = "EleWise.ELMA.BPM.Web.Common"
		})).ToHtmlString());
	}
}
