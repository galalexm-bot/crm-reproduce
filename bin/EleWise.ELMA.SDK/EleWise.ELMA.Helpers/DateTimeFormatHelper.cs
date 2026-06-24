using System;
using System.Globalization;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class DateTimeFormatHelper
{
	internal static DateTimeFormatHelper C1HYAGhLmOCXFVfUwpkK;

	public static string GetCurrentFullFormat(string removeTemplate = null, bool forTelerik = true)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487357978);
	}

	public static string GetCurrentFullFormatWithSeconds(string removeTemplate = null, bool forTelerik = true)
	{
		int num = 2;
		int num2 = num;
		string arg = default(string);
		CultureInfo cultureInfo = default(CultureInfo);
		string arg2 = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				obj = n16SGShLJAi1hLPGSGBu(Locator.GetServiceNotNull<ILocalizationService>());
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00dd;
			case 3:
				arg = StringParseHelper.PrepareDateMask((string)Ef4WJphLlvrtxHXLmLsA(qHrRKAhLdirVNKUPbrxO(cultureInfo)), (string)d7j6cphLr3mCM8nGHxPP(qHrRKAhLdirVNKUPbrxO(cultureInfo)), removeTemplate);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				arg2 = (string)kKsYqXhLj3qYQ1Iy4pOo(d5tBHwhLg93K7cjvuH9u(0x6DC147B0 ^ 0x6DC2EF30), kL3qRfhL59JPPLFdxqtJ(qHrRKAhLdirVNKUPbrxO(cultureInfo)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				obj = kIHkMOhL9SKayT8PXmso();
				goto IL_00dd;
			default:
				{
					return string.Format((string)d5tBHwhLg93K7cjvuH9u(-1710575414 ^ -1710679978), arg, arg2, forTelerik ? d5tBHwhLg93K7cjvuH9u(-1459557599 ^ -1459403883) : "");
				}
				IL_00dd:
				cultureInfo = (CultureInfo)obj;
				num2 = 3;
				break;
			}
		}
	}

	public static string GetCurrentShortFormat(string removeTemplate = null)
	{
		int num = 2;
		int num2 = num;
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return StringParseHelper.PrepareDateMask((string)Ef4WJphLlvrtxHXLmLsA(cultureInfo.DateTimeFormat), (string)d7j6cphLr3mCM8nGHxPP(qHrRKAhLdirVNKUPbrxO(cultureInfo)), removeTemplate);
			case 2:
				obj = Locator.GetServiceNotNull<ILocalizationService>().Load();
				if (obj != null)
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				obj = kIHkMOhL9SKayT8PXmso();
				break;
			}
			cultureInfo = (CultureInfo)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static string GetCurrentWithShortYearFormat()
	{
		//Discarded unreachable code: IL_0076, IL_015b, IL_016a, IL_01bf
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		CultureInfo cultureInfo = default(CultureInfo);
		string[] array = default(string[]);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 13:
				num3 = 0;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 4;
				}
				continue;
			case 12:
				return string.Join(((DateTimeFormatInfo)qHrRKAhLdirVNKUPbrxO(cultureInfo)).DateSeparator, array);
			case 3:
			case 4:
				if (num3 >= array.Length)
				{
					num2 = 12;
					continue;
				}
				goto case 7;
			case 5:
				if (Kv6an0hLUQtVGk875bgQ(array[num3]) <= 2)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 10;
			case 6:
			case 8:
			case 9:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				if (!array[num3].StartsWith((string)d5tBHwhLg93K7cjvuH9u(-541731959 ^ -541689033)))
				{
					num2 = 11;
					continue;
				}
				goto case 10;
			case 11:
				if (!VARRVOhLLJhUU4GhH9Jk(array[num3], d5tBHwhLg93K7cjvuH9u(-2106517564 ^ -2106409216)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 5;
			case 2:
				array = (string[])NEivvNhLYSDGwAR3YhVr(StringParseHelper.PrepareDateMask((string)Ef4WJphLlvrtxHXLmLsA(qHrRKAhLdirVNKUPbrxO(cultureInfo)), ((DateTimeFormatInfo)qHrRKAhLdirVNKUPbrxO(cultureInfo)).DateSeparator), new string[1] { (string)d7j6cphLr3mCM8nGHxPP(cultureInfo.DateTimeFormat) }, StringSplitOptions.RemoveEmptyEntries);
				num2 = 13;
				continue;
			case 10:
				array[num3] = (string)sNYOPlhLsQW78jHM7P2t(array[num3], 0, 2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 9;
				}
				continue;
			case 1:
				obj = n16SGShLJAi1hLPGSGBu(Locator.GetServiceNotNull<ILocalizationService>());
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = kIHkMOhL9SKayT8PXmso();
				break;
			}
			cultureInfo = (CultureInfo)obj;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static string ToCurrentFullFormat(this DateTime date)
	{
		return date.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957860416));
	}

	public static string ToCurrentFullFormatNotYear(this DateTime date)
	{
		return date.ToString((string)UOcGtjhLcnsMhgs4p0WG(d5tBHwhLg93K7cjvuH9u(0x53CACA3 ^ 0x53F0469)));
	}

	public static string ToCurrentShortFormat(this DateTime date)
	{
		return date.ToString((string)d5tBHwhLg93K7cjvuH9u(-29254301 ^ -29188735));
	}

	public static string ToCurrentWithShortYearFormat(this DateTime date)
	{
		return date.ToString((string)UOcGtjhLcnsMhgs4p0WG(d5tBHwhLg93K7cjvuH9u(-1334993905 ^ -1334954771)));
	}

	internal static bool FduWCuhLyFRRiSspenTH()
	{
		return C1HYAGhLmOCXFVfUwpkK == null;
	}

	internal static DateTimeFormatHelper tYLb6BhLMA1Go62DoeZH()
	{
		return C1HYAGhLmOCXFVfUwpkK;
	}

	internal static object n16SGShLJAi1hLPGSGBu(object P_0)
	{
		return ((ILocalizationService)P_0).Load();
	}

	internal static object kIHkMOhL9SKayT8PXmso()
	{
		return SR.GetDefaultCulture();
	}

	internal static object qHrRKAhLdirVNKUPbrxO(object P_0)
	{
		return ((CultureInfo)P_0).DateTimeFormat;
	}

	internal static object Ef4WJphLlvrtxHXLmLsA(object P_0)
	{
		return ((DateTimeFormatInfo)P_0).ShortDatePattern;
	}

	internal static object d7j6cphLr3mCM8nGHxPP(object P_0)
	{
		return ((DateTimeFormatInfo)P_0).DateSeparator;
	}

	internal static object d5tBHwhLg93K7cjvuH9u(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kL3qRfhL59JPPLFdxqtJ(object P_0)
	{
		return ((DateTimeFormatInfo)P_0).TimeSeparator;
	}

	internal static object kKsYqXhLj3qYQ1Iy4pOo(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object NEivvNhLYSDGwAR3YhVr(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool VARRVOhLLJhUU4GhH9Jk(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static int Kv6an0hLUQtVGk875bgQ(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object sNYOPlhLsQW78jHM7P2t(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object UOcGtjhLcnsMhgs4p0WG(object P_0)
	{
		return SR.T((string)P_0);
	}
}
