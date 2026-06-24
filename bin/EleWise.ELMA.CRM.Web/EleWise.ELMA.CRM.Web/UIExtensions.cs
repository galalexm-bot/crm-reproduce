using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.CRM.Web;

public static class UIExtensions
{
	public static string EntityAction<AttributeType>(this UrlHelper url, Guid entityTypeUid)
	{
		AttributeType attr;
		return url.EntityAction<AttributeType>(entityTypeUid, out attr, null);
	}

	public static string EntityAction<AttributeType>(this UrlHelper url, Guid entityTypeUid, out AttributeType attr)
	{
		return url.EntityAction<AttributeType>(entityTypeUid, out attr, null);
	}

	public static string EntityAction<AttributeType>(this UrlHelper url, Guid entityTypeUid, out AttributeType attr, object routeValues)
	{
		return url.EntityAction<AttributeType>(entityTypeUid, out attr, new RouteValueDictionary(routeValues));
	}

	public static string EntityAction<AttributeType>(this UrlHelper url, Guid entityTypeUid, out AttributeType attr, RouteValueDictionary routeValues)
	{
		string actionName = "";
		string controllerName = "";
		string areaName = "";
		SearchAction<AttributeType>(entityTypeUid, out actionName, out controllerName, out areaName, out attr);
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		if (!string.IsNullOrEmpty(areaName))
		{
			routeValueDictionary.Add("area", areaName);
		}
		if (routeValues != null)
		{
			foreach (KeyValuePair<string, object> routeValue in routeValues)
			{
				routeValueDictionary.Add(routeValue.Key, routeValue.Value);
			}
		}
		return url.Action(actionName, controllerName.Replace("Controller", ""), routeValueDictionary);
	}

	internal static void SearchAction<AttributeType>(Guid entityTypeUid, out string actionName, out string controllerName, out string areaName, out AttributeType attr)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		actionName = "";
		controllerName = "";
		areaName = "";
		attr = default(AttributeType);
		Type typeFromHandle = typeof(IBaseController<, >);
		foreach (Type extensionPointType in ComponentManager.Current.GetExtensionPointTypes(typeFromHandle))
		{
			Type @interface = extensionPointType.GetInterface(typeFromHandle.FullName);
			if (!(@interface != null) || !@interface.IsGenericType || @interface.IsGenericTypeDefinition || !(@interface.GetGenericTypeDefinition() == typeFromHandle))
			{
				continue;
			}
			Guid guid = InterfaceActivator.UID(@interface.GetGenericArguments()[0]);
			if (!(entityTypeUid == guid))
			{
				continue;
			}
			object obj = extensionPointType.GetCustomAttributes(typeof(RouteAreaAttribute), inherit: false).FirstOrDefault();
			if (obj != null)
			{
				areaName = ((RouteAreaAttribute)obj).get_AreaName();
			}
			MethodInfo[] methods = extensionPointType.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				attr = (AttributeType)methodInfo.GetCustomAttributes(typeof(AttributeType), inherit: false).FirstOrDefault();
				if (attr != null)
				{
					actionName = methodInfo.Name;
					controllerName = extensionPointType.Name;
					break;
				}
			}
		}
	}

	public static ToolbarButtonsBuilder ToolbarCreateRelationships(this ToolbarButtonsBuilder builder, object routeValues)
	{
		return CreateRelationshipsLinks(builder, new RouteValueDictionary(routeValues), builder.HtmlHelper, all: false, delegate(ToolbarButtonsBuilder b, ClassMetadata md, RelationshipCreateAttribute attr, string createUrl)
		{
			b.Link(createUrl).Text(SR.T(md.DisplayName)).ToolTip(SR.T(md.DisplayName))
				.IconUrl(attr.ImageUrl)
				.Uid($"toolbar-action-Create{md.Name}");
			return builder;
		});
	}

	public static ToolbarGroupBuilder ToolbarCreateRelationships(this ToolbarGroupBuilder builder, object routeValues)
	{
		return builder.ToolbarCreateRelationships(new RouteValueDictionary(routeValues));
	}

	public static ToolbarGroupBuilder ToolbarCreateRelationships(this ToolbarGroupBuilder builder, RouteValueDictionary routeValues, bool all = false)
	{
		return CreateRelationshipsLinks(builder, routeValues, builder.HtmlHelper, all, (ToolbarGroupBuilder b, ClassMetadata md, RelationshipCreateAttribute attr, string createUrl) => b.ToolbarLink(SR.T(md.DisplayName), SR.T(md.DisplayName), attr.ImageUrl, createUrl, $"toolbar-action-Create{md.Name}"));
	}

	private static T CreateRelationshipsLinks<T>(T builder, RouteValueDictionary routeValues, HtmlHelper htmlHelper, bool all, Func<T, ClassMetadata, RelationshipCreateAttribute, string, T> func)
	{
		foreach (ClassMetadata item in (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == InterfaceActivator.UID<IRelationship>()
			select m).Cast<ClassMetadata>())
		{
			RelationshipCreateAttribute attr;
			string arg = htmlHelper.Url().EntityAction<RelationshipCreateAttribute>(item.Uid, out attr, routeValues);
			if (attr != null && (!attr.ToActions || all))
			{
				builder = func(builder, item, attr, arg);
			}
		}
		return builder;
	}

	public static List<IActionItem> ToolbarCreateRelationshipsToActionsList(HtmlHelper htmlHelper, object routeValues, bool all = false)
	{
		List<IActionItem> list = new List<IActionItem>();
		foreach (ClassMetadata item in (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == InterfaceActivator.UID<IRelationship>()
			select m).Cast<ClassMetadata>())
		{
			RelationshipCreateAttribute attr;
			string url = htmlHelper.Url().EntityAction<RelationshipCreateAttribute>(item.Uid, out attr, new RouteValueDictionary(routeValues));
			if (attr != null && (attr.ToActions || all))
			{
				list.Add(new ActionToolbarItem
				{
					Uid = "toolbar-button-" + item.Uid,
					Text = SR.T(attr.Name),
					IconUrl = (string.IsNullOrWhiteSpace(attr.SmallImageUrl) ? attr.ImageUrl : attr.SmallImageUrl),
					Url = url
				});
			}
		}
		return list;
	}
}
