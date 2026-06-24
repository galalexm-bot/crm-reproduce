using System;
using System.Configuration.Provider;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class GenericProviderManager<TProvider, TIRegister> : AbstractProvider where TProvider : ProviderBase
{
	protected TProvider DefaultProvider;

	internal static object kxsuugWEK2VaLabZPdGR;

	public override ProviderSettingsSection CreateSettings()
	{
		return Activator.CreateInstance(typeof(GenericProviderFeatureSection<>).MakeGenericType(GetType())) as ProviderSettingsSection;
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		//Discarded unreachable code: IL_0096, IL_00a5
		int num = 8;
		int num2 = num;
		Type type = default(Type);
		ProviderAdministration<TProvider> providerAdministration = default(ProviderAdministration<TProvider>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				type = typeof(GenericProviderFeatureSection<>).MakeGenericType(GetType());
				num2 = 4;
				break;
			case 5:
				DefaultProvider = providerAdministration.Provider;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				if (DefaultProvider == null)
				{
					num2 = 2;
					break;
				}
				if (!DefaultProvider.GetType().IsAssignableFrom(typeof(TIRegister)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710543060) + typeof(TProvider));
			case 6:
				throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767692709) + type);
			case 3:
				throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751217170) + typeof(TIRegister));
			case 8:
				base.Configure(settings, configuration);
				num2 = 7;
				break;
			case 4:
				if (SettingsSection.GetType().IsAssignableFrom(type))
				{
					providerAdministration = new ProviderAdministration<TProvider>((ProviderSettingsFeatureSection)settings);
					num2 = 5;
					break;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public override void Init()
	{
		//Discarded unreachable code: IL_0082, IL_0091
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (DefaultProvider != null)
				{
					num2 = 2;
					break;
				}
				return;
			case 1:
				return;
			case 2:
				RegistrationExtensions.PropertiesAutowired<TProvider, SimpleActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterInstance<TProvider>(ComponentManager.Builder, DefaultProvider).As<TIRegister>(), (PropertyWiringOptions)0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void InitComplete()
	{
	}

	protected GenericProviderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool snABvvWEXjqVI4AGJ2Z9()
	{
		return kxsuugWEK2VaLabZPdGR == null;
	}

	internal static object dEcOmYWETlpZjACr1JFJ()
	{
		return kxsuugWEK2VaLabZPdGR;
	}
}
