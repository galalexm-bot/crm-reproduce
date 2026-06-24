using System;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache;

public class CacheServiceManager : GenericProviderManager<CacheService, ICacheService>, INHCacheService
{
	public const string UID_S = "{100485AD-DADC-4095-82F1-58F5B0833C13}";

	public static readonly Guid UID;

	internal static CacheServiceManager n1J5QBfKbCoBrRCDjhXO;

	public override Guid Uid => UID;

	public override string Name => (string)FYAdrafKE5rrQYXwv0gj(-812025778 ^ -812003244);

	public ICacheService DefaultCacheService => DefaultProvider;

	string INHCacheService.ProviderType
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					if (DefaultProvider is INHCacheService)
					{
						return (string)fdwdcmfKQjRNgL0EtoNw((INHCacheService)DefaultProvider);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				DefaultProvider.Configure(settings, configuration);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				tHbPPXfKfGALREtoImx1(this, settings, configuration);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CacheServiceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IKwDocfKCjXEWrQKIsrp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CacheServiceManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)FYAdrafKE5rrQYXwv0gj(-70007027 ^ -69827735));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				IKwDocfKCjXEWrQKIsrp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object FYAdrafKE5rrQYXwv0gj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool JCVqe7fKhSxaIk9dBH2T()
	{
		return n1J5QBfKbCoBrRCDjhXO == null;
	}

	internal static CacheServiceManager gKD93BfKGtnu31kSSgL7()
	{
		return n1J5QBfKbCoBrRCDjhXO;
	}

	internal static void tHbPPXfKfGALREtoImx1(object P_0, object P_1, object P_2)
	{
		((GenericProviderManager<CacheService, ICacheService>)P_0).Configure((ProviderSettingsSection)P_1, (RuntimeConfiguration)P_2);
	}

	internal static object fdwdcmfKQjRNgL0EtoNw(object P_0)
	{
		return ((INHCacheService)P_0).ProviderType;
	}

	internal static void IKwDocfKCjXEWrQKIsrp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
