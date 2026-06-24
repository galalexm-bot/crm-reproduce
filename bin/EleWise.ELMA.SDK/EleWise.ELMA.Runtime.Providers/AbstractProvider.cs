using System;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class AbstractProvider : IProvider, IConfigurableProvider, IDisposable
{
	protected ProviderSettingsSection SettingsSection;

	internal static AbstractProvider ztoIJFWGdDEtLdgTrJjl;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public abstract ProviderSettingsSection CreateSettings();

	public virtual void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
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
				SettingsSection = settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual string GuidQuerySintaxis(Guid guid)
	{
		return string.Format((string)JW5DfkWGgUC4YWdhSCNX(0x12441CA4 ^ 0x12458148), guid.ToString());
	}

	public abstract void Init();

	public abstract void InitComplete();

	public virtual void Dispose()
	{
	}

	protected AbstractProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WDyat9WG5V2kq6gb1t1M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vWeiPsWGlkmJm9ic044V()
	{
		return ztoIJFWGdDEtLdgTrJjl == null;
	}

	internal static AbstractProvider cEqDc0WGr5qfVsI5XpU1()
	{
		return ztoIJFWGdDEtLdgTrJjl;
	}

	internal static object JW5DfkWGgUC4YWdhSCNX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WDyat9WG5V2kq6gb1t1M()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
