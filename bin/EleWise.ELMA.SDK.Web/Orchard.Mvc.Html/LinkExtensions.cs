using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Orchard.Mvc.Html;

public static class LinkExtensions
{
	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName)
	{
		return htmlHelper.ActionLink(linkText, actionName, null, new RouteValueDictionary(), new RouteValueDictionary());
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, object routeValues)
	{
		return htmlHelper.ActionLink(linkText, actionName, null, ObjectToDictionary(routeValues), new RouteValueDictionary());
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, object routeValues, object htmlAttributes)
	{
		return htmlHelper.ActionLink(linkText, actionName, null, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, RouteValueDictionary routeValues)
	{
		return htmlHelper.ActionLink(linkText, actionName, null, routeValues, new RouteValueDictionary());
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return htmlHelper.ActionLink(linkText, actionName, null, routeValues, htmlAttributes);
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, string controllerName)
	{
		return htmlHelper.ActionLink(linkText, actionName, controllerName, new RouteValueDictionary(), new RouteValueDictionary());
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, string controllerName, object routeValues, object htmlAttributes)
	{
		return htmlHelper.ActionLink(linkText, actionName, controllerName, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		if (string.IsNullOrEmpty(linkText.ToString()))
		{
			throw new ArgumentException("Argument must be a non empty string", "linkText");
		}
		return MvcHtmlString.Create(GenerateLink(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), htmlHelper.get_RouteCollection(), linkText, null, actionName, controllerName, routeValues, htmlAttributes));
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
	{
		return htmlHelper.ActionLink(linkText, actionName, controllerName, protocol, hostName, fragment, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, IHtmlString linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		if (string.IsNullOrEmpty(linkText.ToString()))
		{
			throw new ArgumentException("Argument must be a non empty string", "linkText");
		}
		return MvcHtmlString.Create(GenerateLink(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), htmlHelper.get_RouteCollection(), linkText, null, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, object routeValues)
	{
		return htmlHelper.RouteLink(linkText, ObjectToDictionary(routeValues));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, RouteValueDictionary routeValues)
	{
		return htmlHelper.RouteLink(linkText, routeValues, new RouteValueDictionary());
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName)
	{
		return htmlHelper.RouteLink(linkText, routeName, (object)null);
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, object routeValues)
	{
		return htmlHelper.RouteLink(linkText, routeName, ObjectToDictionary(routeValues));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, RouteValueDictionary routeValues)
	{
		return htmlHelper.RouteLink(linkText, routeName, routeValues, new RouteValueDictionary());
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, object routeValues, object htmlAttributes)
	{
		return htmlHelper.RouteLink(linkText, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return htmlHelper.RouteLink(linkText, null, routeValues, htmlAttributes);
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, object routeValues, object htmlAttributes)
	{
		return htmlHelper.RouteLink(linkText, routeName, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		if (string.IsNullOrEmpty(linkText.ToString()))
		{
			throw new ArgumentException("Argument must be a non empty string", "linkText");
		}
		return MvcHtmlString.Create(GenerateRouteLink(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), htmlHelper.get_RouteCollection(), linkText, routeName, routeValues, htmlAttributes));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
	{
		return htmlHelper.RouteLink(linkText, routeName, protocol, hostName, fragment, ObjectToDictionary(routeValues), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString RouteLink(this HtmlHelper htmlHelper, IHtmlString linkText, string routeName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		if (string.IsNullOrEmpty(linkText.ToString()))
		{
			throw new ArgumentException("Argument must be a non empty string", "linkText");
		}
		return MvcHtmlString.Create(GenerateRouteLink(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), htmlHelper.get_RouteCollection(), linkText, routeName, protocol, hostName, fragment, routeValues, htmlAttributes));
	}

	public static string GenerateLink(RequestContext requestContext, RouteCollection routeCollection, IHtmlString linkText, string routeName, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return GenerateLink(requestContext, routeCollection, linkText, routeName, actionName, controllerName, null, null, null, routeValues, htmlAttributes);
	}

	public static string GenerateLink(RequestContext requestContext, RouteCollection routeCollection, IHtmlString linkText, string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return GenerateLinkInternal(requestContext, routeCollection, linkText, routeName, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes, includeImplicitMvcValues: true);
	}

	public static string GenerateRouteLink(RequestContext requestContext, RouteCollection routeCollection, IHtmlString linkText, string routeName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return GenerateRouteLink(requestContext, routeCollection, linkText, routeName, null, null, null, routeValues, htmlAttributes);
	}

	public static string GenerateRouteLink(RequestContext requestContext, RouteCollection routeCollection, IHtmlString linkText, string routeName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
	{
		return GenerateLinkInternal(requestContext, routeCollection, linkText, routeName, null, null, protocol, hostName, fragment, routeValues, htmlAttributes, includeImplicitMvcValues: false);
	}

	private static string GenerateLinkInternal(RequestContext requestContext, RouteCollection routeCollection, IHtmlString linkText, string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes, bool includeImplicitMvcValues)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		string text = UrlHelper.GenerateUrl(routeName, actionName, controllerName, protocol, hostName, fragment, routeValues, routeCollection, requestContext, includeImplicitMvcValues);
		TagBuilder val = new TagBuilder("a");
		val.set_InnerHtml(linkText.ToString());
		val.MergeAttributes<string, object>(htmlAttributes);
		val.MergeAttribute("href", text);
		return val.ToString((TagRenderMode)0);
	}

	private static RouteValueDictionary ObjectToDictionary(object value)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		if (value != null)
		{
			PropertyInfo[] reflectionProperties = value.GetType().GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public);
			foreach (PropertyInfo propertyInfo in reflectionProperties)
			{
				routeValueDictionary.Add(propertyInfo.Name, propertyInfo.GetValue(value));
			}
		}
		return routeValueDictionary;
	}
}
