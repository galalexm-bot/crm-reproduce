using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[Component]
public class ProfileActionProvider : IProfileActionProviderPoint
{
	private class ActionData
	{
		public ProfileActionAttribute Attr { get; set; }

		public string Action { get; set; }

		public string Controller { get; set; }

		public string Area { get; set; }

		public Func<RequestContext, bool> IsAvalilableDelegate { get; set; }
	}

	private const string ProfileActionsCacheKey = "EleWise.ELMA.BPM.Web.Security.ExtensionPoints.ProfileActionProvider.GetProfileActions";

	private LazyWithReset<IEnumerable<ActionData>> actionItems;

	private readonly IContentActionUtilsService contentActionUtilsService;

	private readonly IMemoryCacheService cacheService;

	[Obsolete("Не использовать", true)]
	public ProfileActionProvider(IComponentManager componentManager, ControllerContentActionProvider controllerContentActionProvider)
		: this(Locator.GetServiceNotNull<IContentActionUtilsService>())
	{
	}

	public ProfileActionProvider(IContentActionUtilsService contentActionUtilsService)
	{
		this.contentActionUtilsService = contentActionUtilsService;
		actionItems = new LazyWithReset<IEnumerable<ActionData>>(EvaluteActions);
		cacheService = Locator.GetServiceNotNull<IMemoryCacheService>();
	}

	private IEnumerable<ActionData> EvaluteActions()
	{
		IEnumerable<Type> baseControllerTypes = contentActionUtilsService.GetBaseControllerTypes();
		foreach (Type controller in baseControllerTypes)
		{
			string areaName = "";
			object obj = controller.GetCustomAttributes(typeof(RouteAreaAttribute), inherit: false).FirstOrDefault();
			if (obj != null)
			{
				areaName = ((RouteAreaAttribute)obj).get_AreaName();
			}
			MethodInfo[] methods = controller.GetMethods();
			MethodInfo[] array = methods;
			foreach (MethodInfo method in array)
			{
				object[] customAttributes = method.GetCustomAttributes(typeof(ProfileActionAttribute), inherit: false);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					ProfileActionAttribute attr = (ProfileActionAttribute)customAttributes[j];
					yield return new ActionData
					{
						Attr = attr,
						Area = areaName,
						Controller = controller.Name.Replace("Controller", ""),
						Action = method.Name,
						IsAvalilableDelegate = contentActionUtilsService.PermissionDelegate(method)
					};
				}
			}
		}
	}

	public IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, IUser user)
	{
		return from d in cacheService.GetOrAdd("EleWise.ELMA.BPM.Web.Security.ExtensionPoints.ProfileActionProvider.GetProfileActions", () => actionItems.Value.ToList())
			where d.IsAvalilableDelegate == null || d.IsAvalilableDelegate(((ControllerContext)html.get_ViewContext()).get_RequestContext())
			select new SimpleProfileAction
			{
				ImageUrl = d.Attr.Image,
				ActionUrl = html.Url().Action(d.Action, d.Controller, new RouteValueDictionary
				{
					{ "area", d.Area },
					{
						d.Attr.UserIdParameterName,
						user.Id
					}
				}) + (string.IsNullOrWhiteSpace(d.Attr.QueryParameters) ? "" : ((d.Attr.QueryParameters.TrimStart().StartsWith("&") ? "" : "&") + d.Attr.QueryParameters.TrimStart())),
				Caption = SR.T(d.Attr.Name),
				Order = d.Attr.Order
			};
	}
}
