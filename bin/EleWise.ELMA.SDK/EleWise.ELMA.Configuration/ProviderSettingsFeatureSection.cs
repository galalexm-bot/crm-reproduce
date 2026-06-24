using System;
using System.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public abstract class ProviderSettingsFeatureSection : ProviderSettingsSection
{
	private readonly ConfigurationProperty _defaultProvider;

	private readonly ConfigurationProperty _providers;

	internal static ProviderSettingsFeatureSection w6UJIDfW2B19s8veqFqx;

	[ConfigurationProperty("defaultProvider", IsRequired = true)]
	public string DefaultProvider
	{
		get
		{
			return (string)E2yhjifW1EcddxpDerWn(this, _defaultProvider);
		}
		set
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
					UTL6hdfWNCB5YMV2gnpK(this, _defaultProvider, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ConfigurationProperty("providers", IsRequired = true)]
	public ProviderSettingsCollection Providers
	{
		get
		{
			return (ProviderSettingsCollection)E2yhjifW1EcddxpDerWn(this, _providers);
		}
		set
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
					UTL6hdfWNCB5YMV2gnpK(this, _providers, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected ProviderSettingsFeatureSection()
	{
		//Discarded unreachable code: IL_0086, IL_008b
		OK3tJtfW3ECyPHM5EK9j();
		_defaultProvider = new ConfigurationProperty((string)WmK0r4fWpGR2IZ4cuo8S(-1108654032 ^ -1108452700), RMI2dZfWaH0ExbAoRwmn(typeof(string).TypeHandle), null);
		_providers = new ConfigurationProperty((string)WmK0r4fWpGR2IZ4cuo8S(-398663332 ^ -398622558), RMI2dZfWaH0ExbAoRwmn(typeof(ProviderSettingsCollection).TypeHandle), null);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object E2yhjifW1EcddxpDerWn(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(ConfigurationProperty)P_1];
	}

	internal static bool fbIEABfWenyB5Bp7NhSL()
	{
		return w6UJIDfW2B19s8veqFqx == null;
	}

	internal static ProviderSettingsFeatureSection InTtIwfWPJcgjFndqypC()
	{
		return w6UJIDfW2B19s8veqFqx;
	}

	internal static void UTL6hdfWNCB5YMV2gnpK(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(ConfigurationProperty)P_1] = P_2;
	}

	internal static void OK3tJtfW3ECyPHM5EK9j()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object WmK0r4fWpGR2IZ4cuo8S(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type RMI2dZfWaH0ExbAoRwmn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
