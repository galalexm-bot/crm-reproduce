using System;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class DateExtension
{
	internal static DateExtension HjVOqxG4AgaaAK4UnTWu;

	public static bool EqualsUpToMinute(this DateTime date, DateTime equals)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (date.Month == equals.Month)
					{
						goto end_IL_0012;
					}
					goto IL_00bc;
				default:
					if (date.Hour == equals.Hour)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00bc;
				case 4:
					if (date.Day == equals.Day)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00bc;
				case 1:
					return date.Minute == equals.Minute;
				case 3:
					{
						if (date.Year == equals.Year)
						{
							num2 = 2;
							break;
						}
						goto IL_00bc;
					}
					IL_00bc:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static DateTime NormalizeStartDate(this DateTime dateTime, bool time)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = wXImdtG405K1hRLLTDKj() != eV5nY3G4m51HoQ3hnFX8();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, (time || flag) ? dateTime.Hour : 0, (time || flag) ? dateTime.Minute : 0, (!time) ? 10 : 0);
			}
		}
	}

	public static DateTime NormalizeEndDate(this DateTime dateTime, bool time)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = wXImdtG405K1hRLLTDKj() != eV5nY3G4m51HoQ3hnFX8();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, (time || flag) ? dateTime.Hour : 23, (time || flag) ? dateTime.Minute : 59, (!time) ? 50 : 0);
			}
		}
	}

	public static string DamperStartDateTime(this DateTime dateTime)
	{
		//Discarded unreachable code: IL_00c0
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return text;
			case 2:
				text = dateTime.ToShortDateString();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				text = (string)GyaHCwG4MZAg2PJ2LWf4(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE394AB), dateTime.ToShortTimeString());
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				if (!W4GPGhG4yCjEqoxjW80b(dateTime))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static string DamperEndDateTime(this DateTime dateTime)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (A0AQIaG4JpDhyD1F9dOA(dateTime))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return text;
			case 3:
				text = dateTime.ToShortDateString();
				num2 = 2;
				break;
			default:
				text = (string)GyaHCwG4MZAg2PJ2LWf4(text, NCvAuYG49X995jFfgxtU(0x1C9495B4 ^ 0x1C94DC96), dateTime.ToShortTimeString());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static bool IsStartDamperTime(this DateTime dateTime)
	{
		//Discarded unreachable code: IL_0043
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return dateTime.Second > 10;
			case 1:
				return true;
			case 3:
				if (dateTime.Minute == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				if (dateTime.Second < 1)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 4:
				if (dateTime.Hour == 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public static bool IsEndDamperTime(this DateTime dateTime)
	{
		//Discarded unreachable code: IL_0083, IL_0092
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return dateTime.Second > 59;
			case 3:
				return true;
			case 2:
				if (dateTime.Hour == 23)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				if (dateTime.Minute == 59)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 4:
				if (dateTime.Second < 50)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public static bool IsStartDamperTimeBySeconds(this DateTime dateTime)
	{
		//Discarded unreachable code: IL_0054, IL_0063
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (dateTime.Second < 1)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return dateTime.Second > 10;
			case 1:
				return true;
			}
		}
	}

	public static bool IsEndDamperTimeBySeconds(this DateTime dateTime)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (dateTime.Second >= 50)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return dateTime.Second > 59;
			}
		}
	}

	public static int LeadMinutesToFifteen(this int minutes)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0057
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (minutes >= 30)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				if (minutes < 45)
				{
					num2 = 4;
					break;
				}
				return 45;
			default:
				return 0;
			case 3:
				return 15;
			case 1:
				return 30;
			case 2:
				if (minutes >= 15)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public static string DamperStartDateTime(this DateTime? dateTime)
	{
		if (!dateTime.HasValue)
		{
			return string.Empty;
		}
		return dateTime.Value.DamperStartDateTime();
	}

	public static string DamperEndDateTime(this DateTime? dateTime)
	{
		if (!dateTime.HasValue)
		{
			return string.Empty;
		}
		return dateTime.Value.DamperEndDateTime();
	}

	public static DateTime ConvertUtcToLocal(this DateTime dateTime)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				return dateTime2.ToLocalTime();
			case 1:
				dateTime2 = n7tFd3G4dIDNiGgSWnLQ(dateTime, DateTimeKind.Utc);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool IsToday(this DateTime runtimeDateTime)
	{
		return rZQFecG4rJdqipQRiwIO(runtimeDateTime.Date, JkG18MG4lg4ZGbcUUf74());
	}

	public static string ToDisplayDateString(this DateTime runtimeDateTime)
	{
		//Discarded unreachable code: IL_011f
		int num = 2;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (runtimeDateTime.IsToday())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!(runtimeDateTime.Date == dateTime.AddDays(1.0)))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			default:
				return SR.Today;
			case 3:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C3B98F));
			case 4:
				if (rZQFecG4rJdqipQRiwIO(runtimeDateTime.Date, dateTime.AddDays(-1.0)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 5;
					}
					break;
				}
				return runtimeDateTime.ToLongDateString();
			case 2:
				dateTime = JkG18MG4lg4ZGbcUUf74();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return (string)chDfxaG4gvuOogEyJf0n(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138280453));
			}
		}
	}

	public static bool IsCurrentClientDate(this DateTime clientDateTime)
	{
		return rZQFecG4rJdqipQRiwIO(clientDateTime.Date, HNRFDrG451BNIbkkcyl6());
	}

	public static string DamperStartDateTimeWithTransformationToClient(this DateTime? runtimeDateTime)
	{
		if (!runtimeDateTime.HasValue)
		{
			return string.Empty;
		}
		return runtimeDateTime.Value.ToClientDateTime(TZ.Client).DamperStartDateTime();
	}

	public static string DamperEndDateTimeWithTransformationToClient(this DateTime? runtimeDateTime)
	{
		if (!runtimeDateTime.HasValue)
		{
			return string.Empty;
		}
		return runtimeDateTime.Value.ToClientDateTime(TZ.Client).DamperEndDateTime();
	}

	internal static bool fgpewZG47wMC4eAi8AMa()
	{
		return HjVOqxG4AgaaAK4UnTWu == null;
	}

	internal static DateExtension qT41jbG4xdmwaxWvnChV()
	{
		return HjVOqxG4AgaaAK4UnTWu;
	}

	internal static int wXImdtG405K1hRLLTDKj()
	{
		return TZ.ClientOffset;
	}

	internal static int eV5nY3G4m51HoQ3hnFX8()
	{
		return TZ.ServerOffset;
	}

	internal static bool W4GPGhG4yCjEqoxjW80b(DateTime dateTime)
	{
		return dateTime.IsStartDamperTime();
	}

	internal static object GyaHCwG4MZAg2PJ2LWf4(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool A0AQIaG4JpDhyD1F9dOA(DateTime dateTime)
	{
		return dateTime.IsEndDamperTime();
	}

	internal static object NCvAuYG49X995jFfgxtU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime n7tFd3G4dIDNiGgSWnLQ(DateTime P_0, DateTimeKind P_1)
	{
		return DateTime.SpecifyKind(P_0, P_1);
	}

	internal static DateTime JkG18MG4lg4ZGbcUUf74()
	{
		return DateTime.Today;
	}

	internal static bool rZQFecG4rJdqipQRiwIO(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static object chDfxaG4gvuOogEyJf0n(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static DateTime HNRFDrG451BNIbkkcyl6()
	{
		return TZ.CurrentClientDate;
	}
}
