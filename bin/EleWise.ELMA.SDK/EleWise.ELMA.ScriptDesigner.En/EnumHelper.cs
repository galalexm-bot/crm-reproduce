using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.Enums;

public static class EnumHelper
{
	internal static EnumHelper ADQIb4SO5STHoRCWEcq;

	public static string GetDescription(this Enum value)
	{
		int num = 1;
		int num2 = num;
		DescriptionAttribute[] array = default(DescriptionAttribute[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return value.ToString();
			case 1:
				array = (DescriptionAttribute[])Xe7eExSN1SUeQwaAuCh(PVUuBCSPb1q5UAIEtFe(value.GetType(), value.ToString()), dkow1mS1CPcOlaCmhnU(typeof(DescriptionAttribute).TypeHandle), false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (array.Length == 0)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return array[0].Description;
		}
	}

	public static IEnumerable<string> ToListNames(this Enum value, bool useDescriptionAttribute = false)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.useDescriptionAttribute = useDescriptionAttribute;
		if (value == null)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.type = value.GetType();
		return CS_0024_003C_003E8__locals0.type.GetReflectionEnumNames().Select(delegate(string e)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (CS_0024_003C_003E8__locals0.useDescriptionAttribute)
					{
						return (string)_003C_003Ec__DisplayClass1_0.OGq6p6fxZgxeDghtIus8((Enum)_003C_003Ec__DisplayClass1_0.GPjr4ffx8GIcNqvqrekw(CS_0024_003C_003E8__locals0.type, e.ToString(CultureInfo.InvariantCulture), true));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return e;
				}
			}
		});
	}

	public static string GetDisplayName(this MoreOrLess value)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (value)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case MoreOrLess.More:
					break;
				case MoreOrLess.Equal:
					return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(0x48A7E34A ^ 0x48A7ADAA));
				case MoreOrLess.Less:
					return SR.T((string)dAb0shS3bQcpjwmdKUQ(0x3C5338FF ^ 0x3C537611));
				case MoreOrLess.MoreOrEqual:
					return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-541731959 ^ -541745801));
				case MoreOrLess.LessOrEqual:
					return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-87337865 ^ -87352493));
				case MoreOrLess.NotEqual:
					return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(0x7459E02 ^ 0x745D148));
				}
				goto case 2;
			case 2:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABEA38));
			default:
				{
					return null;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public static string GetDisplayName(this AndOr value)
	{
		//Discarded unreachable code: IL_0063, IL_00a7, IL_00b6
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-1638402543 ^ -1638418097));
				case 4:
					return null;
				default:
					if (value == AndOr.Or)
					{
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-867826612 ^ -867808472));
					}
					goto end_IL_0012;
				case 2:
					if (value == AndOr.And)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static string GetDisplayName(this MathOperators value)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)xv2PqUSpX7pnDRpipOU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123617008));
			case 1:
				return null;
			case 2:
				{
					switch (value)
					{
					case MathOperators.Plus:
						break;
					case MathOperators.Minus:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106501050));
					case MathOperators.Divide:
						return (string)xv2PqUSpX7pnDRpipOU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561061124));
					case MathOperators.Multiply:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740353410));
					default:
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public static string GetEnumCode(this MoreOrLess value)
	{
		//Discarded unreachable code: IL_00c6, IL_00d5
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-475857671 ^ -475876551));
			case 1:
				return null;
			case 2:
				{
					switch (value)
					{
					case MoreOrLess.More:
						break;
					case MoreOrLess.Equal:
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-889460160 ^ -889461174));
					case MoreOrLess.Less:
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-138018305 ^ -137998791));
					case MoreOrLess.MoreOrEqual:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767705033));
					case MoreOrLess.LessOrEqual:
						return SR.T((string)dAb0shS3bQcpjwmdKUQ(-1765851862 ^ -1765838088));
					case MoreOrLess.NotEqual:
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-1852837372 ^ -1852850724));
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public static string GetEnumCode(this AndOr value)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3, IL_00c3, IL_00d2
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 3:
				return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-951514650 ^ -951499080));
			default:
				return null;
			case 2:
				if (value == AndOr.And)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				break;
			}
			if (value == AndOr.Or)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
			{
				num2 = 0;
			}
		}
		return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-420743386 ^ -420759486));
	}

	public static string GetEnumCode(this MathOperators value)
	{
		//Discarded unreachable code: IL_008e, IL_009d
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-1867198571 ^ -1867218869));
			default:
				return null;
			case 1:
				{
					switch (value)
					{
					case MathOperators.Plus:
						break;
					case MathOperators.Minus:
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(0xE1229CF ^ 0xE1227A3));
					case MathOperators.Divide:
						return (string)xv2PqUSpX7pnDRpipOU(dAb0shS3bQcpjwmdKUQ(-538519530 ^ -538535950));
					case MathOperators.Multiply:
						return SR.T((string)dAb0shS3bQcpjwmdKUQ(-561074844 ^ -561061234));
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static object PVUuBCSPb1q5UAIEtFe(Type type, object P_1)
	{
		return type.GetReflectionField((string)P_1);
	}

	internal static Type dkow1mS1CPcOlaCmhnU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Xe7eExSN1SUeQwaAuCh(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static bool jTCsrqS2iZxYuhSOouH()
	{
		return ADQIb4SO5STHoRCWEcq == null;
	}

	internal static EnumHelper YWbJ07SehV3tChK1J1a()
	{
		return ADQIb4SO5STHoRCWEcq;
	}

	internal static object dAb0shS3bQcpjwmdKUQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xv2PqUSpX7pnDRpipOU(object P_0)
	{
		return SR.T((string)P_0);
	}
}
