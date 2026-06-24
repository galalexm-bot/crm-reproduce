using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ExpressionUtil;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class DynamicExtensions
{
	public static MvcHtmlString DynamicContent<TController>(this HtmlHelper html, string id, Expression<Action<TController>> action) where TController : Controller
	{
		RouteValueDictionary routeValuesFromExpression = ExpressionHelper.GetRouteValuesFromExpression(action);
		foreach (KeyValuePair<string, object> value in ((ControllerContext)html.get_ViewContext()).get_RouteData().Values)
		{
			if (!routeValuesFromExpression.ContainsKey(value.Key))
			{
				routeValuesFromExpression.Add(value.Key, value.Value);
			}
		}
		string text = (string)routeValuesFromExpression["action"];
		VirtualPathData virtualPathForArea = RouteCollectionExtensions.GetVirtualPathForArea(html.get_RouteCollection(), ((ControllerContext)html.get_ViewContext()).get_RequestContext(), routeValuesFromExpression);
		string text2 = html.Url().Content(virtualPathForArea.VirtualPath);
		html.get_ViewContext().get_Writer().Write("<div id=\"");
		html.get_ViewContext().get_Writer().Write(id);
		html.get_ViewContext().get_Writer().Write("\" dynamicUrl=\"");
		html.get_ViewContext().get_Writer().Write(html.AttributeEncode(text2));
		html.get_ViewContext().get_Writer().Write("\">");
		ChildActionExtensions.RenderAction(html, text, routeValuesFromExpression);
		html.get_ViewContext().get_Writer().Write("</div>");
		return null;
	}
}
