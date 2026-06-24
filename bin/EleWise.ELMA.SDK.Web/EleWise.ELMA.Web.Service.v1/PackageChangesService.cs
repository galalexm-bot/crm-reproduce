using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Text;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{F1F91767-DF54-4A47-A82A-FC6148A52A6D}")]
public class PackageChangesService : IPackageChangesService, ICorePublicService
{
	public const string GuidS = "{F1F91767-DF54-4A47-A82A-FC6148A52A6D}";

	public static Guid Guid = new Guid("{F1F91767-DF54-4A47-A82A-FC6148A52A6D}");

	private static readonly TimeSpan tokenDuration = TimeSpan.FromHours(1.0);

	private const string DataSetsName = "PackageChangesService_DataSets";

	private static object dataSetsLocker = new object();

	private static readonly object cacheServiceLocker = new object();

	private static ICacheService cacheService;

	public static List<Guid> DataSets
	{
		get
		{
			return ContextVars.GetOrAdd("PackageChangesService_DataSets", delegate
			{
				IPublicClientSession session = Locator.GetServiceNotNull<IPublicClientService>().GetSession(AuthToken);
				if (session == null)
				{
					throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
				}
				IClientSessionDataSets sessionModules = Locator.GetServiceNotNull<IClientModulesService>().GetSessionModules(session.SessionToken);
				if (sessionModules == null || sessionModules.DataSets == null || sessionModules.DataSets.Count == 0)
				{
					throw PublicServiceException.CreateWebFault("Для текущей сессии не задан набор данных. Необходимо вызвать метод InitDataSets с передачей набора данных.", 500);
				}
				return sessionModules.DataSets;
			});
		}
		private set
		{
			IPublicClientSession session = Locator.GetServiceNotNull<IPublicClientService>().GetSession(AuthToken);
			if (session == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			Locator.GetServiceNotNull<IClientModulesService>().UpdateDataSets(session.SessionToken, value);
			ContextVars.Set("PackageChangesService_DataSets", value);
		}
	}

	public static Guid AuthToken => APIRouteProvider.GetGuidToken("AuthToken");

	public ILogger Logger => EleWise.ELMA.Logging.Logger.GetLogger(typeof(PackageChangesService));

	private static ICacheService CacheService
	{
		get
		{
			if (cacheService != null)
			{
				return cacheService;
			}
			lock (cacheServiceLocker)
			{
				if (cacheService != null)
				{
					return cacheService;
				}
				cacheService = Locator.GetServiceNotNull<ICacheService>();
				return cacheService;
			}
		}
	}

	public bool InitDataSets(Guid[] dataSets)
	{
		try
		{
			DataSets = dataSets.ToList();
			return true;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public static void InitEmptyDataSets()
	{
		ContextVars.Set("PackageChangesService_DataSets", new List<Guid>());
	}

	public PackageChangesResponse Changes(DateTime fromServerTime)
	{
		DateTime now = DateTime.Now;
		PackageBase[] array = new PackageBase[0];
		DateTime? dateTime = ((fromServerTime == DateTime.MinValue) ? null : new DateTime?(fromServerTime));
		List<Guid> dataSets = DataSets;
		if (!dateTime.HasValue)
		{
			Filter filter = new Filter
			{
				Query = $"UserId={AuthenticationService.GetCurrentUser<IUser>().GetId()} and Status=Enum('{PackageChangesStatus.Completed}')"
			};
			IPackageChanges packageChanges = EntityManager<IPackageChanges>.Instance.Find(filter, FetchOptions.First).FirstOrDefault();
			if (packageChanges != null && packageChanges.PackagesInfo != null)
			{
				array = (from p in ClassSerializationHelper.DeserializeObjectByJson<PackageBase[]>(packageChanges.PackagesInfo)
					join m in dataSets on p.ServiceUid equals m
					select p).ToArray();
				dateTime = (packageChanges.ChangeDateTicks.HasValue ? new DateTime?(new DateTime(packageChanges.ChangeDateTicks.Value)) : null);
			}
		}
		else
		{
			array = (from p in ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>()
				join m in dataSets on p.ServiceUid equals m
				select p).SelectMany((IUpdatePackageService p) => p.CreatePackages(fromServerTime)).ToArray();
		}
		Logger.DebugFormat("Request time: {1}; Response time: {0}; Packages: {2}", now, dateTime, array.Length);
		return SetToCache(now, dateTime, array);
	}

	public PackageBase[] Packages(string packageUid, int from, int length)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(packageUid))
			{
				throw PublicServiceException.CreateWebFault("Необходимо передать packageUid", 500);
			}
			PackagesCacheData value = null;
			IPublicClientService serviceNotNull = Locator.GetServiceNotNull<IPublicClientService>();
			if (!CacheService.TryGetValue<PackagesCacheData>(packageUid, out value))
			{
				IPublicClientSession session = serviceNotNull.GetSession(AuthToken);
				if (session != null)
				{
					value = GetPackagesCacheData(session.LastChangesPackage);
					if (value != null && value.Uid != new Guid(packageUid))
					{
						value = null;
					}
				}
			}
			if (value != null && value.Packages != null)
			{
				int num = Math.Min(length, Math.Max(value.Packages.Length - from, 0));
				PackageBase[] array = new PackageBase[num];
				Array.Copy(value.Packages, from, array, 0, num);
				foreach (var convertPackagesService in (from p in array.Select((PackageBase package, int index) => new
					{
						package = (package as UpdateIdPackage),
						index = index
					})
					where p.package != null
					group p by p.package.ServiceUid).ToList())
				{
					IUpdatePackageService updatePackageService = ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>().FirstOrDefault((IUpdatePackageService s) => s.ServiceUid == convertPackagesService.Key);
					foreach (var item in (from p in convertPackagesService
						group p by p.package.TypeUid).ToList())
					{
						PackageBase[] array2 = updatePackageService.ConvertPackages(item.Select(p => p.package).ToArray());
						int num2 = 0;
						foreach (var item2 in item)
						{
							value.Packages[from + item2.index] = (array[item2.index] = array2[num2++]);
						}
					}
				}
				CacheService.Insert(packageUid, value, tokenDuration);
				serviceNotNull.UpdateLastChangesPackage(AuthToken, ClassSerializationHelper.SerializeObjectByJson(value));
				if (Logger.IsDebugEnabled())
				{
					Logger.DebugFormat("Packages({0}, {1}, {2})\n{3}", packageUid, from, length, new JsonSerializer().Serialize(array));
				}
				return array;
			}
			Logger.Error("Пакет с данным id не найден");
			throw PublicServiceException.CreateWebFault("Пакет с данным id не найден", 410);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public bool PackagesCommit(string packageUid)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(packageUid))
			{
				throw PublicServiceException.CreateWebFault("Необходимо передать packageUid", 500);
			}
			IPublicClientService serviceNotNull = Locator.GetServiceNotNull<IPublicClientService>();
			if (!CacheService.TryGetValue<PackagesCacheData>(packageUid, out var value))
			{
				IPublicClientSession session = serviceNotNull.GetSession(AuthToken);
				if (session == null)
				{
					return false;
				}
				value = GetPackagesCacheData(session.LastChangesPackage);
				if (value == null || value.Uid != new Guid(packageUid))
				{
					return false;
				}
			}
			if (value != null && value.Packages != null)
			{
				List<IUpdatePackageService> source = ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>().ToList();
				foreach (IGrouping<Guid, PackageBase> packagesService in from p in value.Packages
					group p by p.ServiceUid)
				{
					IUpdatePackageService updatePackageService = source.FirstOrDefault((IUpdatePackageService s) => s.ServiceUid == packagesService.Key);
					if (updatePackageService == null || !updatePackageService.PackagesCommit(value.ServerTime ?? DateTime.MinValue, value.Now, packagesService.ToArray()))
					{
						return false;
					}
				}
			}
			CacheService.Remove(packageUid);
			serviceNotNull.UpdateLastChangesPackage(AuthToken, null);
			return true;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public bool Sync(PackageChangesSyncRequest changes)
	{
		return (from p in ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>()
			join m in DataSets on p.ServiceUid equals m
			select p).ToList().All((IUpdatePackageService s) => s.Sync(changes.Now, changes.Data));
	}

	public static PackageChangesResponse SetToCache(DateTime now, DateTime? serverTime, IList<PackageBase> packages)
	{
		Guid guid = Guid.NewGuid();
		PackagesCacheData packagesCacheData = new PackagesCacheData
		{
			Uid = guid,
			ServerTime = serverTime,
			Now = now,
			Packages = packages.ToArray()
		};
		Locator.GetServiceNotNull<IPublicClientService>().UpdateLastChangesPackage(AuthToken, ClassSerializationHelper.SerializeObjectByJson(packagesCacheData));
		CacheService.Insert(guid.ToString(), packagesCacheData, tokenDuration);
		return new PackageChangesResponse
		{
			Id = guid,
			UpdatesDate = now,
			Count = packages.Count
		};
	}

	private PackagesCacheData GetPackagesCacheData(byte[] data)
	{
		if (data.Length == 0)
		{
			return null;
		}
		return ClassSerializationHelper.DeserializeObjectByJson<PackagesCacheData>(EncodingCache.UTF8WithoutEmitIdentifier.GetString(data));
	}
}
