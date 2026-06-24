using System;
using System.ComponentModel.DataAnnotations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

[AttributeUsage(AttributeTargets.All)]
public class RequiredFieldAttribute : RequiredAttribute
{
	internal static RequiredFieldAttribute i1G1ZJo5GX34hqBVmYUd;

	public RequiredFieldAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				tQacMRo5CoX4gi1CSQtt(this, SR.T((string)bbcwvmo5Q2GBP36J268x(0x12A5FAC7 ^ 0x12A5DBBD)));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public RequiredFieldAttribute(string message)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0098, IL_00a7
		rffO02o5v8vKdTHMOZp7();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				tQacMRo5CoX4gi1CSQtt(this, message);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 4;
				}
				break;
			case 3:
				message = (string)F8YYYIo584LBCWsG3yPc(bbcwvmo5Q2GBP36J268x(-1217523399 ^ -1217515453));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				if (!string.IsNullOrEmpty(message))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				return;
			}
		}
	}

	internal static object bbcwvmo5Q2GBP36J268x(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void tQacMRo5CoX4gi1CSQtt(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessage = (string)P_1;
	}

	internal static bool pw4DsQo5Eq9EC0buptNE()
	{
		return i1G1ZJo5GX34hqBVmYUd == null;
	}

	internal static RequiredFieldAttribute B33OHCo5fq45FOeveLl8()
	{
		return i1G1ZJo5GX34hqBVmYUd;
	}

	internal static void rffO02o5v8vKdTHMOZp7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object F8YYYIo584LBCWsG3yPc(object P_0)
	{
		return SR.T((string)P_0);
	}
}
