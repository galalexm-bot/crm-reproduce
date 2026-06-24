using System;
using System.Reflection;
using System.Text;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

public static class DiagnosticsHelper
{
	internal static DiagnosticsHelper QAZoAiEBdMCEWyKCQMHc;

	public static string GetMethodCallName(Type ownerType, MethodInfo method)
	{
		//Discarded unreachable code: IL_00b2, IL_01ec, IL_02b9
		int num = 15;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		ParameterInfo[] array = default(ParameterInfo[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				throw new ArgumentException((string)yEuWNrEBgpNCAcDlu5Ud(-1979251663 ^ -1979311833));
			case 1:
				return stringBuilder.ToString();
			case 7:
				num3++;
				num2 = 9;
				break;
			case 13:
				AppendTypeName(ownerType, useFullName: false, stringBuilder);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				nQnJedEBjqkuEQX2jyZO(stringBuilder, yEuWNrEBgpNCAcDlu5Ud(-3333094 ^ -3326242));
				num2 = 2;
				break;
			case 8:
				num3 = 0;
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 13;
				}
				break;
			case 10:
				if (num3 <= 0)
				{
					num2 = 11;
					break;
				}
				goto case 12;
			case 11:
			case 17:
				iwmNXXEBsYkVpjORDZBU(Bs14fREBUIZddkvmyp9t(array[num3]), false, stringBuilder);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				nQnJedEBjqkuEQX2jyZO(stringBuilder, fYqmSXEBYmsDEJbaDtm5(method));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			default:
				stringBuilder.Append((string)yEuWNrEBgpNCAcDlu5Ud(0x6A81B9B4 ^ 0x6A81A602));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 16;
				}
				break;
			case 9:
			case 18:
				if (num3 >= array.Length)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 10;
			case 16:
				array = (ParameterInfo[])peDnd4EBLNQ1AG3iO7rt(method);
				num2 = 8;
				break;
			case 15:
				if (!(ownerType == null))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 5;
			case 12:
				nQnJedEBjqkuEQX2jyZO(stringBuilder, yEuWNrEBgpNCAcDlu5Ud(0x68BBB53E ^ 0x68BBB93C));
				num2 = 17;
				break;
			case 5:
				throw new ArgumentException((string)yEuWNrEBgpNCAcDlu5Ud(0x57A5235E ^ 0x57A10A22));
			case 14:
				if (!bdlc6ZEB52OxxAyooorY(method, null))
				{
					stringBuilder = new StringBuilder();
					num2 = 13;
				}
				else
				{
					num2 = 6;
				}
				break;
			case 4:
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420747110));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string GetControllerActionCallName(Type controllerType, string action)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2
		int num = 7;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					iwmNXXEBsYkVpjORDZBU(controllerType, false, stringBuilder);
					num2 = 4;
					continue;
				case 7:
					if (!K7ATBvEBc9ddC6QOatxa(controllerType, null))
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 4:
					break;
				case 5:
					nQnJedEBjqkuEQX2jyZO(stringBuilder, action);
					num2 = 2;
					continue;
				case 2:
					return stringBuilder.ToString();
				default:
					throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1ACA8A));
				case 6:
					if (action == null)
					{
						num2 = 3;
						continue;
					}
					stringBuilder = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					throw new ArgumentException((string)yEuWNrEBgpNCAcDlu5Ud(-195614443 ^ -195677983));
				}
				break;
			}
			stringBuilder.Append((string)yEuWNrEBgpNCAcDlu5Ud(0x34185E55 ^ 0x34184491));
			num = 5;
		}
	}

	public static string GetTypeName(Type type, bool useFullName)
	{
		int num = 2;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				iwmNXXEBsYkVpjORDZBU(type, useFullName, stringBuilder);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return stringBuilder.ToString();
			case 2:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void AppendTypeName(Type type, bool useFullName, StringBuilder builder)
	{
		//Discarded unreachable code: IL_01d0, IL_01df, IL_01ef, IL_01fe, IL_028a
		int num = 3;
		int num3 = default(int);
		Type[] genericArguments = default(Type[]);
		Type genericTypeDefinition = default(Type);
		string text2 = default(string);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				case 4:
					if (num3 > 0)
					{
						num = 9;
						break;
					}
					goto case 11;
				case 7:
					genericArguments = type.GetGenericArguments();
					num2 = 5;
					continue;
				case 3:
					if (!type.IsGenericType)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					genericTypeDefinition = type.GetGenericTypeDefinition();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					nQnJedEBjqkuEQX2jyZO(builder, yEuWNrEBgpNCAcDlu5Ud(0x68BBB53E ^ 0x68BBFAFE));
					num2 = 17;
					continue;
				case 19:
					if (useFullName)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 16;
				case 15:
					num3 = ByBgBsEBzlIDI2Jrx70M(text2, '`');
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					text2 = text2.Substring(0, num3);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 6;
					}
					continue;
				case 20:
					nQnJedEBjqkuEQX2jyZO(builder, yEuWNrEBgpNCAcDlu5Ud(-606654180 ^ -606651106));
					num2 = 6;
					continue;
				case 1:
					return;
				case 12:
					builder.Append((string)yEuWNrEBgpNCAcDlu5Ud(0xD3DEF7E ^ 0xD3DA0B8));
					num = 7;
					break;
				case 17:
					return;
				case 8:
					if (num4 > 0)
					{
						num2 = 20;
						continue;
					}
					goto case 6;
				case 11:
					builder.Append(text2);
					num2 = 12;
					continue;
				default:
					if (num4 >= genericArguments.Length)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 8;
				case 13:
					num4++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					num4 = 0;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					text = genericTypeDefinition.Name;
					goto IL_02e4;
				case 6:
					AppendTypeName(genericArguments[num4], useFullName, builder);
					num2 = 13;
					continue;
				case 2:
					builder.Append((string)(useFullName ? type.FullName : fYqmSXEBYmsDEJbaDtm5(type)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					{
						text = genericTypeDefinition.FullName;
						goto IL_02e4;
					}
					IL_02e4:
					text2 = text;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static object yEuWNrEBgpNCAcDlu5Ud(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bdlc6ZEB52OxxAyooorY(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object nQnJedEBjqkuEQX2jyZO(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object fYqmSXEBYmsDEJbaDtm5(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object peDnd4EBLNQ1AG3iO7rt(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type Bs14fREBUIZddkvmyp9t(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static void iwmNXXEBsYkVpjORDZBU(Type type, bool useFullName, object P_2)
	{
		AppendTypeName(type, useFullName, (StringBuilder)P_2);
	}

	internal static bool W76ulbEBlgqiaAQSNv0X()
	{
		return QAZoAiEBdMCEWyKCQMHc == null;
	}

	internal static DiagnosticsHelper GM3gLgEBrccpndDbmOiF()
	{
		return QAZoAiEBdMCEWyKCQMHc;
	}

	internal static bool K7ATBvEBc9ddC6QOatxa(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static int ByBgBsEBzlIDI2Jrx70M(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}
}
