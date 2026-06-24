using System;
using System.Configuration.Provider;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class ProviderAdministration<TProvider> where TProvider : ProviderBase
{
	private TProvider _provider;

	private GenericProviderCollection<TProvider> _providers;

	internal static object nVlkrdfWkcQUcjfsaTSw;

	public TProvider Provider => _provider;

	public GenericProviderCollection<TProvider> Providers => _providers;

	public ProviderAdministration(ProviderSettingsFeatureSection personalizationConfig)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				_provider = _providers[personalizationConfig.DefaultProvider];
				num = 5;
				break;
			case 5:
				if (_provider == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 3:
				if (personalizationConfig == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num = 1;
					}
				}
				else
				{
					_providers = new GenericProviderCollection<TProvider>();
					num = 4;
				}
				break;
			default:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED9A81C), typeof(TProvider)));
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECB410A));
			case 4:
				ProvidersHelper.InstantiateProviders(personalizationConfig.Providers, _providers, typeof(TProvider));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	internal static bool zoC4VDfWnu4eaYhrmlk4()
	{
		return nVlkrdfWkcQUcjfsaTSw == null;
	}

	internal static object PjnJbhfWOoLtJRGhWaRP()
	{
		return nVlkrdfWkcQUcjfsaTSw;
	}
}
