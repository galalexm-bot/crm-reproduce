using System.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

internal class DynamicPublicationSection : ConfigurationSection
{
	internal static DynamicPublicationSection ACeSEZfFwffQq1ZvLYBm;

	[ConfigurationProperty("disable", DefaultValue = false)]
	public bool Enable
	{
		get
		{
			return !(bool)eNH0lrfFAUqauRfKOxpf(this, vmS9FIfFH0nDNaXgf98f(-2099751081 ^ -2099423015));
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
					ykjeCQfF79Zkr23nlRBN(this, vmS9FIfFH0nDNaXgf98f(0x7459E02 ^ 0x740918C), !value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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

	public DynamicPublicationSection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tUNch2fFxrwvlQGOmo6s();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object vmS9FIfFH0nDNaXgf98f(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object eNH0lrfFAUqauRfKOxpf(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(string)P_1];
	}

	internal static bool PfLT0ufF4qOPcuQh6Uvh()
	{
		return ACeSEZfFwffQq1ZvLYBm == null;
	}

	internal static DynamicPublicationSection HrbWi3fF6QxU0QClHRl6()
	{
		return ACeSEZfFwffQq1ZvLYBm;
	}

	internal static void ykjeCQfF79Zkr23nlRBN(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(string)P_1] = P_2;
	}

	internal static void tUNch2fFxrwvlQGOmo6s()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
