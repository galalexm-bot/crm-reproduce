using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Content;

[Service(Scope = ServiceScope.Shell, EnableInterceptors = true)]
public class ControllerActionRegistry
{
	public const string ActionsLinktTypeProviderId = "ActionsLinkTypeProvider";

	private readonly IEnumerable<IControllerActionProvider> contentActionProviders;

	private readonly IContextBoundVariableService contextService;

	public ControllerActionRegistry(IEnumerable<IControllerActionProvider> contentActionProviders, IContextBoundVariableService contextService)
	{
		this.contentActionProviders = contentActionProviders;
		this.contextService = contextService;
	}

	public IContentAction Get(string id)
	{
		string name = GetType().FullName + "_AllContentItems";
		contextService.GetOrAdd(name, () => All().ToDictionary((IContentItem c) => c.Id)).TryGetValue(id, out var value);
		return value as IContentAction;
	}

	public IEnumerable<IContentItem> All()
	{
		return contentActionProviders.SelectMany((IControllerActionProvider p) => p.Actions().Cast<IContentItem>()).Union(contentActionProviders.SelectMany((IControllerActionProvider p) => p.Categories()));
	}

	[NotNull]
	public ContentAction Action<TController>(Expression<Action<TController>> expression) where TController : Controller
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		RouteValueDictionary routeValuesFromExpression = ExpressionHelper.GetRouteValuesFromExpression(expression);
		routeValuesFromExpression["area"] = RouteValueDictionaryExtensions.GetAreaName(typeof(TController));
		ContentAction contentAction = (from c in All().OfType<ContentAction>()
			where c.Routes != null
			select c).FirstOrDefault((ContentAction c) => c.Routes.EqualsTo(routeValuesFromExpression));
		if (contentAction == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось найти зарегистрированный ContentAction expression {0} вычисленные routes {1}", ExpressionHelper.GetExpressionText((LambdaExpression)expression), routeValuesFromExpression.AsText()));
		}
		return contentAction;
	}

	[NotNull]
	public ContentAction Action(ActionRoute actionRoute)
	{
		if (actionRoute == null)
		{
			throw new ArgumentNullException("actionRoute");
		}
		ContentAction contentAction = All().OfType<ContentAction>().FirstOrDefault((ContentAction c) => actionRoute.Equals(c.Routes));
		if (contentAction == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось найти зарегистрированный ContentAction по routes {0}", actionRoute));
		}
		return contentAction;
	}
}
