using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Audit;

[Component]
public class WatchEntityActionHandler : IEntityActionHandler, IEventHandler
{
	private IMemoryCacheService _memoryCacheService;

	private const string CacheKeyPrefix = "WatchEntityActionHandler:Provider-";

	public WatchEntityActionHandler(IMemoryCacheService memoryCacheService)
	{
		if (memoryCacheService == null)
		{
			throw new ArgumentNullException("memoryCacheService");
		}
		_memoryCacheService = memoryCacheService;
	}

	public static List<IUser> GetWatches(IMemoryCacheService memoryCacheService, EntityActionEventArgs e)
	{
		if (e.New == null)
		{
			return new List<IUser>();
		}
		IMetadata metadata = MetadataLoader.LoadMetadata(e.New.CastAsRealType().GetType());
		string key = "WatchEntityActionHandler:Provider-" + metadata.Uid;
		if (!memoryCacheService.TryGetValue<IWatchProvider>(key, out var provider))
		{
			provider = ComponentManager.Current.GetExtensionPoints<IWatchProvider>(useCache: true).FirstOrDefault((IWatchProvider p) => p.TypeUid.Contains(metadata.Uid));
			memoryCacheService.Insert(key, provider);
		}
		if (provider == null)
		{
			return new List<IUser>();
		}
		return (from u in Locator.GetServiceNotNull<IWatchEntityService>().GetWatches(e.Object.Uid, e.Action.Uid, e.New)
			where provider.CanSendToUser(e.New.CastAsRealType(), u)
			select u).ToList();
	}

	public void ActionExecuted(EntityActionEventArgs e)
	{
		IDictionary<string, object> extendedProperties = e.ExtendedProperties;
		List<IUser> watches = GetWatches(_memoryCacheService, e);
		if (extendedProperties.ContainsKey("WatchList") && extendedProperties["WatchList"] is IEnumerable<IUser>)
		{
			IEnumerable<IUser> collection = (IEnumerable<IUser>)extendedProperties["WatchList"];
			watches.AddRange(collection);
		}
		extendedProperties["WatchList"] = watches.Distinct().ToList();
	}
}
