using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Actions;

public static class DispatchActionBuilderExtension
{
	public static DispatchForActionBuilder<TManager> ForAction<TManager>(this DispatchActionBuilder builder, Func<TManager, Action> expression) where TManager : IEntityManager
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		TManager serviceNotNull = Locator.GetServiceNotNull<TManager>();
		Action action = expression(serviceNotNull);
		if (action == null || action.Method == null)
		{
			throw new ArgumentException(SR.T("Параметр должен быть вызовом метода"), "expression");
		}
		return new DispatchForActionBuilder<TManager>(action.Method, new ContentDispatchAction());
	}

	public static DispatchForActionPropertiesBuilder MapHrefRoute(this IDispatchForActionBuilder builder, Func<ActionRoute> getRoute)
	{
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.LinkTemplate = delegate(RequestContext r, object[] args)
			{
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				ActionRoute actionRoute = getRoute();
				UrlHelper val = new UrlHelper(r);
				RouteValueDictionary routeValueDictionary = actionRoute.CreateRoutes();
				return val.RouteUrl(routeValueDictionary);
			};
		});
	}

	public static DispatchForActionRenderBuilder OnRender(this IDispatchForActionBuilder builder, Action<HtmlHelper> renderAction)
	{
		return new DispatchForActionRenderBuilder(renderAction, builder.ContentAction);
	}

	public static DispatchForActionBuilder<TManager, T1> ForAction<TManager, T1>([NotNull] this DispatchActionBuilder builder, [NotNull] Func<TManager, Action<T1>> expression) where TManager : IEntityManager
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		TManager serviceNotNull = Locator.GetServiceNotNull<TManager>();
		Action<T1> action = expression(serviceNotNull);
		if (action == null || action.Method == null)
		{
			throw new ArgumentException(SR.T("Параметр должен быть вызовом метода"), "expression");
		}
		return new DispatchForActionBuilder<TManager, T1>(action.Method, new ContentDispatchAction());
	}

	public static DispatchForActionPropertiesBuilder<T1> MapHrefRoute<T1>([NotNull] this IDispatchForActionBuilder<T1> builder, [NotNull] Func<T1, ActionRoute> getRoute)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (getRoute == null)
		{
			throw new ArgumentNullException("getRoute");
		}
		return new DispatchForActionPropertiesBuilder<T1>(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.LinkTemplate = delegate(RequestContext r, object[] args)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Expected O, but got Unknown
				ActionRoute actionRoute = getRoute((T1)args[0]);
				UrlHelper val = new UrlHelper(r);
				RouteValueDictionary routeValueDictionary = actionRoute.CreateRoutes();
				string text = val.RouteUrl(routeValueDictionary);
				return c.UseHttpPostMethod ? $"javascript:void(document.getElementById(\"{c.HttpPostFormId}\").submit());" : text;
			};
		});
	}

	[NotNull]
	public static DispatchForActionPropertiesBuilder<T1> MapOnClickRoute<T1>([NotNull] this IDispatchForActionBuilder<T1> builder, [NotNull] Func<T1, ActionRoute> getRoute)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (getRoute == null)
		{
			throw new ArgumentNullException("getRoute");
		}
		return new DispatchForActionPropertiesBuilder<T1>(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.OnClickTemplate = delegate(RequestContext r, object[] args)
			{
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Expected O, but got Unknown
				ActionRoute actionRoute = getRoute((T1)args[0]);
				UrlHelper val = new UrlHelper(r);
				RouteValueDictionary routeValueDictionary = actionRoute.CreateRoutes();
				string str = val.RouteUrl(routeValueDictionary);
				return c.UseHttpPostMethod ? $"document.getElementById(\"{c.HttpPostFormId}\").submit();" : $"window.replaceUrl(\"{HttpUtility.UrlEncode(str)}\");";
			};
		});
	}

	public static DispatchForActionRenderBuilder<T1> OnRender<T1>(this IDispatchForActionBuilder<T1> builder, Action<HtmlHelper, T1> renderAction)
	{
		return new DispatchForActionRenderBuilder<T1>(renderAction, builder.ContentAction);
	}

	public static DispatchForActionBuilder<TManager, T1, T2> ForAction<TManager, T1, T2>(this DispatchActionBuilder builder, Func<TManager, Action<T1, T2>> expression) where TManager : IEntityManager
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		TManager serviceNotNull = Locator.GetServiceNotNull<TManager>();
		Action<T1, T2> action = expression(serviceNotNull);
		if (action == null || action.Method == null)
		{
			throw new ArgumentException(SR.T("Параметр должен быть вызовом метода"), "expression");
		}
		return new DispatchForActionBuilder<TManager, T1, T2>(action.Method, new ContentDispatchAction());
	}

	public static DispatchForActionPropertiesBuilder MapHrefRoute<T1, T2>(this IDispatchForActionBuilder<T1, T2> builder, Func<T1, T2, ActionRoute> getRoute)
	{
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.LinkTemplate = delegate(RequestContext r, object[] args)
			{
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				ActionRoute actionRoute = getRoute((T1)args[0], (T2)args[1]);
				UrlHelper val = new UrlHelper(r);
				RouteValueDictionary routeValueDictionary = actionRoute.CreateRoutes();
				return val.RouteUrl(routeValueDictionary);
			};
		});
	}

	public static DispatchForActionRenderBuilder<T1, T2> OnRender<T1, T2>(this IDispatchForActionBuilder<T1, T2> builder, Action<HtmlHelper, T1, T2> renderAction)
	{
		return new DispatchForActionRenderBuilder<T1, T2>(renderAction, builder.ContentAction);
	}

	public static DispatchForActionPropertiesBuilder Name([NotNull] this IDispatchForActionBuilder builder, string actionName)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.Name = actionName;
		});
	}

	public static DispatchForActionPropertiesBuilder Description([NotNull] this IDispatchForActionBuilder builder, string description)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.Description = description;
		});
	}

	public static DispatchForActionPropertiesBuilder UsePost([NotNull] this IDispatchForActionBuilder builder, string httpPostFormId = null, bool usePostMethod = true)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.UseHttpPostMethod = usePostMethod;
			c.HttpPostFormId = httpPostFormId;
		});
	}

	public static DispatchForActionPropertiesBuilder ScriptMethodName([NotNull] this IDispatchForActionBuilder builder, string scriptMethodName)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return new DispatchForActionPropertiesBuilder(builder.ContentAction, delegate(ContentDispatchAction c)
		{
			c.ScriptMethodName = scriptMethodName;
		});
	}
}
