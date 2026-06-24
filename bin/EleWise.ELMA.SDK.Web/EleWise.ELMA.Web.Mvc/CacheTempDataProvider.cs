using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc;

[Service]
public class CacheTempDataProvider : ICacheTempDataProvider, ITempDataProvider
{
	private ICacheService cacheService;

	private const string CacheRegion = "TempData";

	private const string CachePrefix = "SessionTempData_";

	public ICacheService CacheService => cacheService ?? (cacheService = (Locator.Initialized ? Locator.GetService<ICacheService>() : null));

	public IDictionary<string, object> LoadTempData(ControllerContext controllerContext)
	{
		if (CacheService == null || controllerContext == null || controllerContext.get_HttpContext() == null || controllerContext.get_HttpContext().Session == null)
		{
			return new SerializableDictionary<string, object>();
		}
		using (ELMAContext.Create())
		{
			string key = "SessionTempData_" + controllerContext.get_HttpContext().Session.SessionID;
			if (!CacheService.TryGetValue<byte[]>(key, "TempData", out var value))
			{
				return new SerializableDictionary<string, object>();
			}
			try
			{
				return (IDictionary<string, object>)ClassSerializationHelper.DeserializeObject(value);
			}
			catch (Exception exception)
			{
				Logger.Log.Warn("Cannot load temp data", exception);
				return new SerializableDictionary<string, object>();
			}
		}
	}

	public void SaveTempData(ControllerContext controllerContext, IDictionary<string, object> values)
	{
		if (CacheService == null || controllerContext == null || controllerContext.get_HttpContext() == null || controllerContext.get_HttpContext().Session == null)
		{
			return;
		}
		using (ELMAContext.Create())
		{
			string key = "SessionTempData_" + controllerContext.get_HttpContext().Session.SessionID;
			if (values == null || !values.Any())
			{
				CacheService.Remove(key, "TempData");
				return;
			}
			SerializableDictionary<string, object> serializableDictionary = values as SerializableDictionary<string, object>;
			if (serializableDictionary == null)
			{
				serializableDictionary = new SerializableDictionary<string, object>();
				foreach (KeyValuePair<string, object> value2 in values)
				{
					serializableDictionary.Add(value2.Key, value2.Value);
				}
			}
			try
			{
				byte[] value = ClassSerializationHelper.SerializeObject(serializableDictionary);
				CacheService.Insert(key, value, "TempData", TimeSpan.FromDays(1.0));
			}
			catch (Exception exception)
			{
				Logger.Log.Warn("Cannot save temp data", exception);
			}
		}
	}
}
