using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class NHCacheProviderWrapper : ICacheProvider
{
	private static readonly ICacheProvider provider;

	private static bool providerStarted;

	private static readonly ConcurrentDictionary<string, NHCacheWrapper> caches;

	internal static NHCacheProviderWrapper b1nJNOWaSsuT8ogs9Iq8;

	static NHCacheProviderWrapper()
	{
		//Discarded unreachable code: IL_00a6, IL_0113
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		INHCacheService iNHCacheService = default(INHCacheService);
		IRuntimeApplication service = default(IRuntimeApplication);
		string text = default(string);
		while (true)
		{
			object obj;
			object obj2;
			switch (num2)
			{
			default:
				if (iNHCacheService == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				obj = JGZY3wWaK15GWLrwaQ24(iNHCacheService);
				goto IL_014c;
			case 3:
				if (service == null)
				{
					num2 = 6;
					continue;
				}
				obj2 = service.Providers.OfType<INHCacheService>().FirstOrDefault();
				goto IL_0129;
			case 2:
				if (nTTlTCWaXaf2vtn6iGhS(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 6:
				obj2 = null;
				goto IL_0129;
			case 8:
				PoI4ErWaqaCq8VJMwgOV();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				text = (string)SH2LdIWaTYM7DBKVn0NC(--1333735954 ^ 0x4F7D2B7C);
				num2 = 9;
				continue;
			case 7:
				caches = new ConcurrentDictionary<string, NHCacheWrapper>();
				num2 = 10;
				continue;
			case 10:
				service = Locator.GetService<IRuntimeApplication>();
				num2 = 3;
				continue;
			case 5:
				return;
			case 4:
				obj = null;
				goto IL_014c;
			case 9:
				break;
				IL_014c:
				text = (string)obj;
				num2 = 2;
				continue;
				IL_0129:
				iNHCacheService = (INHCacheService)obj2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			Type type = TiERECWakkl22f3cnuWH(text);
			if (type == null)
			{
				break;
			}
			provider = (ICacheProvider)We1M6IWan657TNGNcipP(type);
			num2 = 5;
		}
		throw new InvalidOperationException((string)SH2LdIWaTYM7DBKVn0NC(0x638095EB ^ 0x63828FEF) + text);
	}

	public ICache BuildCache(string regionName, IDictionary<string, string> properties)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.regionName = regionName;
		CS_0024_003C_003E8__locals0.properties = properties;
		return (ICache)(object)caches.GetOrAdd(CS_0024_003C_003E8__locals0.regionName, delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ICache obj = provider.BuildCache(CS_0024_003C_003E8__locals0.regionName, CS_0024_003C_003E8__locals0.properties);
					CacheBase cache;
					if ((cache = (CacheBase)(object)((obj is CacheBase) ? obj : null)) != null)
					{
						return new NHCacheWrapper(cache);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return null;
				}
			}
		});
	}

	public long NextTimestamp()
	{
		return provider.NextTimestamp();
	}

	public void Start(IDictionary<string, string> properties)
	{
		if (!providerStarted)
		{
			provider.Start(properties);
			providerStarted = true;
		}
	}

	public void Stop()
	{
	}

	internal static bool TryGetCache(string region, out NHCacheWrapper cache)
	{
		return caches.TryGetValue(region, out cache);
	}

	public NHCacheProviderWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PoI4ErWaqaCq8VJMwgOV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void PoI4ErWaqaCq8VJMwgOV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object JGZY3wWaK15GWLrwaQ24(object P_0)
	{
		return ((INHCacheService)P_0).ProviderType;
	}

	internal static bool nTTlTCWaXaf2vtn6iGhS(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object SH2LdIWaTYM7DBKVn0NC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type TiERECWakkl22f3cnuWH(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object We1M6IWan657TNGNcipP(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static bool wEESRpWaik1Wa4BZqywG()
	{
		return b1nJNOWaSsuT8ogs9Iq8 == null;
	}

	internal static NHCacheProviderWrapper UOyRbJWaR53J80L5MVRG()
	{
		return b1nJNOWaSsuT8ogs9Iq8;
	}
}
