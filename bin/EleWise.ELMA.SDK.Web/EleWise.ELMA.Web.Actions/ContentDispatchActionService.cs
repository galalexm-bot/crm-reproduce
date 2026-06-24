using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Actions;

[Service]
public class ContentDispatchActionService
{
	private IEnumerable<IContentDispatchActionProvider> ContentDispatchActionProviders => Locator.GetServiceNotNull<IEnumerable<IContentDispatchActionProvider>>();

	public IContentDispatchAction GetEventAction([NotNull] IAuditObject auditObject, [NotNull] IAuditAction auditAction)
	{
		if (auditObject == null)
		{
			throw new ArgumentNullException("auditObject");
		}
		if (auditAction == null)
		{
			throw new ArgumentNullException("auditAction");
		}
		DispatchActionBuilder builder = new DispatchActionBuilder();
		return (from a in ContentDispatchActionProviders.SelectMany((IContentDispatchActionProvider p) => p?.GetActions(builder))
			where a != null && a.Object.Uid == auditObject.Uid && a.Action.Uid == auditAction.Uid
			orderby a.Order
			select a).FirstOrDefault() ?? throw new InvalidOperationException("Event not found " + auditObject.Name + ", " + auditAction.Name);
	}

	public string GetHref([NotNull] IAuditObject auditObject, [NotNull] IAuditAction auditAction, [NotNull] RequestContext requestContext, params object[] methodArgs)
	{
		if (requestContext == null)
		{
			throw new ArgumentNullException("requestContext");
		}
		return GetEventAction(auditObject, auditAction).GetHref(requestContext, methodArgs);
	}

	public string GetOnClick([NotNull] IAuditObject auditObject, [NotNull] IAuditAction auditAction, [NotNull] RequestContext requestContext, params object[] methodArgs)
	{
		if (requestContext == null)
		{
			throw new ArgumentNullException("requestContext");
		}
		return GetEventAction(auditObject, auditAction).GetOnClick(requestContext, methodArgs);
	}

	public void OnRender([NotNull] IAuditObject auditObject, [NotNull] IAuditAction auditAction, [NotNull] HtmlHelper html, params object[] methodArgs)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		GetEventAction(auditObject, auditAction).OnRender(html, methodArgs);
	}
}
