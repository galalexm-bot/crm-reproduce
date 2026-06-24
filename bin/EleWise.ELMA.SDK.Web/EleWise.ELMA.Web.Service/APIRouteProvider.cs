using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using Orchard;
using Orchard.Mvc.Routes;

namespace EleWise.ELMA.Web.Service;

public class APIRouteProvider : IRouteProvider, IDependency
{
	private RouteDescriptor[] routeDescriptors;

	public const string AreaName = "EleWise.ELMA.SDK.Web";

	public const string UrlPrefix = "API";

	public const string InternalUrlPrefix = "InternalAPI";

	public const string PublicUrlPrefix = "PublicAPI";

	public const string UrlRestSubPath = "REST";

	public const string ApiServiceNamespaceRoot = "http://www.elma-bpm.ru/api/";

	public const string RestBindingName = "WebHttpBinding-ELMA";

	public const string SoapBindingName = "BasicHttpBinding-ELMA";

	private static readonly ConcurrentDictionary<string, ServiceRoute> RoutesCache = new ConcurrentDictionary<string, ServiceRoute>();

	private static string GetServiceKey(IPublicService publicService, bool isRest)
	{
		return $"{publicService.ModuleUid}|{publicService.Uid}|{publicService.Name}|{isRest}";
	}

	private static string GetServiceKey(string rootUrlPath, Type serviceType, Type contractType, bool isRest, bool isStreamed = false)
	{
		return $"{rootUrlPath}|{serviceType.AssemblyQualifiedName}|{contractType.AssemblyQualifiedName}|{isRest}|{isStreamed}";
	}

	private static ServiceRoute GetServiceRoute(IPublicService publicService, bool isRest)
	{
		return RoutesCache.GetOrAdd(GetServiceKey(publicService, isRest), (string s) => new ServiceRoute("API/" + (isRest ? "REST/" : "") + publicService.Name, new PublicServiceFactory(publicService, !isRest), typeof(EmptyPublicService))
		{
			Defaults = new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }
		});
	}

	private static ServiceRoute GetServiceRoute(string rootUrlPath, Type serviceType, Type contractType, bool isRest, bool isStreamed = false)
	{
		return RoutesCache.GetOrAdd(GetServiceKey(rootUrlPath, serviceType, contractType, isRest, isStreamed), (string s) => new ServiceRoute("API/" + (isRest ? "REST/" : "") + rootUrlPath, new DynamicServiceFactory(!isRest, contractType, isStreamed), serviceType)
		{
			Defaults = new RouteValueDictionary { { "area", "EleWise.ELMA.SDK.Web" } }
		});
	}

	private static ServiceRoute GetInternalAPIServiceRoute(string areaName, string rootUrlPath, Type serviceType, Type contractType, bool isRest, bool isStreamed = false)
	{
		return RoutesCache.GetOrAdd(GetServiceKey(areaName + "/" + rootUrlPath, serviceType, contractType, isRest, isStreamed), (string s) => new ServiceRoute("InternalAPI/" + (isRest ? "REST/" : "") + areaName + "/" + rootUrlPath, new DynamicServiceFactory(!isRest, contractType, isStreamed), serviceType)
		{
			Defaults = new RouteValueDictionary { { "area", areaName } }
		});
	}

	private static ServiceRoute GetPublicAPIServiceRoute(string areaName, string rootUrlPath, Type serviceType, Type contractType, bool isRest, bool isStreamed = false)
	{
		return RoutesCache.GetOrAdd(GetServiceKey("PublicAPI/" + areaName + "/" + rootUrlPath, serviceType, contractType, isRest, isStreamed), (string s) => new ServiceRoute("PublicAPI/" + (isRest ? "REST/" : "") + areaName + "/" + rootUrlPath, new DynamicServiceFactory(!isRest, contractType, isStreamed), serviceType)
		{
			Defaults = new RouteValueDictionary { { "area", areaName } }
		});
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		routeDescriptors = routeDescriptors ?? GetHelpControllerRoutes().Union(GetCoreServiceRoutes()).Union(GetInternalAPIServiceRoutes()).Union(GetPublicAPIServiceRoutes())
			.Union(GetExtensionsServiceRoutes())
			.ToArray();
		return routeDescriptors;
	}

	private IEnumerable<RouteDescriptor> GetInternalAPIServiceRoutes()
	{
		Type[] array = ComponentManager.Current.GetExtensionPointTypes<IInternalAPIWebService>().ToArray();
		CheckCoreServiceOnlyOneContract(array);
		CheckCoreServicesAllHasUid(array);
		return array.Select((Type s) => new
		{
			Service = s,
			Contracts = from type in s.GetInterfaces()
				where type.GetCustomAttributes(typeof(ServiceContractAttribute), inherit: false).Length != 0
				select type
		}).SelectMany(csc => GetInternalAPIServiceRoutes(GetAreaName(csc.Service), RootUrlPath(csc.Service), csc.Service, csc.Contracts.First()));
	}

	private IEnumerable<RouteDescriptor> GetPublicAPIServiceRoutes()
	{
		Type[] array = ComponentManager.Current.GetExtensionPointTypes<IPublicAPIWebService>().ToArray();
		CheckCoreServiceOnlyOneContract(array);
		CheckCoreServicesAllHasUid(array);
		return array.Select((Type s) => new
		{
			Service = s,
			Contracts = from type in s.GetInterfaces()
				where Attribute.IsDefined(type, typeof(ServiceContractAttribute), inherit: false)
				select type
		}).SelectMany(csc => GetPublicAPIServiceRoutes(GetAreaName(csc.Service), RootUrlPath(csc.Service), csc.Service, csc.Contracts.First()));
	}

	private static string GetAreaName(Type service)
	{
		ModuleAttribute attribute = AttributeHelper<ModuleAttribute>.GetAttribute(service.Assembly);
		if (attribute == null)
		{
			return "EleWise.ELMA.SDK.Web";
		}
		return attribute.Id;
	}

	private IEnumerable<RouteDescriptor> GetCoreServiceRoutes()
	{
		Type[] array = ComponentManager.Current.GetExtensionPointTypes<ICorePublicService>().ToArray();
		CheckCoreServiceOnlyOneContract(array);
		CheckCoreServicesAllHasUid(array);
		return array.Select((Type s) => new
		{
			Service = s,
			Contracts = from type in s.GetInterfaces()
				where type.GetCustomAttributes(typeof(ServiceContractAttribute), inherit: false).Length != 0
				select type
		}).SelectMany(csc => GetServiceRoutes(RootUrlPath(csc.Service), csc.Service, csc.Contracts.First()));
	}

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}

	public static string GetServiceSoapUrl(ServiceDocumentation serviceType)
	{
		string text = serviceType.ServiceUrl ?? "API";
		string arg = ((text == "API") ? "" : (GetAreaName(serviceType.ServiceType) + "/"));
		return $"~/{text}/{arg}{RootUrlPath(serviceType.ServiceType)}";
	}

	public static string GetServiceRestHelpUrl(ServiceDocumentation serviceType)
	{
		string text = serviceType.ServiceUrl ?? "API";
		string text2 = ((text == "API") ? "" : (GetAreaName(serviceType.ServiceType) + "/"));
		return string.Format("~/{0}/{1}/{2}{3}/Help", text, "REST", text2, RootUrlPath(serviceType.ServiceType));
	}

	public static CultureInfo GetRequestLanguage()
	{
		string text = GetRequestHeader("Accept-Language");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		try
		{
			if (text.Contains(",") || text.Contains(";"))
			{
				MatchCollection matchCollection = Regex.Matches(text, "[a-zA-z\\-]{2,10}");
				if (matchCollection.Count > 0)
				{
					text = matchCollection[0].Value;
				}
			}
			return SR.GetCultureByName(text);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string GetRequestHeader(string headerName)
	{
		string text = null;
		if (WebOperationContext.Current != null)
		{
			text = WebOperationContext.Current.IncomingRequest.Headers.Get(headerName);
		}
		if (string.IsNullOrWhiteSpace(text) && OperationContext.Current != null)
		{
			int num = OperationContext.Current.IncomingMessageHeaders.FindHeader(headerName, "");
			if (num > -1)
			{
				text = OperationContext.Current.IncomingMessageHeaders.GetHeader<string>(num);
			}
		}
		if (string.IsNullOrWhiteSpace(text) && WebOperationContext.Current != null && WebOperationContext.Current.IncomingRequest.UriTemplateMatch != null && WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters != null)
		{
			text = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters.Get("Header:" + headerName);
		}
		if (string.IsNullOrWhiteSpace(text) && HttpContext.Current != null && HttpContext.Current.Request != null && HttpContext.Current.Request.Headers != null)
		{
			string[] values = HttpContext.Current.Request.Headers.GetValues(headerName);
			if (values != null)
			{
				text = values.FirstOrDefault();
			}
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		return text;
	}

	public static void CheckHpsLimit(string hitName, double hitDelayTimeout)
	{
		string key = hitName + "-" + ContextVars.Get<IPublicClientSession>("PublicContractInfo.SessionContextKey").SessionToken;
		ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
		IMemoryCacheService serviceNotNull2 = Locator.GetServiceNotNull<IMemoryCacheService>();
		ITransformationProvider serviceNotNull3 = Locator.GetServiceNotNull<ITransformationProvider>();
		bool flag = true;
		DateTime dateTime = serviceNotNull3.GetDateTimeNow().ToUniversalTime();
		if (serviceNotNull2.TryGetValue<DateTime>(key, out var result) || serviceNotNull.TryGetValue<DateTime>(key, "RequestRateLimit", out result))
		{
			result = result.ToUniversalTime();
			if (result.AddSeconds(hitDelayTimeout) > dateTime)
			{
				flag = false;
			}
		}
		if (flag)
		{
			result = dateTime;
			serviceNotNull.Insert(key, result, "RequestRateLimit", TimeSpan.FromSeconds(hitDelayTimeout));
			serviceNotNull2.Insert(key, result, TimeSpan.FromSeconds(hitDelayTimeout));
		}
		if (!flag)
		{
			throw PublicServiceException.CreateWebFault($"You must wait {hitDelayTimeout.ToString(CultureInfo.InvariantCulture)} seconds between requests. Last hit was on {result.ToString(CultureInfo.InvariantCulture)}", 409);
		}
	}

	internal static Guid GetGuidToken(string tokenHeader)
	{
		string text = null;
		text = ((WebOperationContext.Current == null) ? ContextVars.GetOrDefault<string>(tokenHeader) : WebOperationContext.Current.IncomingRequest.Headers.Get(tokenHeader));
		Guid result = Guid.Empty;
		if (string.IsNullOrEmpty(text) && OperationContext.Current != null)
		{
			int num = OperationContext.Current.IncomingMessageHeaders.FindHeader(tokenHeader, "");
			if (num > -1)
			{
				result = OperationContext.Current.IncomingMessageHeaders.GetHeader<Guid>(num);
			}
		}
		if (result != Guid.Empty || (!string.IsNullOrEmpty(text) && Guid.TryParse(text, out result)))
		{
			return result;
		}
		return Guid.Empty;
	}

	private static string RootUrlPath(Type cscService)
	{
		if (typeof(IPublicService).IsAssignableFrom(cscService) && Locator.GetServiceNotNull(cscService) is IPublicService publicService)
		{
			return publicService.Name;
		}
		if (!cscService.Name.EndsWith("Service"))
		{
			return cscService.Name;
		}
		return cscService.Name.Remove(cscService.Name.Length - "Service".Length);
	}

	private static IEnumerable<RouteDescriptor> GetHelpControllerRoutes()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		return new RouteDescriptor[1]
		{
			new RouteDescriptor
			{
				Priority = 100,
				Route = new Route("API/Help/{action}", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.SDK.Web" },
					{ "controller", "ServiceHelp" },
					{ "action", "Index" }
				}, null, new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.SDK.Web" },
					{ "controller", "ServiceHelp" }
				}, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}

	private static IEnumerable<RouteDescriptor> GetServiceRoutes(string rootUrlPath, Type serviceType, Type contractType, bool isStreamed = false)
	{
		RouteDescriptor[] result = new RouteDescriptor[0];
		try
		{
			result = new RouteDescriptor[2]
			{
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetServiceRoute(rootUrlPath, serviceType, contractType, isRest: false, isStreamed)
				},
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetServiceRoute(rootUrlPath, serviceType, contractType, isRest: true, isStreamed)
				}
			};
			return result;
		}
		catch (ArgumentException)
		{
			return result;
		}
	}

	private static IEnumerable<RouteDescriptor> GetInternalAPIServiceRoutes(string areaName, string rootUrlPath, Type serviceType, Type contractType, bool isStreamed = false)
	{
		RouteDescriptor[] result = new RouteDescriptor[0];
		try
		{
			result = new RouteDescriptor[2]
			{
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetInternalAPIServiceRoute(areaName, rootUrlPath, serviceType, contractType, isRest: false, isStreamed)
				},
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetInternalAPIServiceRoute(areaName, rootUrlPath, serviceType, contractType, isRest: true, isStreamed)
				}
			};
			return result;
		}
		catch (ArgumentException)
		{
			return result;
		}
	}

	private static IEnumerable<RouteDescriptor> GetPublicAPIServiceRoutes(string areaName, string rootUrlPath, Type serviceType, Type contractType, bool isStreamed = false)
	{
		RouteDescriptor[] result = new RouteDescriptor[0];
		try
		{
			result = new RouteDescriptor[2]
			{
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetPublicAPIServiceRoute(areaName, rootUrlPath, serviceType, contractType, isRest: false, isStreamed)
				},
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetPublicAPIServiceRoute(areaName, rootUrlPath, serviceType, contractType, isRest: true, isStreamed)
				}
			};
			return result;
		}
		catch (ArgumentException)
		{
			return result;
		}
	}

	private static IEnumerable<RouteDescriptor> GetExtensionsServiceRoutes()
	{
		IPublicService[] array = ComponentManager.Current.GetExtensionPoints<IPublicService>().ToArray();
		CheckDuplicateServices(array);
		return from r in array.SelectMany(GetRoutesFromService)
			where r != null
			select r;
	}

	private static IEnumerable<RouteDescriptor> GetRoutesFromService(IPublicService publicService)
	{
		if (publicService == null)
		{
			return new RouteDescriptor[0];
		}
		RouteDescriptor[] result = new RouteDescriptor[0];
		try
		{
			result = new RouteDescriptor[2]
			{
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetServiceRoute(publicService, isRest: false)
				},
				new RouteDescriptor
				{
					Priority = 50,
					Route = GetServiceRoute(publicService, isRest: true)
				}
			};
			return result;
		}
		catch (ArgumentException)
		{
			return result;
		}
	}

	private static void CheckCoreServicesAllHasUid(Type[] coreServices)
	{
		Type[] array = coreServices.Where((Type t) => AttributeHelper<UidAttribute>.GetAttribute(t, inherited: false) == null).ToArray();
		if (array.Length != 0)
		{
			IEnumerable<string> values = array.Select((Type t) => SR.T("Тип: {0}", t));
			throw new InitializationException(SR.T("Обнаружены сервисы уровня ядра с необъявленным атрибутом {2}:{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, values), typeof(UidAttribute)));
		}
	}

	private static void CheckCoreServiceOnlyOneContract(IEnumerable<Type> coreServices)
	{
		var source = coreServices.Select((Type s) => new
		{
			s = s,
			contracts = from type in s.GetInterfaces()
				where type.GetCustomAttributes(typeof(ServiceContractAttribute), inherit: false).Length != 0
				select type
		}).ToArray();
		var array = source.Where(o => o.contracts.Count() > 1).ToArray();
		var array2 = source.Where(o => !o.contracts.Any()).ToArray();
		if (array.Length != 0)
		{
			IEnumerable<string> values = array.Select(o => SR.T("Тип: {0}, контракты: {1}", o.s, string.Join(", ", o.contracts)));
			throw new InitializationException(SR.T("Обнаружены сервисы уровня ядра более чем с одним контрактом:{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, values)));
		}
		if (array2.Length != 0)
		{
			IEnumerable<string> values2 = array2.Select(o => SR.T("Тип: {0}", o.s));
			throw new InitializationException(SR.T("Обнаружены сервисы уровня ядра не имеющие ни одного контракта:{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, values2)));
		}
	}

	private static void CheckDuplicateServices(IPublicService[] services)
	{
		IGrouping<Guid, IPublicService>[] array = (from s in services
			group s by s.Uid into g
			where g.Count() > 1
			select g).ToArray();
		if (array != null && array.Any())
		{
			IEnumerable<string> values = from k in array.Select((IGrouping<Guid, IPublicService> d) => d.Key).Distinct()
				select k.ToString();
			throw new InitializationException(SR.T("Обнаружены дублирующие идентификаторы сервисов: {0}", string.Join(", ", values)));
		}
		IGrouping<string, IPublicService>[] array2 = (from s in services
			group s by s.Name into g
			where g.Count() > 1
			select g).ToArray();
		if (array2 != null && array2.Any())
		{
			IEnumerable<string> values2 = from k in array2.Select((IGrouping<string, IPublicService> d) => d.Key).Distinct()
				select k.ToString(CultureInfo.InvariantCulture);
			throw new InitializationException(SR.T("Обнаружены дублирующие имена сервисов: {0}", string.Join(", ", values2)));
		}
	}
}
