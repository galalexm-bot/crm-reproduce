using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Actions;

public class DispatchForActionControllerLinkBuilder<TController> : IDispatchForActionBuilder where TController : Controller
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionControllerLinkBuilder(Expression<Func<Action<TController>>> actionExpression, ContentDispatchAction contentAction)
	{
		ContentAction = contentAction;
		ContentAction.LinkTemplate = delegate(RequestContext r, object[] args)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			UrlHelper url = new UrlHelper(r);
			return (actionExpression.Body is Expression<Action<TController>> action) ? url.Action(action) : null;
		};
	}
}
public class DispatchForActionControllerLinkBuilder<TController, T1> : IDispatchForActionBuilder<T1>, IDispatchForActionBuilder where TController : Controller
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionControllerLinkBuilder([NotNull] Expression<Func<T1, Action<TController>>> actionExpression, [NotNull] ContentDispatchAction contentAction)
	{
		if (actionExpression == null)
		{
			throw new ArgumentNullException("actionExpression");
		}
		if (contentAction == null)
		{
			throw new ArgumentNullException("contentAction");
		}
		ContentAction = contentAction;
		ContentAction.LinkTemplate = delegate(RequestContext r, object[] args)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			UrlHelper url = new UrlHelper(r);
			return (actionExpression.Body is Expression<Action<TController>> action) ? url.Action(action) : null;
		};
	}
}
public class DispatchForActionControllerLinkBuilder<TController, T1, T2> : IDispatchForActionBuilder<T1, T2>, IDispatchForActionBuilder where TController : Controller
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionControllerLinkBuilder(Expression<Func<T1, T2, Action<TController>>> actionExpression, ContentDispatchAction contentAction)
	{
		ContentAction = contentAction;
		ContentAction.LinkTemplate = delegate(RequestContext r, object[] args)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			UrlHelper url = new UrlHelper(r);
			return (actionExpression.Body is Expression<Action<TController>> action) ? url.Action(action) : null;
		};
	}
}
