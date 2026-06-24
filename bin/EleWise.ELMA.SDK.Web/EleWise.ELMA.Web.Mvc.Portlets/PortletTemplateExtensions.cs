using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Portal;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public static class PortletTemplateExtensions
{
	public static MvcHtmlString RenderPortletTemplate(this HtmlHelper htmlHelper, PortalModel portalModel)
	{
		if (portalModel.PortletLayout == null)
		{
			throw new ArgumentException("portalModel.PortletLayout == null");
		}
		return PartialExtensions.Partial(htmlHelper, portalModel.PortletLayout.TemplatePath, (object)portalModel);
	}

	public static MvcHtmlString PortletZone(this HtmlHelper htmlHelper, string zoneName, string tagName, object attributes)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(tagName);
		val.MergeAttributes<string, object>((IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		if (tagName.ToLower() == "div")
		{
			val.AddCssClass("flex-column");
		}
		if (htmlHelper.PortalModel().Edit)
		{
			val.AppendAttributeValue("class", "column");
			val.AppendAttributeValue("class", "portlet-zone-container-edit portlet-zone");
			val.MergeAttribute("zone", zoneName);
		}
		List<PortletViewModel> list = (from i in htmlHelper.PortalModel().ZonePortletViews
			where i.Item1 == zoneName
			orderby i.Item2.Personalization.Order
			select i.Item2).ToList();
		string text = "";
		foreach (PortletViewModel item in list)
		{
			text = ((!htmlHelper.PortalModel().Edit) ? (text + htmlHelper.Portlet(item)) : (text + htmlHelper.EditPortlet(item)));
		}
		val.set_InnerHtml(text);
		return new MvcHtmlString(((object)val).ToString());
	}

	private static PortalModel PortalModel(this HtmlHelper htmlHelper)
	{
		return (PortalModel)htmlHelper.get_ViewData().get_Model();
	}

	public static bool GadgetMode(this HtmlHelper htmlHelper)
	{
		if (((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext().RouteData.Values["gadget"] != null)
		{
			return (bool)((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext().RouteData.Values["gadget"];
		}
		return false;
	}
}
