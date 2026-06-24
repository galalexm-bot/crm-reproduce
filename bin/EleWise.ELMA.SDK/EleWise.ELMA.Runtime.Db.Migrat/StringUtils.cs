using System.Text;
using System.Text.RegularExpressions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public class StringUtils
{
	private static StringUtils luvhWKW2nf19fkRwB4Fq;

	public static string ToHumanName(string className)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)kNVPG1W2pIbHZ4vkxPqw(voEPKrW2NOPgVUSBgDfH(text.Substring(0, 1)), yXuGXdW23Pl1x7G3HHfu(text.Substring(1)));
			case 1:
				text = (string)Xa4pceW21E7xssTicXs8(X9T0P5W2PXlWQkUSlSAR(className, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC34066), tF8gJLW2eAMc93F7wfb5(-1638402543 ^ -1638534663)), 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string ReplaceOnce(string template, string placeholder, string replacement)
	{
		//Discarded unreachable code: IL_00a6
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return template;
			default:
				return ((StringBuilder)rrXwhBW2DEPV8lK1ZPm9(new StringBuilder(template.Substring(0, num3)), replacement)).Append((string)Xa4pceW21E7xssTicXs8(template, num3 + Y8WN0EW2tyDFyVr3CjLQ(placeholder))).ToString();
			case 2:
				num3 = y93deiW2aqPS3W8rq9I2(template, placeholder);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (num3 >= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public StringUtils()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wSV08aW2wtBLLaI6CwqU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object tF8gJLW2eAMc93F7wfb5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object X9T0P5W2PXlWQkUSlSAR(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object Xa4pceW21E7xssTicXs8(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object voEPKrW2NOPgVUSBgDfH(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object yXuGXdW23Pl1x7G3HHfu(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object kNVPG1W2pIbHZ4vkxPqw(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool IHlJS2W2O6aQq84yUhp4()
	{
		return luvhWKW2nf19fkRwB4Fq == null;
	}

	internal static StringUtils MV8oLgW222LPIEMCiWA7()
	{
		return luvhWKW2nf19fkRwB4Fq;
	}

	internal static int y93deiW2aqPS3W8rq9I2(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object rrXwhBW2DEPV8lK1ZPm9(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int Y8WN0EW2tyDFyVr3CjLQ(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static void wSV08aW2wtBLLaI6CwqU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
