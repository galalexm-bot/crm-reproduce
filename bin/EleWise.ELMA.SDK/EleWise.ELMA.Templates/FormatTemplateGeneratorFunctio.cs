using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates;

[Component]
public class FormatTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	internal static FormatTemplateGeneratorFunctions KaUVQQBPkUiWNBLe32tm;

	public static FormatedValue DateTimeFormat(FunctionEvaluationContext context)
	{
		int num = 7;
		DateTime value = default(DateTime);
		DateTime? dateTime = default(DateTime?);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return new FormatedValue(value.ToString((IFormatProvider)aZssRlBPextV6my0S0oi()));
				case 8:
					value = dateTime.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return new FormatedValue(value.ToString((IFormatProvider)aZssRlBPextV6my0S0oi()));
				case 2:
					if (!VcaZMFBPP2ZkGitgX9F3(text))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 8;
						}
					}
					else
					{
						value = dateTime.Value;
						num2 = 5;
					}
					continue;
				default:
					return new FormatedValue(value.ToString(text));
				case 7:
					if (!context.Parameters.Any())
					{
						num2 = 6;
						continue;
					}
					dateTime = hsQbamBP2qrtkgu3w3FO(context.Parameters[0]) as DateTime?;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					return new FormatedValue(string.Empty);
				case 1:
					if (!dateTime.HasValue)
					{
						num2 = 3;
						continue;
					}
					if (context.Parameters.Count != 1)
					{
						text = hsQbamBP2qrtkgu3w3FO(context.Parameters[1]) as string;
						num2 = 2;
						continue;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					break;
				case 3:
					return new FormatedValue(string.Empty);
				}
				break;
			}
			value = dateTime.Value;
			num = 4;
		}
	}

	public static FormatedValue NumberFormat(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_016e, IL_017d
		int num = 7;
		string text = default(string);
		double num4 = default(double);
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return new FormatedValue(string.Empty);
				case 3:
					if (Gx6DOoBP1KcCF7vrUDfw(context.Parameters) == 1)
					{
						num2 = 8;
						continue;
					}
					text = hsQbamBP2qrtkgu3w3FO(context.Parameters[1]) as string;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
				case 5:
					return new FormatedValue(num4.ToString(text));
				case 7:
					if (context.Parameters.Any())
					{
						num4 = ConvertToDouble(context, 0);
						num2 = 3;
						continue;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					break;
				case 8:
					return new FormatedValue(num4);
				case 1:
					num3 = xifRGaBPNFPlaMVI6DmY(context, 1);
					num2 = 2;
					continue;
				default:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			text = (string)UDIxi9BPpDZxZRoAmyaD(bhS6VtBP3xYCDyPXOXSs(-1867198571 ^ -1867124505), num3.ToString((string)bhS6VtBP3xYCDyPXOXSs(-867826612 ^ -867747022)));
			num = 4;
		}
	}

	public static FormatedValue MoneyFormat(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		double num4 = default(double);
		double num3 = default(double);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return new FormatedValue(BO7XA6BPD0xIVuJYycQB(nacfgxBPa5wTmXVjBEO4(num4.ToString((string)bhS6VtBP3xYCDyPXOXSs(0x57A5235E ^ 0x57A41CD8), new CultureInfo((string)bhS6VtBP3xYCDyPXOXSs(-3333094 ^ -3326370))), bhS6VtBP3xYCDyPXOXSs(-521266112 ^ -521198642), ""), new char[1] { ' ' }));
			default:
				return new FormatedValue(string.Empty);
			case 1:
				if (context.Parameters.Any())
				{
					num4 = xifRGaBPNFPlaMVI6DmY(context, 0);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				if (context.Parameters.Count != 1)
				{
					num3 = xifRGaBPNFPlaMVI6DmY(context, 1);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 2:
				return new FormatedValue(BO7XA6BPD0xIVuJYycQB(nacfgxBPa5wTmXVjBEO4(num4.ToString(text, new CultureInfo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521271804))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138079754), ""), new char[1] { ' ' }));
			case 5:
				text = (string)UDIxi9BPpDZxZRoAmyaD(bhS6VtBP3xYCDyPXOXSs(--1418440330 ^ 0x548A911E), num3.ToString((string)bhS6VtBP3xYCDyPXOXSs(0x35C0467B ^ 0x35C17905)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static double ConvertToDouble(object context, int paramIndex)
	{
		//Discarded unreachable code: IL_0246, IL_0326, IL_0335, IL_039f
		int num = 10;
		int num2 = num;
		decimal? num10 = default(decimal?);
		long? num8 = default(long?);
		uint? num4 = default(uint?);
		int? num5 = default(int?);
		ushort? num9 = default(ushort?);
		short? num11 = default(short?);
		ulong? num6 = default(ulong?);
		double? num3 = default(double?);
		float? num7 = default(float?);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return h6ah9DBPtk6ZxSCY4Mo7(num10.Value);
			case 14:
				if (num8.HasValue)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num4 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as uint?;
					num2 = 18;
				}
				break;
			case 4:
				return uKtxFdBP6xaLyFa0Ds0f(num5.Value);
			case 16:
				return lMp8ddBPHOY9GPqKThal(num9.Value);
			case 3:
				num11 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as short?;
				num2 = 21;
				break;
			default:
				if (!num6.HasValue)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 15;
			case 1:
				return num3.Value;
			case 13:
				if (!num5.HasValue)
				{
					num9 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as ushort?;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 6:
				if (!num10.HasValue)
				{
					num7 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as float?;
					num2 = 2;
				}
				else
				{
					num2 = 8;
				}
				break;
			case 11:
				return Convert.ToDouble(num7.Value);
			case 20:
				num6 = ((FunctionEvaluationContext)context).Parameters[paramIndex].Value as ulong?;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				if (!num3.HasValue)
				{
					num10 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as decimal?;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 2:
				if (!num7.HasValue)
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 17;
					}
					break;
				}
				goto case 11;
			case 21:
				if (num11.HasValue)
				{
					num2 = 12;
					break;
				}
				return 0.0;
			case 17:
				return hOaj2lBP4EhLU25ZqWPa(num4.Value);
			case 15:
				return E0UxiPBPwr9FWoHgfG6c(num6);
			case 7:
				num8 = ((FunctionEvaluationContext)context).Parameters[paramIndex].Value as long?;
				num2 = 14;
				break;
			case 12:
				return N2muF7BPA9GEsoEd91tA(num11.Value);
			case 19:
				if (!num9.HasValue)
				{
					num2 = 3;
					break;
				}
				goto case 16;
			case 5:
				return E0UxiPBPwr9FWoHgfG6c(num8);
			case 18:
				if (!num4.HasValue)
				{
					num5 = ((FunctionEvaluationContext)context).Parameters[paramIndex].Value as int?;
					num2 = 13;
					break;
				}
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				num3 = hsQbamBP2qrtkgu3w3FO(((FunctionEvaluationContext)context).Parameters[paramIndex]) as double?;
				num2 = 9;
				break;
			}
		}
	}

	public FormatTemplateGeneratorFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zUCmSeBP7Ayh3ZmfI3Zn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object hsQbamBP2qrtkgu3w3FO(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object aZssRlBPextV6my0S0oi()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static bool VcaZMFBPP2ZkGitgX9F3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool pyGQ6HBPnsSkCwec7Hma()
	{
		return KaUVQQBPkUiWNBLe32tm == null;
	}

	internal static FormatTemplateGeneratorFunctions QZk8rdBPOoNjce6v0dVU()
	{
		return KaUVQQBPkUiWNBLe32tm;
	}

	internal static int Gx6DOoBP1KcCF7vrUDfw(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static double xifRGaBPNFPlaMVI6DmY(object P_0, int paramIndex)
	{
		return ConvertToDouble(P_0, paramIndex);
	}

	internal static object bhS6VtBP3xYCDyPXOXSs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UDIxi9BPpDZxZRoAmyaD(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object nacfgxBPa5wTmXVjBEO4(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object BO7XA6BPD0xIVuJYycQB(object P_0, object P_1)
	{
		return ((string)P_0).TrimEnd((char[])P_1);
	}

	internal static double h6ah9DBPtk6ZxSCY4Mo7(decimal P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static double E0UxiPBPwr9FWoHgfG6c(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static double hOaj2lBP4EhLU25ZqWPa(uint P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static double uKtxFdBP6xaLyFa0Ds0f(int P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static double lMp8ddBPHOY9GPqKThal(ushort P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static double N2muF7BPA9GEsoEd91tA(short P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static void zUCmSeBP7Ayh3ZmfI3Zn()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
