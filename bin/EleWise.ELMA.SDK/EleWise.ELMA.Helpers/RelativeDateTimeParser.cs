using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Common;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class RelativeDateTimeParser
{
	private enum RelativeDateTimeMeter
	{
		Hour,
		Day,
		Week,
		Month,
		Quarter,
		Year
	}

	private static RelativeDateTimeParser jVjkP7hjYKdFyOHI4xYL;

	public static string Hour => (string)JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter.Hour);

	public static string Day => (string)JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter.Day);

	public static string Week => SR(RelativeDateTimeMeter.Week);

	public static string Month => (string)JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter.Month);

	public static string Quarter => (string)JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter.Quarter);

	public static string Year => (string)JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter.Year);

	public static bool TryParseFromDate(string str, out DateTime? result, out string errorMessage)
	{
		return TryParse(str, isFrom: true, out result, out errorMessage);
	}

	public static bool TryParseToDate(string str, out DateTime? result, out string errorMessage)
	{
		return TryParse(str, isFrom: false, out result, out errorMessage);
	}

	public static bool TryParseFromDate(string str, out DateTime? result)
	{
		string errorMessage;
		return TryParse(str, isFrom: true, out result, out errorMessage);
	}

	public static bool TryParseToDate(string str, out DateTime? result)
	{
		string errorMessage;
		return TryParse(str, isFrom: false, out result, out errorMessage);
	}

	public static DateTime ParseFromDate(string str)
	{
		int num = 1;
		int num2 = num;
		DateTime? result = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				return result.Value;
			case 1:
			{
				if (!TryParse(str, isFrom: true, out result, out var errorMessage))
				{
					throw new Exception(errorMessage);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public static DateTime ParseToDate(string str)
	{
		int num = 1;
		int num2 = num;
		DateTime? result = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				return result.Value;
			case 1:
			{
				if (!TryParse(str, isFrom: false, out result, out var errorMessage))
				{
					throw new Exception(errorMessage);
				}
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

	internal static DateTime ParseFromDate(string str, DateTime now)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		DateTime? result = default(DateTime?);
		string errorMessage = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!TryParse(str, isFrom: true, out result, out errorMessage, now))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return result.Value;
			default:
				throw new Exception(errorMessage);
			}
		}
	}

	internal static DateTime ParseToDate(string str, DateTime now)
	{
		//Discarded unreachable code: IL_006d, IL_007c
		int num = 2;
		int num2 = num;
		DateTime? result = default(DateTime?);
		string errorMessage = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!TryParse(str, isFrom: false, out result, out errorMessage, now))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return result.Value;
			case 1:
				throw new Exception(errorMessage);
			}
		}
	}

	private static bool TryParse(object str, bool isFrom, out DateTime? result, out string errorMessage, DateTime? now = null)
	{
		result = null;
		errorMessage = "";
		if (string.IsNullOrEmpty((string)str))
		{
			return false;
		}
		str = Regex.Replace((string)str, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF187E), string.Empty).ToLower();
		if (string.IsNullOrEmpty((string)str))
		{
			errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334952359));
			return false;
		}
		MatchCollection matchCollection = Regex.Matches((string)str, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29212699), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824413371), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426315823)));
		if (matchCollection.Count < 1 || matchCollection.Cast<Match>().Sum((Match m) => _003C_003Ec.VgV4P8vmyQCw69ksQnyt(m.Value)) != ((string)str).Length)
		{
			errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A441B2));
			return false;
		}
		List<Pair<int, RelativeDateTimeMeter>> list = (from Match match in matchCollection
			select new Pair<int, RelativeDateTimeMeter>(int.Parse(match.Groups[2].Value), match.Groups[6].Value.ToRelativeDateTimeMeter())).ToList();
		if (!isFrom)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.minType = list.Min((Pair<int, RelativeDateTimeMeter> v) => v.Second);
			list.First((Pair<int, RelativeDateTimeMeter> v) => v.Second == CS_0024_003C_003E8__locals0.minType).First++;
		}
		result = now ?? DateTime.Now;
		switch (list[0].Second)
		{
		case RelativeDateTimeMeter.Hour:
			result = result.Value.Date.AddHours(result.Value.Hour);
			break;
		case RelativeDateTimeMeter.Day:
			result = result.Value.Date;
			break;
		case RelativeDateTimeMeter.Week:
			result = result.Value.Date.AddDays(-((int)(result.Value.DayOfWeek - 1 + 7) % 7));
			break;
		case RelativeDateTimeMeter.Month:
			result = new DateTime(result.Value.Year, result.Value.Month, 1);
			break;
		case RelativeDateTimeMeter.Quarter:
			result = new DateTime(result.Value.Year, result.Value.Month - (result.Value.Month - 1) % 3, 1);
			break;
		case RelativeDateTimeMeter.Year:
			result = new DateTime(result.Value.Year, 1, 1);
			break;
		}
		foreach (Pair<int, RelativeDateTimeMeter> item in list.Where((Pair<int, RelativeDateTimeMeter> v) => v.First != 0))
		{
			switch (item.Second)
			{
			case RelativeDateTimeMeter.Hour:
				result = result.Value.AddHours(item.First);
				break;
			case RelativeDateTimeMeter.Day:
				result = result.Value.AddDays(item.First);
				break;
			case RelativeDateTimeMeter.Week:
				result = result.Value.AddDays(7 * item.First);
				break;
			case RelativeDateTimeMeter.Month:
				result = result.Value.AddMonths(item.First);
				break;
			case RelativeDateTimeMeter.Quarter:
				result = result.Value.AddMonths(3 * item.First);
				break;
			case RelativeDateTimeMeter.Year:
				result = result.Value.AddYears(item.First);
				break;
			}
		}
		if (!isFrom && result.Value.TimeOfDay == TimeSpan.Zero)
		{
			result = result.Value.AddSeconds(-10.0);
		}
		return true;
	}

	private static string SR(RelativeDateTimeMeter relativeDateTimeMeter)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 6;
		int num2 = num;
		char c = default(char);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				c = KNEyrqhYhtHWB2up5ILq(z4H6kPhYojCMhbsoHJPD(-538519530 ^ -538608946), (int)relativeDateTimeMeter);
				num2 = 3;
				continue;
			case 1:
				return c.ToString();
			case 3:
				return c.ToString();
			case 4:
				c = ((string)z4H6kPhYojCMhbsoHJPD(-16752921 ^ -16516081))[(int)relativeDateTimeMeter];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (!IOPh2IhYbwrp0Bp9AEMl(Xw3MLthYWu8XpblvOlVJ(((LanguagesMap)dmbJAThYB7tlmLfaF3cr()).GetBaseCultureInfo((string)Xw3MLthYWu8XpblvOlVJ(cultureInfo))), z4H6kPhYojCMhbsoHJPD(-538519530 ^ -538525102), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 6:
				obj = BMAT4nhjcUirB4NwlwvP();
				if (obj != null)
				{
					break;
				}
				num2 = 5;
				continue;
			case 5:
				obj = cK6qnfhYF0ONYquy0ax1(SXEmNshjzqotttlp4uVG());
				break;
			}
			cultureInfo = (CultureInfo)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static RelativeDateTimeMeter ToRelativeDateTimeMeter(this object symbol)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				num3 = sKkMughYGtbVsptYQSOv(z4H6kPhYojCMhbsoHJPD(-3333094 ^ -3242302), symbol);
				num2 = 3;
				break;
			default:
				return (RelativeDateTimeMeter)num3;
			case 1:
				num3 = ((string)z4H6kPhYojCMhbsoHJPD(0x57A5235E ^ 0x57A681B6)).IndexOf((string)symbol);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (num3 >= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	internal static bool TWtjMPhjL2OcyIwB8DA2()
	{
		return jVjkP7hjYKdFyOHI4xYL == null;
	}

	internal static RelativeDateTimeParser dg64YbhjUUon8N5nXeZv()
	{
		return jVjkP7hjYKdFyOHI4xYL;
	}

	internal static object JhhEMghjs9gqJJeBFJrw(RelativeDateTimeMeter relativeDateTimeMeter)
	{
		return SR(relativeDateTimeMeter);
	}

	internal static object BMAT4nhjcUirB4NwlwvP()
	{
		return EleWise.ELMA.SR.GetCurrentCulture();
	}

	internal static object SXEmNshjzqotttlp4uVG()
	{
		return Thread.CurrentThread;
	}

	internal static object cK6qnfhYF0ONYquy0ax1(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object dmbJAThYB7tlmLfaF3cr()
	{
		return EleWise.ELMA.SR.LanguagesMap;
	}

	internal static object Xw3MLthYWu8XpblvOlVJ(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object z4H6kPhYojCMhbsoHJPD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool IOPh2IhYbwrp0Bp9AEMl(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static char KNEyrqhYhtHWB2up5ILq(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static int sKkMughYGtbVsptYQSOv(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}
}
