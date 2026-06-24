using System;
using System.Configuration;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Configuration;

public class GenericProviderFeatureSection<T> : ProviderSettingsFeatureSection where T : class, IProvider, new()
{
	private static object iZwXN3fWKHbe4P2LKCBm;

	[ConfigurationProperty("type", IsRequired = false, IsKey = true)]
	public override Type ProviderType
	{
		get
		{
			return typeof(T);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public GenericProviderFeatureSection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool B1t0ALfWX0qCl20dBHPc()
	{
		return iZwXN3fWKHbe4P2LKCBm == null;
	}

	internal static object nS6s7hfWTHtCD82oJU0e()
	{
		return iZwXN3fWKHbe4P2LKCBm;
	}
}
