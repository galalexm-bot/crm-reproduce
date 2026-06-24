using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.WebForms;

public class DefaultViewLocationCache : IViewLocationCache
{
	private static readonly TimeSpan _timeSpan = new TimeSpan(0, 15, 0);

	private static List<IMapVirtualPathProvider> _mapVirtualPathProviders;

	private static readonly object _mapVirtualPathProvidersLocker = new object();

	internal static IEnumerable<IMapVirtualPathProvider> MapVirtualPathProviders
	{
		get
		{
			if (_mapVirtualPathProviders != null)
			{
				return _mapVirtualPathProviders;
			}
			lock (_mapVirtualPathProvidersLocker)
			{
				if (_mapVirtualPathProviders != null)
				{
					return _mapVirtualPathProviders;
				}
				List<IMapVirtualPathProvider> list = new List<IMapVirtualPathProvider>();
				for (VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider; virtualPathProvider != null; virtualPathProvider = GetPrevious(virtualPathProvider))
				{
					if (virtualPathProvider is IMapVirtualPathProvider)
					{
						list.Add(virtualPathProvider as IMapVirtualPathProvider);
					}
				}
				return _mapVirtualPathProviders = list;
			}
		}
	}

	public string GetViewLocation(HttpContextBase httpContext, string key)
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		return (string)httpContext.Cache[key];
	}

	public static VirtualPathProvider GetPrevious(VirtualPathProvider virtualPathProvider)
	{
		return (VirtualPathProvider)virtualPathProvider.GetType().GetProperty("Previous", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(virtualPathProvider, null);
	}

	public void InsertViewLocation(HttpContextBase httpContext, string key, string virtualPath)
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		string text = MapVirtualPathProviders.Select((IMapVirtualPathProvider p) => p.GetExistsFilePath(virtualPath)).FirstOrDefault((string p) => p != null);
		if (text != null)
		{
			httpContext.Cache.Insert(key, virtualPath, new CacheDependency(text));
		}
		else
		{
			httpContext.Cache.Insert(key, virtualPath, null, System.Web.Caching.Cache.NoAbsoluteExpiration, _timeSpan);
		}
	}
}
