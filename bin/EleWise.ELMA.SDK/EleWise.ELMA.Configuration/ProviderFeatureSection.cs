using System;
using System.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public abstract class ProviderFeatureSection : ConfigurationSection
{
	private readonly ConfigurationProperty _defaultProvider;

	private readonly ConfigurationProperty _providers;

	private readonly ConfigurationPropertyCollection _properties;

	internal static ProviderFeatureSection nejYWLfWsUP3xpkZoBtP;

	[ConfigurationProperty("defaultProvider", IsRequired = true)]
	public string DefaultProvider
	{
		get
		{
			return (string)Bq9lnOfobQf6KGbXwpWE(this, _defaultProvider);
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
				case 0:
					return;
				case 1:
					owB7VMfohETYs2nQniF8(this, _defaultProvider, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ConfigurationProperty("providers", IsRequired = true)]
	public ProviderSettingsCollection Providers => (ProviderSettingsCollection)Bq9lnOfobQf6KGbXwpWE(this, _providers);

	protected internal override ConfigurationPropertyCollection Properties
	{
		protected get
		{
			return _properties;
		}
	}

	public ProviderFeatureSection()
	{
		//Discarded unreachable code: IL_009c, IL_00a1
		G6T6fRfoFIepI20GdAFJ();
		_defaultProvider = new ConfigurationProperty((string)d8Cf4QfoBvnuNg7B64NA(0x6DC147B0 ^ 0x6DC45524), dvZfU4foWt8iR8u0rUjs(typeof(string).TypeHandle), null);
		_providers = new ConfigurationProperty((string)d8Cf4QfoBvnuNg7B64NA(0x49E27B8A ^ 0x49E31A74), typeof(ProviderSettingsCollection), null);
		_properties = new ConfigurationPropertyCollection();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				xZxM87foogSWUwlMwOdM(_properties, _defaultProvider);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				xZxM87foogSWUwlMwOdM(_properties, _providers);
				num = 2;
				break;
			}
		}
	}

	internal static void G6T6fRfoFIepI20GdAFJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object d8Cf4QfoBvnuNg7B64NA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type dvZfU4foWt8iR8u0rUjs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void xZxM87foogSWUwlMwOdM(object P_0, object P_1)
	{
		((ConfigurationPropertyCollection)P_0).Add((ConfigurationProperty)P_1);
	}

	internal static bool t7pLo9fWcDWTpSHRfBaY()
	{
		return nejYWLfWsUP3xpkZoBtP == null;
	}

	internal static ProviderFeatureSection wlQde1fWzXisARHA7ClF()
	{
		return nejYWLfWsUP3xpkZoBtP;
	}

	internal static object Bq9lnOfobQf6KGbXwpWE(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(ConfigurationProperty)P_1];
	}

	internal static void owB7VMfohETYs2nQniF8(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(ConfigurationProperty)P_1] = P_2;
	}
}
