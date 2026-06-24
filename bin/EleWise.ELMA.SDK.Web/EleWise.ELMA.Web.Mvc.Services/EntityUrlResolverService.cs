using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service(EnableInterceptors = false, Type = ComponentType.Web)]
public class EntityUrlResolverService
{
	private class EntityActionCacheEntry
	{
		public string Action { get; set; }

		public string Controller { get; set; }

		public string Area { get; set; }

		public string Parameter { get; set; }

		public Guid TypeUid { get; set; }

		private bool Equals(EntityActionCacheEntry other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (((other.Action == null && Action == null) || (other.Action != null && other.Action.Equals(Action, StringComparison.OrdinalIgnoreCase))) && ((other.Controller == null && Controller == null) || (other.Controller != null && other.Controller.Equals(Controller, StringComparison.OrdinalIgnoreCase))) && ((other.Area == null && Area == null) || (other.Area != null && other.Area.Equals(Area, StringComparison.OrdinalIgnoreCase))) && ((other.Parameter == null && Parameter == null) || (other.Parameter != null && other.Parameter.Equals(Parameter, StringComparison.OrdinalIgnoreCase))))
			{
				return other.TypeUid == TypeUid;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (obj.GetType() != typeof(EntityActionCacheEntry))
			{
				return false;
			}
			return Equals((EntityActionCacheEntry)obj);
		}

		public override int GetHashCode()
		{
			return (((Action != null) ? Action.GetHashCode() : typeof(string).GetHashCode()) * 333) ^ (((Controller != null) ? Controller.GetHashCode() : typeof(string).GetHashCode()) * 213) ^ (((Area != null) ? Area.GetHashCode() : typeof(string).GetHashCode()) * 122) ^ (((Parameter != null) ? Parameter.GetHashCode() : typeof(string).GetHashCode()) * 99) ^ (TypeUid.GetHashCode() * 45);
		}

		public override string ToString()
		{
			return $"{Area}/{Controller}/{Action}/{TypeUid}";
		}
	}

	private class EntityUrlCacheEntry
	{
		public IEntityManager Manager { get; set; }

		public IEntityLink EntityLink { get; set; }
	}

	private const string EntityUrlCacheKey = "EntityUrlResolverService.EntityUrlCacheKey";

	private IMemoryCacheService _memoryCacheService;

	private Dictionary<Type, string> _entityListCache = new Dictionary<Type, string>();

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	private IMemoryCacheService MemoryCacheService
	{
		get
		{
			if (_memoryCacheService == null)
			{
				_memoryCacheService = Locator.GetServiceNotNull<IMemoryCacheService>();
			}
			return _memoryCacheService;
		}
	}

	public string Entity(UrlHelper url, IEntity entity)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		string actionName = "";
		string controllerName = "";
		string areaName = "";
		string parameter = "";
		string href = "";
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		SearchActionFromExtensions(url, entity, subclass: false, routeValueDictionary, out actionName, out controllerName, out areaName, out parameter, out href);
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchAction(entity, subclass: false, out actionName, out controllerName, out areaName, out parameter);
		}
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchActionFromExtensions(url, entity, subclass: true, routeValueDictionary, out actionName, out controllerName, out areaName, out parameter, out href);
		}
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchAction(entity, subclass: true, out actionName, out controllerName, out areaName, out parameter);
		}
		if (!string.IsNullOrEmpty(href))
		{
			return href;
		}
		if (string.IsNullOrEmpty(controllerName) && string.IsNullOrEmpty(actionName))
		{
			return string.Empty;
		}
		RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary();
		if (!string.IsNullOrEmpty(areaName))
		{
			routeValueDictionary2.Add("area", areaName);
		}
		if (!string.IsNullOrEmpty(parameter))
		{
			object value = entity.GetType().GetProperty("Id").GetValue(entity, null);
			routeValueDictionary2.Add(parameter, value);
		}
		if (routeValueDictionary.Count > 0)
		{
			foreach (KeyValuePair<string, object> item in routeValueDictionary)
			{
				if (!routeValueDictionary2.ContainsKey(item.Key))
				{
					routeValueDictionary2.Add(item.Key, item.Value);
				}
			}
		}
		return url.Action(actionName, controllerName.Replace("Controller", ""), routeValueDictionary2);
	}

	public string Entity(UrlHelper url, Guid typeUid, string id)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		string actionName = "";
		string controllerName = "";
		string areaName = "";
		string parameter = "";
		string href = "";
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		if (!long.TryParse(id, out var result))
		{
			return null;
		}
		SearchActionFromExtensions(url, typeUid, result, subclass: false, routeValueDictionary, out actionName, out controllerName, out areaName, out parameter, out href);
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchAction(typeUid, subclass: false, out actionName, out controllerName, out areaName, out parameter);
		}
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchActionFromExtensions(url, typeUid, result, subclass: true, routeValueDictionary, out actionName, out controllerName, out areaName, out parameter, out href);
		}
		if (string.IsNullOrEmpty(actionName) && string.IsNullOrEmpty(href))
		{
			SearchAction(typeUid, subclass: true, out actionName, out controllerName, out areaName, out parameter);
		}
		RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary();
		if (!string.IsNullOrEmpty(areaName))
		{
			routeValueDictionary2.Add("area", areaName);
		}
		if (!string.IsNullOrEmpty(parameter))
		{
			routeValueDictionary2.Add(parameter, id);
		}
		if (routeValueDictionary.Count > 0)
		{
			foreach (KeyValuePair<string, object> item in routeValueDictionary)
			{
				if (!routeValueDictionary2.ContainsKey(item.Key))
				{
					routeValueDictionary2.Add(item.Key, item.Value);
				}
			}
		}
		if (!string.IsNullOrEmpty(href))
		{
			return href;
		}
		if (string.IsNullOrEmpty(controllerName) && string.IsNullOrEmpty(actionName))
		{
			return string.Empty;
		}
		return url.Action(actionName, controllerName.Replace("Controller", ""), routeValueDictionary2);
	}

	public string EntityList(UrlHelper url, Type entityType)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		if (_entityListCache.TryGetValue(entityType, out var value))
		{
			return value;
		}
		lock (_entityListCache)
		{
			string text = "";
			string text2 = "";
			string value2 = "";
			Type typeFromHandle = typeof(IBaseController);
			foreach (Type extensionPointType in ComponentManager.Current.GetExtensionPointTypes(typeFromHandle))
			{
				MethodInfo[] methods = extensionPointType.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					object obj = extensionPointType.GetCustomAttributes(typeof(RouteAreaAttribute), inherit: false).FirstOrDefault();
					if (obj != null)
					{
						value2 = ((RouteAreaAttribute)obj).get_AreaName();
					}
					EntityListLinkAttribute entityListLinkAttribute = (EntityListLinkAttribute)methodInfo.GetCustomAttributes(typeof(EntityListLinkAttribute), inherit: false).FirstOrDefault();
					if (entityListLinkAttribute != null && !(entityListLinkAttribute.EntityType != entityType))
					{
						text = methodInfo.Name;
						text2 = extensionPointType.Name;
						break;
					}
				}
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					break;
				}
			}
			RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
			if (!string.IsNullOrEmpty(value2))
			{
				routeValueDictionary.Add("area", value2);
			}
			if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
			{
				value = url.Action(text, text2.Replace("Controller", ""), routeValueDictionary);
				_entityListCache[entityType] = value;
				return value;
			}
			_entityListCache[entityType] = null;
			return null;
		}
	}

	private RouteData GetRouteDataFromUrl(string url)
	{
		HttpRequest request;
		return GetRouteDataFromUrl(url, out request);
	}

	private RouteData GetRouteDataFromUrl(string url, out HttpRequest request)
	{
		string queryString = "";
		string[] array = url.Split(new string[1] { "?" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length > 1)
		{
			queryString = array[1];
		}
		request = new HttpRequest(null, url, queryString);
		HttpResponse response = new HttpResponse(new StringWriter());
		HttpContext httpContext = new HttpContext(request, response);
		return RouteTable.Routes.GetRouteData(new HttpContextWrapper(httpContext));
	}

	public static string ToAbsoluteUrl(string relativeUrl)
	{
		if (string.IsNullOrEmpty(relativeUrl))
		{
			return relativeUrl;
		}
		if (HttpContext.Current == null)
		{
			return relativeUrl;
		}
		if (relativeUrl.StartsWith("/"))
		{
			relativeUrl = relativeUrl.Insert(0, "~");
		}
		if (!relativeUrl.StartsWith("~/"))
		{
			relativeUrl = relativeUrl.Insert(0, "~/");
		}
		Uri url = HttpContext.Current.Request.Url;
		string text = ((url.Port != 80) ? (":" + url.Port) : string.Empty);
		return $"{url.Scheme}://{url.Host}{text}{VirtualPathUtility.ToAbsolute(relativeUrl)}";
	}

	public IEntity ParseEntityUrl(string url, Guid typeUid, out IEntityMetadata metadata)
	{
		metadata = null;
		if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out var _))
		{
			return null;
		}
		try
		{
			HttpRequest request;
			RouteData routeData = GetRouteDataFromUrl(url, out request);
			RouteValueDictionary values = routeData.Values;
			string controller = (string)values["controller"];
			string action = (string)values["action"];
			string area = (string)values["area"];
			EntityActionCacheEntry arg = new EntityActionCacheEntry
			{
				Action = action,
				Controller = controller,
				Area = area,
				TypeUid = typeUid
			};
			long id = 0L;
			if (values.ContainsKey("id") && values["id"] != null && !string.IsNullOrEmpty(values["id"].ToString()))
			{
				id = Convert.ToInt64(values["id"]);
			}
			string key = string.Format("{0}:{1}", "EntityUrlResolverService.EntityUrlCacheKey", arg);
			metadata = (IEntityMetadata)MetadataLoader.LoadMetadata(typeUid);
			List<Guid> checkUids = new List<Guid> { typeUid };
			if (metadata is EntityMetadata)
			{
				checkUids = new List<Guid>
				{
					metadata.Uid,
					((EntityMetadata)metadata).ImplementationUid
				};
			}
			EntityUrlCacheEntry result2 = null;
			if (!MemoryCacheService.TryGetValue<EntityUrlCacheEntry>(key, out result2))
			{
				IEntityManager entityManager = null;
				List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses((ClassMetadata)metadata);
				List<Guid> basesClasses = new List<Guid>();
				if (baseClasses.Count > 0)
				{
					basesClasses = baseClasses.Select((ClassMetadata m) => m.Uid).ToList();
				}
				List<Guid> childClasses = (from ch in MetadataLoader.GetChildClasses((ClassMetadata)metadata)
					select ch.Uid).ToList();
				Type selectorType = MetadataRuntimeService.GetTypeByUid(typeUid);
				IEntityManager manager = EntityHelper.GetEntityManager(selectorType);
				List<IEntityLink> source = ComponentManager.Current.GetExtensionPoints<IEntityLink>().ToList();
				List<IEntityLinkStringUrlResolver> entityLinksStringUrlResolvers = ComponentManager.Current.GetExtensionPoints<IEntityLinkStringUrlResolver>().ToList();
				Func<IEntityLink, Type> getEntityType = delegate(IEntityLink l)
				{
					Type type5 = l.EntityType;
					if (type5 != null && type5.IsInterface && type5 != typeof(IEntity) && type5 != typeof(IEntity<>))
					{
						type5 = InterfaceActivator.TypeOf(type5);
					}
					return type5;
				};
				Func<IEntityLink, bool> checkEntityLink = delegate(IEntityLink l)
				{
					IEntityLinkStringUrlResolver entityLinkStringUrlResolver = entityLinksStringUrlResolvers.FirstOrDefault((IEntityLinkStringUrlResolver r) => r.EntityLink == l.GetType());
					if (entityLinkStringUrlResolver != null)
					{
						return entityLinkStringUrlResolver.CheckRoute(l, routeData);
					}
					IEntity entity = (IEntity)manager.Create();
					string text = l.Href(request.RequestContext, entity);
					string text2 = l.Action(entity);
					string text3 = l.Controller(entity);
					string text4 = l.Area(entity);
					if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2) && string.IsNullOrEmpty(text3) && string.IsNullOrEmpty(text4))
					{
						return false;
					}
					if (!string.IsNullOrEmpty(text) && Uri.TryCreate(text, UriKind.RelativeOrAbsolute, out var result3))
					{
						try
						{
							if (!result3.IsAbsoluteUri)
							{
								text = ToAbsoluteUrl(text);
							}
							routeData = GetRouteDataFromUrl(text);
							text3 = (string)routeData.Values["controller"];
							text2 = (string)routeData.Values["action"];
							text4 = (string)routeData.Values["area"];
						}
						catch (Exception)
						{
						}
					}
					return (action == null || text2 == null || action.Equals(text2, StringComparison.OrdinalIgnoreCase)) && (controller == null || text3 == null || controller.Equals(text3, StringComparison.OrdinalIgnoreCase)) && (area == null || text4 == null || area.Equals(text4, StringComparison.OrdinalIgnoreCase));
				};
				IEntityLink entityLink = source.FirstOrDefault(delegate(IEntityLink l)
				{
					Type type4 = getEntityType(l);
					return (checkUids.Contains(l.TypeUid) || basesClasses.Contains(l.TypeUid) || (type4 != null && (type4 == selectorType || type4.IsAssignableFrom(selectorType)))) && checkEntityLink(l);
				});
				if (entityLink != null)
				{
					GetIdFromEntityLink(entityLink, request, ref id);
					entityManager = manager;
				}
				else if (controller != null)
				{
					Type typeFromHandle = typeof(IBaseController<, >);
					IEnumerable<Type> extensionPointTypes = ComponentManager.Current.GetExtensionPointTypes(typeFromHandle);
					string inputControllerName = $"{controller}Controller";
					Type type = extensionPointTypes.FirstOrDefault((Type c) => c.Name != null && c.Name.Equals(inputControllerName, StringComparison.Ordinal));
					if (type != null && type.GetMethods().Any((MethodInfo m) => m.GetCustomAttributes(typeof(EntityLinkAttribute), inherit: false).FirstOrDefault() != null && action == m.Name))
					{
						Type @interface = type.GetInterface(typeFromHandle.FullName);
						if (@interface != null && @interface.IsGenericType && !@interface.IsGenericTypeDefinition && @interface.GetGenericTypeDefinition() == typeFromHandle)
						{
							Type type2 = @interface.GetGenericArguments()[0];
							Guid guid = (typeof(IEntity).IsAssignableFrom(type2) ? InterfaceActivator.UID(type2) : Guid.Empty);
							if (guid == typeUid || childClasses.Contains(guid) || basesClasses.Contains(guid))
							{
								entityManager = manager;
							}
						}
					}
				}
				if (entityManager == null && entityLink == null)
				{
					entityLink = source.FirstOrDefault(delegate(IEntityLink l)
					{
						Type type3 = getEntityType(l);
						return (childClasses.Contains(l.TypeUid) || (type3 != null && selectorType.IsAssignableFrom(type3))) && checkEntityLink(l);
					});
					if (entityLink != null)
					{
						GetIdFromEntityLink(entityLink, request, ref id);
						entityManager = manager;
					}
				}
				result2 = new EntityUrlCacheEntry
				{
					Manager = entityManager,
					EntityLink = entityLink
				};
				MemoryCacheService.Insert(key, result2);
			}
			if (result2.Manager != null)
			{
				if (result2.EntityLink != null)
				{
					GetIdFromEntityLink(result2.EntityLink, request, ref id);
				}
				return (IEntity)result2.Manager.LoadOrNull(id);
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	private void GetIdFromEntityLink(IEntityLink entityLink, HttpRequest request, ref long id)
	{
		if (!string.IsNullOrEmpty(entityLink.IdParam) && !entityLink.IdParam.Equals("id", StringComparison.OrdinalIgnoreCase))
		{
			id = Convert.ToInt64(request.Params[entityLink.IdParam]);
		}
	}

	private void SearchActionFromExtensions(UrlHelper helper, IEntity entity, bool subclass, RouteValueDictionary route, out string actionName, out string controllerName, out string areaName, out string parameter, out string href)
	{
		actionName = "";
		controllerName = "";
		areaName = "";
		parameter = "";
		href = null;
		Type type = entity.CastAsRealType().GetType();
		Guid entityTypeUid = ((entity is IInheritable) ? ((IInheritable)entity).TypeUid : InterfaceActivator.UID(type));
		IEntityLink entityLink = GetEntityLink(type, entityTypeUid, subclass);
		if (entityLink == null)
		{
			return;
		}
		actionName = entityLink.Action(entity);
		controllerName = entityLink.Controller(entity);
		areaName = entityLink.Area(entity);
		parameter = entityLink.IdParam;
		href = entityLink.Href(helper.get_RequestContext(), entity);
		RouteValueDictionary @params = entityLink.GetParams(entity);
		if (@params == null || @params.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in @params)
		{
			route.Add(item.Key, item.Value);
		}
	}

	private void SearchActionFromExtensions(UrlHelper helper, Guid entityTypeUid, long entityId, bool subclass, RouteValueDictionary route, out string actionName, out string controllerName, out string areaName, out string parameter, out string href)
	{
		actionName = "";
		controllerName = "";
		areaName = "";
		parameter = "";
		href = null;
		Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(entityTypeUid);
		IEntityLink entityLink = GetEntityLink(typeByUid, entityTypeUid, subclass);
		if (entityLink == null)
		{
			return;
		}
		IEntity entity = null;
		if (entityLink.LoadEntityIfNull)
		{
			IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
			try
			{
				entity = (IEntity)entityManager.LoadOrNull(entityId).CastAsRealType();
			}
			catch (SecurityException)
			{
			}
		}
		actionName = entityLink.Action(entity);
		controllerName = entityLink.Controller(entity);
		areaName = entityLink.Area(entity);
		parameter = entityLink.IdParam;
		href = entityLink.Href(helper.get_RequestContext(), entity);
		RouteValueDictionary @params = entityLink.GetParams(null);
		if (@params == null || @params.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in @params)
		{
			route.Add(item.Key, item.Value);
		}
	}

	private IEntityLink GetEntityLink(Type entityType, Guid entityTypeUid, bool subclass)
	{
		string key = string.Concat("EntityUrlResolverService_EntityLink_", entityType.FullName, "_", entityTypeUid, subclass ? "_s" : "");
		if (!MemoryCacheService.TryGetValue<IEntityLink>(key, out var result))
		{
			List<IEntityLink> source = ComponentManager.Current.GetExtensionPoints<IEntityLink>().ToList();
			if (source.Any())
			{
				List<Guid> baseUids = (subclass ? (from m in MetadataLoader.GetBaseClasses((ClassMetadata)MetadataLoader.LoadMetadata(entityTypeUid))
					select m.Uid).ToList() : new List<Guid>());
				result = source.FirstOrDefault((IEntityLink e) => e.TypeUid == entityTypeUid || (subclass && baseUids.Contains(e.TypeUid))) ?? source.FirstOrDefault((IEntityLink e) => e.EntityType != null && (e.EntityType == entityType || (subclass && e.EntityType.IsAssignableFrom(entityType))));
			}
			MemoryCacheService.Insert(key, result);
		}
		return result;
	}

	private void SearchAction(IEntity entity, bool subclass, out string actionName, out string controllerName, out string areaName, out string parameter)
	{
		Type type = entity.CastAsRealType().GetType();
		Guid entityTypeUid = ((entity is IInheritable) ? ((IInheritable)entity).TypeUid : InterfaceActivator.UID(type));
		EntityActionCacheEntry entityControllerAction = GetEntityControllerAction(type, entityTypeUid, subclass);
		if (entityControllerAction != null)
		{
			actionName = entityControllerAction.Action;
			controllerName = entityControllerAction.Controller;
			areaName = entityControllerAction.Area;
			parameter = entityControllerAction.Parameter;
		}
		else
		{
			actionName = "";
			controllerName = "";
			areaName = "";
			parameter = "";
		}
	}

	private void SearchAction(Guid entityTypeUid, bool subclass, out string actionName, out string controllerName, out string areaName, out string parameter)
	{
		Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(entityTypeUid);
		EntityActionCacheEntry entityControllerAction = GetEntityControllerAction(typeByUid, entityTypeUid, subclass);
		if (entityControllerAction != null)
		{
			actionName = entityControllerAction.Action;
			controllerName = entityControllerAction.Controller;
			areaName = entityControllerAction.Area;
			parameter = entityControllerAction.Parameter;
		}
		else
		{
			actionName = "";
			controllerName = "";
			areaName = "";
			parameter = "";
		}
	}

	private EntityActionCacheEntry GetEntityControllerAction(Type entityType, Guid entityTypeUid, bool subclass)
	{
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		string key = string.Concat("EntityUrlResolverService_ControllerLink_", entityType.FullName, "_", entityTypeUid, subclass ? "_s" : "");
		if (!MemoryCacheService.TryGetValue<EntityActionCacheEntry>(key, out var result))
		{
			List<Guid> list = (subclass ? (from m in MetadataLoader.GetBaseClasses((ClassMetadata)MetadataLoader.LoadMetadata(entityTypeUid))
				select m.Uid).ToList() : new List<Guid>());
			Type typeFromHandle = typeof(IBaseController<, >);
			foreach (Type extensionPointType in ComponentManager.Current.GetExtensionPointTypes(typeFromHandle))
			{
				Type @interface = extensionPointType.GetInterface(typeFromHandle.FullName);
				if (!(@interface != null) || !@interface.IsGenericType || @interface.IsGenericTypeDefinition || !(@interface.GetGenericTypeDefinition() == typeFromHandle))
				{
					continue;
				}
				Type type = @interface.GetGenericArguments()[0];
				Guid guid = (typeof(IEntity).IsAssignableFrom(type) ? InterfaceActivator.UID(type) : Guid.Empty);
				if (!(guid == entityTypeUid) && (!subclass || !list.Contains(guid)) && !(entityType == type) && (!subclass || !type.IsAssignableFrom(entityType)))
				{
					continue;
				}
				object obj = extensionPointType.GetCustomAttributes(typeof(RouteAreaAttribute), inherit: false).FirstOrDefault();
				MethodInfo[] methods = extensionPointType.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					object obj2 = methodInfo.GetCustomAttributes(typeof(EntityLinkAttribute), inherit: false).FirstOrDefault();
					if (obj2 != null)
					{
						result = new EntityActionCacheEntry
						{
							Action = methodInfo.Name,
							Controller = extensionPointType.Name
						};
						if (obj != null)
						{
							result.Area = ((RouteAreaAttribute)obj).get_AreaName();
						}
						if (string.IsNullOrEmpty(((EntityLinkAttribute)obj2).ParametrName))
						{
							ParameterInfo parameterInfo = methodInfo.GetParameters().FirstOrDefault();
							result.Parameter = parameterInfo.Name;
						}
						else
						{
							result.Parameter = ((EntityLinkAttribute)obj2).ParametrName;
						}
						break;
					}
				}
			}
			MemoryCacheService.Insert(key, result);
		}
		return result;
	}

	protected IEntityManager GetEntityManager(Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return null;
		}
		return ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid));
	}
}
