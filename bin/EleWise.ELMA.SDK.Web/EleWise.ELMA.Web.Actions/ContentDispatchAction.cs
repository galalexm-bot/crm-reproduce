using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Actions;

public class ContentDispatchAction : IContentDispatchActionWithScriptMethod, IContentDispatchAction, IContentItem, IAuditEventHolder
{
	public static readonly ContentDispatchAction EmptyAction = new ContentDispatchAction();

	public string Id { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public int Order { get; set; }

	public ActionRoute Routes { get; set; }

	public Func<RequestContext, object[], string> LinkTemplate { get; set; }

	public string ScriptMethodName { get; set; }

	public Func<RequestContext, object[], string> OnClickTemplate { get; set; }

	public Action<HtmlHelper, object[]> OnRenderDelegate { get; set; }

	public bool UseHttpPostMethod { get; set; }

	public string HttpPostFormId { get; set; }

	public IAuditObject Object { get; set; }

	public IAuditAction Action { get; set; }

	public string GetImage(ObjectIconFormat size = ObjectIconFormat.x16)
	{
		return ContentAction.ImageBySizeAccessor(() => Image16, () => Image24, () => Image32, size);
	}

	public string GetHref(RequestContext requestContext, params object[] methodArgs)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (LinkTemplate != null)
		{
			return LinkTemplate(requestContext, methodArgs);
		}
		if (Routes != null)
		{
			return new UrlHelper(requestContext).RouteUrl(new RouteValueDictionary(Routes.Routes)
			{
				["action"] = Routes.Action,
				["controller"] = Routes.Controller
			});
		}
		return null;
	}

	public string GetOnClick(RequestContext requestContext, params object[] methodArgs)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OnClickTemplate != null)
		{
			return OnClickTemplate(requestContext, methodArgs);
		}
		if (Routes != null)
		{
			return new UrlHelper(requestContext).RouteUrl(new RouteValueDictionary(Routes.Routes)
			{
				["action"] = Routes.Action,
				["controller"] = Routes.Controller
			});
		}
		return null;
	}

	public void OnRender(HtmlHelper htmlHelper, params object[] methodArgs)
	{
		if (OnRenderDelegate != null)
		{
			OnRenderDelegate(htmlHelper, methodArgs);
		}
	}
}
