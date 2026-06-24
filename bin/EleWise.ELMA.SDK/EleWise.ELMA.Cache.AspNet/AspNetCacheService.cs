using System;
using System.Web;
using System.Web.Caching;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.AspNet;

public class AspNetCacheService : CacheService, INHCacheService
{
	private static AspNetCacheService shpxH1fKpqKwMu7OGK47;

	string INHCacheService.ProviderType => (string)S4FoXLfK6oV5aGBTy6ih(-951514650 ^ -951381880);

	protected override void InsertValue<T>(string key, object value, string region, TimeSpan cacheDuration, CacheItemRemovedCallback<T> onRemoveItemCallback)
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals0.onRemoveItemCallback = onRemoveItemCallback;
		DateTime absoluteExpiration = DateTime.Now.Add(cacheDuration);
		CacheDependency dependencies = null;
		if (region != null)
		{
			if (HttpRuntime.Cache.Get(region) == null)
			{
				HttpRuntime.Cache.Insert(region, new object(), null, absoluteExpiration, TimeSpan.Zero, CacheItemPriority.Normal, null);
			}
			dependencies = new CacheDependency(null, new string[1] { region });
		}
		HttpRuntime.Cache.Insert(key, CacheService.AssembleValue(value), dependencies, absoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Normal, (CS_0024_003C_003E8__locals0.onRemoveItemCallback == null) ? null : ((CacheItemRemovedCallback)delegate(string s, object o, System.Web.Caching.CacheItemRemovedReason reason)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.onRemoveItemCallback(s, CacheService.DisassembleValue<T>(o), (CacheItemRemovedReason)reason);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}));
	}

	protected override bool ContainsInternal(string key, string region)
	{
		return ((System.Web.Caching.Cache)Ln301EfKt9ijy8Gsj80h()).Get(key) != null;
	}

	protected override object GetValue(string key, string region)
	{
		return ((System.Web.Caching.Cache)Ln301EfKt9ijy8Gsj80h()).Get(key);
	}

	protected override void RemoveInternal(string key, string region)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (!string.IsNullOrEmpty(key))
				{
					owURaufKwvuKcmWMkm4P(Ln301EfKt9ijy8Gsj80h(), key);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void ClearRegionInternal(string region)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!W9naR1fK4nNNTm7VSe8i(region))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			case 1:
				owURaufKwvuKcmWMkm4P(Ln301EfKt9ijy8Gsj80h(), region);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public AspNetCacheService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Ln301EfKt9ijy8Gsj80h()
	{
		return HttpRuntime.Cache;
	}

	internal static bool lilA7DfKaW9X66w0i9ao()
	{
		return shpxH1fKpqKwMu7OGK47 == null;
	}

	internal static AspNetCacheService mR9s7MfKDClURLc9Mv8h()
	{
		return shpxH1fKpqKwMu7OGK47;
	}

	internal static object owURaufKwvuKcmWMkm4P(object P_0, object P_1)
	{
		return ((System.Web.Caching.Cache)P_0).Remove((string)P_1);
	}

	internal static bool W9naR1fK4nNNTm7VSe8i(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object S4FoXLfK6oV5aGBTy6ih(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
