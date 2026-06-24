using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

public class LazyWithReset<T>
{
	private Lazy<T> lazy;

	private readonly Func<T> factory;

	internal static object pokFURG6pLicGDLEr5v0;

	public T Value => lazy.Value;

	public LazyWithReset(Func<T> factory)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.factory = factory;
		lazy = new Lazy<T>(factory);
	}

	public void Reset()
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
				lazy = new Lazy<T>(factory);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool D1Zq7BG6aiSGrJqsC40O()
	{
		return pokFURG6pLicGDLEr5v0 == null;
	}

	internal static object UgUBeiG6DPbB9Ziu3Abm()
	{
		return pokFURG6pLicGDLEr5v0;
	}
}
