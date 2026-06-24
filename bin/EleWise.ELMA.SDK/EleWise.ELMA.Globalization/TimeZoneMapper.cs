using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public static class TimeZoneMapper
{
	private static Dictionary<string, string> ianaToWindowsMap;

	private static TimeZoneMapper AKwa1tGoobjgiO2YwudA;

	private static void InitializeIanaToWindowsMap()
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_0097, IL_01a5, IL_0245, IL_0254, IL_0263, IL_029b, IL_02aa, IL_02db, IL_0313, IL_0322
		int num = 2;
		int num2 = num;
		IEnumerator<XElement> enumerator = default(IEnumerator<XElement>);
		XAttribute xAttribute = default(XAttribute);
		string value = default(string);
		XAttribute xAttribute2 = default(XAttribute);
		string[] array = default(string[]);
		int num4 = default(int);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				enumerator = ((XContainer)KyX7BjGoEu2EgbdidViN(sRqKFFGoGxZj6KhWpnri())).Descendants((XName)COU2XyGoQFpvqhfBKwf8(ddY0ZfGofRCXCr8hG0cO(-70037984 ^ -70191514))).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!yJO89sGo88XdEHsOgTZK(enumerator))
						{
							num3 = 9;
							goto IL_009b;
						}
						goto IL_01e6;
						IL_009b:
						while (true)
						{
							switch (num3)
							{
							case 12:
							{
								string[] array2 = ((string)YdekJ2GovufS6dRhGyJg(xAttribute)).Split(new char[1] { ' ' });
								value = (string)YdekJ2GovufS6dRhGyJg(xAttribute2);
								array = array2;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 7:
							case 10:
								num4++;
								num3 = 2;
								continue;
							case 6:
								ianaToWindowsMap.Add(key, value);
								num3 = 7;
								continue;
							case 13:
								if (xAttribute2 == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 12;
							case 2:
							case 4:
								if (num4 < array.Length)
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 8:
							case 11:
								key = array[num4];
								num3 = 14;
								continue;
							case 3:
								if (xAttribute != null)
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
									{
										num3 = 13;
									}
									continue;
								}
								break;
							case 15:
								goto IL_01e6;
							case 14:
								if (ianaToWindowsMap.ContainsKey(key))
								{
									num3 = 10;
									continue;
								}
								goto case 6;
							case 1:
								num4 = 0;
								num3 = 4;
								continue;
							case 9:
								return;
							}
							break;
						}
						continue;
						IL_01e6:
						XElement current = enumerator.Current;
						xAttribute = (XAttribute)B8nPbWGoCKWo9dxVEMjq(current, COU2XyGoQFpvqhfBKwf8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146509055)));
						xAttribute2 = (XAttribute)B8nPbWGoCKWo9dxVEMjq(current, COU2XyGoQFpvqhfBKwf8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218514954)));
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num3 = 3;
						}
						goto IL_009b;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								uqXBOyGoZK4GOAbTjfZy(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				ianaToWindowsMap = new Dictionary<string, string>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static TimeZoneModel GetTimeZoneByIanaTimeZoneId(string ianaTimeZoneId, int offset)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!string.IsNullOrEmpty(ianaTimeZoneId))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 7:
				return TZ.TimeZones.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetTimeZoneByIanaTimeZoneId_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_.offset = offset;
				num2 = 5;
				break;
			case 8:
				return null;
			case 6:
				return null;
			case 3:
				if (ianaToWindowsMap == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				if (ianaToWindowsMap.ContainsKey(ianaTimeZoneId))
				{
					_003C_003Ec__DisplayClass2_.windowsTimeZoneId = ianaToWindowsMap[ianaTimeZoneId];
					num2 = 7;
				}
				else
				{
					num2 = 8;
				}
				break;
			case 4:
				InitializeIanaToWindowsMap();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object sRqKFFGoGxZj6KhWpnri()
	{
		return Resources.WindowsZones;
	}

	internal static object KyX7BjGoEu2EgbdidViN(object P_0)
	{
		return XDocument.Parse((string)P_0);
	}

	internal static object ddY0ZfGofRCXCr8hG0cO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object COU2XyGoQFpvqhfBKwf8(object P_0)
	{
		return (XName)(string)P_0;
	}

	internal static object B8nPbWGoCKWo9dxVEMjq(object P_0, object P_1)
	{
		return ((XElement)P_0).Attribute((XName)P_1);
	}

	internal static object YdekJ2GovufS6dRhGyJg(object P_0)
	{
		return ((XAttribute)P_0).Value;
	}

	internal static bool yJO89sGo88XdEHsOgTZK(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void uqXBOyGoZK4GOAbTjfZy(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool F8rhsNGobKtRvcoFH1hC()
	{
		return AKwa1tGoobjgiO2YwudA == null;
	}

	internal static TimeZoneMapper hVXjafGohRgLpaaMy76P()
	{
		return AKwa1tGoobjgiO2YwudA;
	}
}
