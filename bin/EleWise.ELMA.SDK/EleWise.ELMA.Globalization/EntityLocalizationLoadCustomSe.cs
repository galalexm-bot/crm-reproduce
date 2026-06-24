using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Component]
public class EntityLocalizationLoadCustomSettings : ILocalizationLoadCustomSettings
{
	public static readonly Guid ExtensionUid;

	internal static EntityLocalizationLoadCustomSettings Uy082LGosV2PL8mbslTF;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			ExtensionUid,
			new EntityGlobalizationSettings()
		} };
	}

	public EntityLocalizationLoadCustomSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityLocalizationLoadCustomSettings()
	{
		int num = 2;
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
				ExtensionUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978570158));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				omJvi4GbFUJGkt15Rjvp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool IqVX3nGocFEJYULituTo()
	{
		return Uy082LGosV2PL8mbslTF == null;
	}

	internal static EntityLocalizationLoadCustomSettings wvZsqcGozdRwpc6DsLHX()
	{
		return Uy082LGosV2PL8mbslTF;
	}

	internal static void omJvi4GbFUJGkt15Rjvp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
