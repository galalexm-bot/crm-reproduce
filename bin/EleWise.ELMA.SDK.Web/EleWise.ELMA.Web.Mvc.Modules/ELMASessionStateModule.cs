using System;
using System.Globalization;
using System.Web;
using System.Web.SessionState;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Modules;

public sealed class ELMASessionStateModule : LockFreeSessionStateModule
{
	private enum ProviderType
	{
		NotSelected,
		HashTable,
		DBTable,
		Cache
	}

	private LockFreeSessionStateModule internalImpl;

	private readonly object lockObject = new object();

	private ProviderType providerType;

	private static readonly object DisableSessionKey = new object();

	private LockFreeSessionStateModule Internal
	{
		get
		{
			if (internalImpl != null)
			{
				return internalImpl;
			}
			if (!Locator.Initialized)
			{
				return null;
			}
			ICacheService service = Locator.GetService<ICacheService>();
			if (service == null)
			{
				return null;
			}
			lock (lockObject)
			{
				if (internalImpl != null)
				{
					return internalImpl;
				}
				ProviderType providerType = this.providerType;
				if (providerType == ProviderType.DBTable)
				{
					goto IL_005c;
				}
				if (providerType == ProviderType.Cache)
				{
					internalImpl = new CacheSessionStateModule(Timeout, CookieMode);
				}
				else
				{
					if (service.IsDistributed)
					{
						goto IL_005c;
					}
					internalImpl = new HashTableSessionStateModule(Timeout, CookieMode);
				}
				goto IL_00ad;
				IL_00ad:
				internalImpl.OnInit();
				goto end_IL_002c;
				IL_005c:
				internalImpl = new DBTableSessionStateModule(Timeout, CookieMode);
				goto IL_00ad;
				end_IL_002c:;
			}
			return internalImpl;
		}
	}

	public static bool DisableSession
	{
		internal get
		{
			return ((bool?)HttpContext.Current.Items[DisableSessionKey]) ?? false;
		}
		set
		{
			HttpContext.Current.Items[DisableSessionKey] = value;
		}
	}

	protected internal override void OnInit()
	{
		base.OnInit();
		if (!string.IsNullOrWhiteSpace(PartitionResolverType))
		{
			string text = PartitionResolverType.ToLower(CultureInfo.InvariantCulture);
			switch (text)
			{
			case "hashtable":
				providerType = ProviderType.HashTable;
				break;
			case "dbtable":
				providerType = ProviderType.DBTable;
				break;
			case "cache":
				providerType = ProviderType.Cache;
				break;
			default:
				throw new InvalidOperationException($"Unsupported session type '{text}'");
			}
		}
	}

	protected internal override SessionItem AddNewSessionItem(string sessionId, HttpStaticObjectsCollection staticObjects)
	{
		if (Internal != null)
		{
			return Internal.AddNewSessionItem(sessionId, staticObjects);
		}
		return new SessionItem
		{
			Items = new SessionStateItemCollection(),
			StaticObjects = staticObjects
		};
	}

	protected internal override SessionItem GetSessionItem(string sessionId)
	{
		if (Internal != null)
		{
			return Internal.GetSessionItem(sessionId);
		}
		return null;
	}

	protected internal override void SaveAndReleaseSessionItem(string sessionId, ISessionStateItemCollection sessionItems, byte[] sessionOriginalDataArray, HttpStaticObjectsCollection sessionStaticObjects)
	{
		if (Internal != null)
		{
			Internal.SaveAndReleaseSessionItem(sessionId, sessionItems, sessionOriginalDataArray, sessionStaticObjects);
		}
	}

	protected internal override void RemoveSessionItem(string sessionId)
	{
		if (Internal != null)
		{
			Internal.RemoveSessionItem(sessionId);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && Internal != null)
		{
			Internal.Dispose();
		}
	}

	protected internal override void Release()
	{
		if (Internal != null)
		{
			Internal.Release();
		}
	}
}
