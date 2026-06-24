using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RangeDateTimeAttribute : ValidationAttribute
{
	internal static RangeDateTimeAttribute aV3Rmhogbcl681x4gSLd;

	public string Min
	{
		[CompilerGenerated]
		get
		{
			return _003CMin_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CMin_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	public string Max
	{
		[CompilerGenerated]
		get
		{
			return _003CMax_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CMax_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private static string GetMessage(object minimum, object maximum)
	{
		//Discarded unreachable code: IL_006a, IL_01da, IL_01e9, IL_01f9, IL_0258
		int num = 10;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (LMxPB8ogQ5rlFWlmLR9b(minimum))
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 2:
				if (!string.IsNullOrEmpty((string)maximum))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 3:
			case 5:
			case 12:
				if (!LMxPB8ogQ5rlFWlmLR9b(minimum))
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 1:
			case 6:
			case 11:
				return result;
			case 7:
				if (LMxPB8ogQ5rlFWlmLR9b(maximum))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 4:
				result = (string)DSLupTog8BQB7V2qUvy5(H70cFeogf7xixKqpB68g(rTj787ogEwfmbH70umkx(0x57A5235E ^ 0x57A50520)), new DateTime(ayX6Y6ogCsRa0rlNBXkK(maximum)).ToString((string)rTj787ogEwfmbH70umkx(-542721635 ^ -542749155)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 6;
				}
				break;
			default:
				result = (string)aULF8mogvOJwZQOgsog0(H70cFeogf7xixKqpB68g(rTj787ogEwfmbH70umkx(-3333094 ^ -3341822)), new DateTime(ayX6Y6ogCsRa0rlNBXkK(minimum)).ToString((string)rTj787ogEwfmbH70umkx(0x7247028A ^ 0x7247F50A)), new DateTime(ayX6Y6ogCsRa0rlNBXkK(maximum)).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867765300)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				result = (string)H70cFeogf7xixKqpB68g(rTj787ogEwfmbH70umkx(-867826612 ^ -867819082));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 9;
				}
				break;
			case 8:
				result = (string)DSLupTog8BQB7V2qUvy5(H70cFeogf7xixKqpB68g(rTj787ogEwfmbH70umkx(0x7E6E5A0B ^ 0x7E6E7CC7)), new DateTime(ayX6Y6ogCsRa0rlNBXkK(minimum)).ToString((string)rTj787ogEwfmbH70umkx(0x5DD55050 ^ 0x5DD5A7D0)));
				num2 = 11;
				break;
			}
		}
	}

	public RangeDateTimeAttribute(string min, string max)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oZ6DfrogZDj0k538CAym();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				Min = min;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num = 2;
				}
				break;
			case 2:
				Max = max;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				base.ErrorMessage = (string)r7l0Rjogu0ElvxfN2f60(Min, Max);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public RangeDateTimeAttribute(string min, string max, string message)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				Max = max;
				num = 4;
				continue;
			case 4:
				if (LMxPB8ogQ5rlFWlmLR9b(message))
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				message = (string)r7l0Rjogu0ElvxfN2f60(Min, Max);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				Min = min;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num = 3;
				}
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			LeoJsuogIeTmCyOMEjgV(this, message);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
			{
				num = 0;
			}
		}
	}

	private bool CalcValid(DateTime d)
	{
		//Discarded unreachable code: IL_008c, IL_009b, IL_00ab, IL_00ba, IL_00ca, IL_00d9, IL_0130
		int num = 6;
		int num2 = num;
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				if (LMxPB8ogQ5rlFWlmLR9b(Max))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 3;
			case 9:
				return ja8Gw2ogVJUcTtr2gAT4(new DateTime(Convert.ToInt64(Max)), d);
			case 3:
			{
				DateTime dateTime = new DateTime(ayX6Y6ogCsRa0rlNBXkK(Min));
				dateTime2 = new DateTime(ayX6Y6ogCsRa0rlNBXkK(Max));
				if (!(dateTime < d))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			}
			case 4:
				return ja8Gw2ogVJUcTtr2gAT4(dateTime2, d);
			case 8:
				return false;
			case 5:
			case 7:
				if (string.IsNullOrEmpty(Min))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 6:
				if (LMxPB8ogQ5rlFWlmLR9b(Min))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 1:
				return Rko5gtogS6A6aHXZU6W7(new DateTime(ayX6Y6ogCsRa0rlNBXkK(Min)), d);
			case 2:
				if (LMxPB8ogQ5rlFWlmLR9b(Max))
				{
					return true;
				}
				num2 = 9;
				break;
			}
		}
	}

	public override bool IsValid(object value)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 3;
		int num2 = num;
		DateTime d = default(DateTime);
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return CalcValid(d);
			case 6:
				return CalcValid((DateTime)value);
			case 5:
				return false;
			case 3:
				if (value == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					break;
				}
				if (!(value is string))
				{
					if (!(value is DateTime))
					{
						num2 = 5;
						break;
					}
					goto case 6;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				d = new DateTime(result);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (long.TryParse((string)value, out result))
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 2:
				return true;
			}
		}
	}

	internal static object rTj787ogEwfmbH70umkx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object H70cFeogf7xixKqpB68g(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool LMxPB8ogQ5rlFWlmLR9b(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static long ayX6Y6ogCsRa0rlNBXkK(object P_0)
	{
		return Convert.ToInt64((string)P_0);
	}

	internal static object aULF8mogvOJwZQOgsog0(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object DSLupTog8BQB7V2qUvy5(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool D4J5ePoghMjrVZeRxBRv()
	{
		return aV3Rmhogbcl681x4gSLd == null;
	}

	internal static RangeDateTimeAttribute iDG0H2ogGDEPmOb67uiJ()
	{
		return aV3Rmhogbcl681x4gSLd;
	}

	internal static void oZ6DfrogZDj0k538CAym()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object r7l0Rjogu0ElvxfN2f60(object P_0, object P_1)
	{
		return GetMessage(P_0, P_1);
	}

	internal static void LeoJsuogIeTmCyOMEjgV(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessage = (string)P_1;
	}

	internal static bool ja8Gw2ogVJUcTtr2gAT4(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static bool Rko5gtogS6A6aHXZU6W7(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}
}
