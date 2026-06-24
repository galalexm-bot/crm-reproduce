using System;
using System.Web;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service(Type = ComponentType.Web)]
public class TemporaryAuthenticationService : ITemporaryAuthenticationService
{
	private const string CacheKey = "EleWise.ELMA.Web.Mvc.Services.TemporaryAuthenticationService.List";

	public const string ContextKey = "TemporaryGuid";

	public ICacheService Cache { get; set; }

	public void Add(TemporaryAuthenticationInfo info)
	{
		Remove(info.Key);
		Cache.Insert(GetKey(info.Key), info);
	}

	public void Remove(Guid key)
	{
		Cache.Remove(GetKey(key));
	}

	public TemporaryAuthenticationInfo Get(Guid key)
	{
		return Cache.Get<TemporaryAuthenticationInfo>(GetKey(key));
	}

	public TemporaryAuthenticationInfo GetFromContext(HttpContextBase context)
	{
		string text = context.Request["TemporaryGuid"] ?? context.Request.Headers["TemporaryGuid"];
		if (!string.IsNullOrEmpty(text))
		{
			Guid key = new Guid(text);
			return Get(key);
		}
		return null;
	}

	private static string GetKey(Guid key)
	{
		return string.Format("{0}+{1}", "EleWise.ELMA.Web.Mvc.Services.TemporaryAuthenticationService.List", key);
	}
}
