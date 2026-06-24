using System;
using System.Configuration.Provider;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class BLOBStoreProvider : ProviderBase, IBLOBDataManager
{
	private static BLOBStoreProvider OokFnLWGjyTgWDNs45mN;

	protected BLOBStoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public abstract void SetBLOB<T>(Guid uid, string key, T value);

	public abstract T GetBLOB<T>(Guid uid, string key);

	public abstract void RemoveBLOB<T>(Guid uid, string key);

	internal static bool iLsnfMWGYDodnVgdCtbb()
	{
		return OokFnLWGjyTgWDNs45mN == null;
	}

	internal static BLOBStoreProvider Hmb3eKWGLfhQ4Ah6F5Av()
	{
		return OokFnLWGjyTgWDNs45mN;
	}
}
