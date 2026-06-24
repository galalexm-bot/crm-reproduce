using System;
using System.Runtime.Caching;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(Order = 200)]
internal class WorkflowTablePartGridStateSaveModeProvider : ITablePartGridStateSaveModeProvider
{
	private const string CacheName = "WorkflowTablePartGridStateSaveModeProvider_MemoryCache";

	private static MemoryCache memoryCache;

	private static CacheItemPolicy DefaultCacheItemPolicy = new CacheItemPolicy
	{
		SlidingExpiration = TimeSpan.FromHours(1.0)
	};

	private readonly WorkflowTypesResolver workflowTypesResolver;

	private static MemoryCache MemoryCache
	{
		get
		{
			if (memoryCache == null)
			{
				memoryCache = memoryCache ?? new MemoryCache("WorkflowTablePartGridStateSaveModeProvider_MemoryCache");
			}
			return memoryCache;
		}
	}

	public WorkflowTablePartGridStateSaveModeProvider(WorkflowTypesResolver workflowTypesResolver)
	{
		this.workflowTypesResolver = workflowTypesResolver;
	}

	public GridStateSaveMode? GetGridStateSaveMode(Guid typeUid)
	{
		if (IsProcessContextBlock(typeUid))
		{
			return GridStateSaveMode.SaveInSession;
		}
		return null;
	}

	private bool IsProcessContextBlock(Guid typeUid)
	{
		if (typeUid == Guid.Empty)
		{
			return false;
		}
		bool? flag = TryLoadByCache(typeUid);
		if (flag.HasValue)
		{
			return flag.Value;
		}
		bool flag2 = workflowTypesResolver.FindRootMetadata(typeUid) is IProcessContext;
		MemoryCache.Set(GetCacheKeyByUid(typeUid), flag2, DefaultCacheItemPolicy);
		return flag2;
	}

	private bool? TryLoadByCache(Guid uid)
	{
		return MemoryCache.Get(GetCacheKeyByUid(uid)) as bool?;
	}

	private static string GetCacheKeyByUid(Guid uid)
	{
		return uid.ToString("N");
	}
}
