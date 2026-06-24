using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using Orchard.ContentManagement;
using Orchard.Utility.Extensions;

namespace Orchard.Mvc.Html;

public static class ContentItemExtensions
{
	public static MvcHtmlString ItemDisplayText(this HtmlHelper html, IContent content)
	{
		return html.ItemDisplayText(content, encode: true);
	}

	public static MvcHtmlString ItemDisplayText(this HtmlHelper html, IContent content, bool encode)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.DisplayText == null)
		{
			return null;
		}
		if (encode)
		{
			return MvcHtmlString.Create(html.Encode(itemMetadata.DisplayText));
		}
		return MvcHtmlString.Create(itemMetadata.DisplayText);
	}

	public static MvcHtmlString ItemDisplayLink(this HtmlHelper html, IContent content)
	{
		return html.ItemDisplayLink(null, content, null);
	}

	public static MvcHtmlString ItemDisplayLink(this HtmlHelper html, IContent content, object htmlAttributes)
	{
		return html.ItemDisplayLink(null, content, htmlAttributes);
	}

	public static MvcHtmlString ItemDisplayLink(this HtmlHelper html, string linkText, IContent content)
	{
		return html.ItemDisplayLink(linkText, content, null);
	}

	public static MvcHtmlString ItemDisplayLink(this HtmlHelper html, string linkText, IContent content, object htmlAttributes = null)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.DisplayRouteValues == null)
		{
			return null;
		}
		return LinkExtensions.ActionLink(html, NonNullOrEmpty(linkText, itemMetadata.DisplayText, "view"), Convert.ToString(itemMetadata.DisplayRouteValues["action"]), itemMetadata.DisplayRouteValues, (IDictionary<string, object>)new RouteValueDictionary(htmlAttributes));
	}

	public static string ItemDisplayUrl(this UrlHelper urlHelper, IContent content)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.DisplayRouteValues == null)
		{
			return null;
		}
		return urlHelper.Action(Convert.ToString(itemMetadata.DisplayRouteValues["action"]), itemMetadata.DisplayRouteValues);
	}

	public static MvcHtmlString ItemRemoveLink(this HtmlHelper html, IContent content)
	{
		return html.ItemRemoveLink(null, content, null);
	}

	public static MvcHtmlString ItemRemoveLink(this HtmlHelper html, string linkText, IContent content, object additionalRouteValues)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.RemoveRouteValues == null)
		{
			return null;
		}
		return LinkExtensions.ActionLink(html, NonNullOrEmpty(linkText, itemMetadata.DisplayText, "remove"), Convert.ToString(itemMetadata.RemoveRouteValues["action"]), itemMetadata.RemoveRouteValues.Merge(additionalRouteValues));
	}

	public static string ItemRemoveUrl(this UrlHelper urlHelper, IContent content, object additionalRouteValues)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.RemoveRouteValues == null)
		{
			return null;
		}
		return urlHelper.Action(Convert.ToString(itemMetadata.RemoveRouteValues["action"]), itemMetadata.RemoveRouteValues.Merge(additionalRouteValues));
	}

	public static MvcHtmlString ItemEditLinkWithReturnUrl(this HtmlHelper html, string linkText, IContent content)
	{
		return html.ItemEditLink(linkText, content, new
		{
			ReturnUrl = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.RawUrl
		});
	}

	public static MvcHtmlString ItemEditLink(this HtmlHelper html, string linkText, IContent content)
	{
		return html.ItemEditLink(linkText, content, null);
	}

	public static MvcHtmlString ItemEditLink(this HtmlHelper html, string linkText, IContent content, object additionalRouteValues)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.EditorRouteValues == null)
		{
			return null;
		}
		return LinkExtensions.ActionLink(html, NonNullOrEmpty(linkText, itemMetadata.DisplayText, content.ContentItem.TypeDefinition.DisplayName), Convert.ToString(itemMetadata.EditorRouteValues["action"]), itemMetadata.EditorRouteValues.Merge(additionalRouteValues));
	}

	public static MvcHtmlString ItemEditLink(this HtmlHelper html, string linkText, IContent content, object additionalRouteValues, object htmlAttributes = null)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.EditorRouteValues == null)
		{
			return null;
		}
		return LinkExtensions.ActionLink(html, NonNullOrEmpty(linkText, itemMetadata.DisplayText, content.ContentItem.TypeDefinition.DisplayName), Convert.ToString(itemMetadata.EditorRouteValues["action"]), itemMetadata.EditorRouteValues.Merge(additionalRouteValues), (IDictionary<string, object>)new RouteValueDictionary(htmlAttributes));
	}

	public static MvcHtmlString ItemAdminLink(this HtmlHelper html, IContent content)
	{
		return html.ItemAdminLink(null, content);
	}

	public static MvcHtmlString ItemAdminLink(this HtmlHelper html, string linkText, IContent content)
	{
		return html.ItemAdminLink(linkText, content, null);
	}

	public static MvcHtmlString ItemAdminLink(this HtmlHelper html, string linkText, IContent content, object additionalRouteValues)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.AdminRouteValues == null)
		{
			return null;
		}
		return LinkExtensions.ActionLink(html, NonNullOrEmpty(linkText, itemMetadata.DisplayText, content.ContentItem.TypeDefinition.DisplayName), Convert.ToString(itemMetadata.AdminRouteValues["action"]), itemMetadata.AdminRouteValues.Merge(additionalRouteValues));
	}

	public static string ItemEditUrl(this UrlHelper urlHelper, IContent content, object additionalRouteValues = null)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.EditorRouteValues == null)
		{
			return null;
		}
		return urlHelper.Action(Convert.ToString(itemMetadata.EditorRouteValues["action"]), itemMetadata.EditorRouteValues.Merge(additionalRouteValues ?? new { }));
	}

	public static string ItemAdminUrl(this UrlHelper urlHelper, IContent content, object additionalRouteValues = null)
	{
		ContentItemMetadata itemMetadata = content.ContentItem.ContentManager.GetItemMetadata(content);
		if (itemMetadata.AdminRouteValues != null)
		{
			return urlHelper.RouteUrl(itemMetadata.AdminRouteValues.Merge(additionalRouteValues ?? new { }));
		}
		return null;
	}

	private static string NonNullOrEmpty(params string[] values)
	{
		foreach (string text in values)
		{
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return null;
	}

	public static MvcHtmlString ItemEditLink(this HtmlHelper html, IContent content)
	{
		return html.ItemEditLink(null, content);
	}
}
