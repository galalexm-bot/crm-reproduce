using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Services;

[Service]
public class StatusScanedService : IStatusScanedService
{
	private ICacheService cacheService;

	private const string cacheRegion = "StatusScanedService";

	private ICacheService CacheService
	{
		get
		{
			if (cacheService != null)
			{
				return cacheService;
			}
			lock (this)
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

	public virtual void ClearAll()
	{
		CacheService.ClearRegion("StatusScanedService");
	}

	public virtual void DeleteByUid(Guid uid)
	{
		string cacheKey = GetCacheKey(uid);
		CacheService.Remove(cacheKey, "StatusScanedService");
	}

	public virtual void SetStatus(Guid uid, StatusScanedFileEnum status)
	{
		string cacheKey = GetCacheKey(uid);
		CacheService.Insert(cacheKey, status, "StatusScanedService");
	}

	public virtual StatusScanedFileEnum GetStatus(Guid uid)
	{
		string cacheKey = GetCacheKey(uid);
		if (CacheService.TryGetValue<StatusScanedFileEnum?>(cacheKey, "StatusScanedService", out var value))
		{
			if (!value.HasValue)
			{
				return StatusScanedFileEnum.SCAN_FINISHED_ERROR;
			}
			return value.Value;
		}
		return StatusScanedFileEnum.SCAN_FINISHED_ERROR;
	}

	private static string GetCacheKey(Guid uid)
	{
		return "S_" + uid;
	}
}
