using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class FilterTypeAttribute : Attribute
{
	private Type filterType;

	private static FilterTypeAttribute kA5DeSo88bsor5XU9nrT;

	public Type FilterType => filterType;

	public FilterTypeAttribute(Type filterType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Qcg9LZo8IRctewcHBtJo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.filterType = filterType;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void Qcg9LZo8IRctewcHBtJo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dT2nHto8Z8caWLDIpaEG()
	{
		return kA5DeSo88bsor5XU9nrT == null;
	}

	internal static FilterTypeAttribute gQrG2jo8u0USwuukstYo()
	{
		return kA5DeSo88bsor5XU9nrT;
	}
}
