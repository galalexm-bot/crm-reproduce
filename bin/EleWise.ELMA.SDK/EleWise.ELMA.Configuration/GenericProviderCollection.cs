using System;
using System.Configuration.Provider;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class GenericProviderCollection<T> : ProviderCollection where T : ProviderBase
{
	private static object ToZDHbfWiBHgx0IJ3q9p;

	public new T this[string name] => (T)base[name];

	public override void Add(ProviderBase provider)
	{
		//Discarded unreachable code: IL_00a7
		int num = 1;
		int num2 = num;
		string paramName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70099325));
			case 4:
				throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638733903), paramName);
			case 3:
				base.Add(provider);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				paramName = typeof(T).ToString();
				num2 = 4;
				break;
			case 2:
				return;
			case 1:
				if (provider != null)
				{
					if (provider as T != null)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public GenericProviderCollection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool csG1RtfWR4QY0jJ2CYjG()
	{
		return ToZDHbfWiBHgx0IJ3q9p == null;
	}

	internal static object a7Zv17fWqRc5oYTur7Fd()
	{
		return ToZDHbfWiBHgx0IJ3q9p;
	}
}
