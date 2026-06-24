using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class ScriptHelper
{
	private static ScriptHelper LFQkhyhj8ZDAlWEIiyI1;

	public static MethodInfo GetMethodInfo(Type type, string scriptName)
	{
		//Discarded unreachable code: IL_00e3, IL_00f2, IL_0101, IL_0291, IL_02d3
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		int num3 = default(int);
		MethodInfo[] array = default(MethodInfo[]);
		MethodInfo result = default(MethodInfo);
		_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_2 = default(_003C_003Ec__DisplayClass0_1);
		MethodInfo methodInfo = default(MethodInfo);
		string text = default(string);
		IEnumerable<string> values = default(IEnumerable<string>);
		while (true)
		{
			MethodInfo methodInfo2;
			switch (num2)
			{
			case 10:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 6;
				break;
			case 5:
			case 11:
				if (num3 < array.Length)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 4:
			case 12:
			case 19:
				return result;
			case 17:
				num3++;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 3;
				}
				break;
			case 18:
				_003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_1();
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 4;
				}
				break;
			case 8:
			case 21:
				methodInfo = array[num3];
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass0_.scriptNameLower = (string)IXSelwhjSuuWcceXLq36(scriptName);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				text = (string)((object[])VeyrwJhjVE7vxNGXcUty(scriptName, new string[1] { (string)dKysH3hjIcAPCtKiaXeQ(0x57A5235E ^ 0x57A5E0F8) }, StringSplitOptions.None))[0];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 15:
				if (!((string)eo3RcehjXaaaEb85eXqx(methodInfo) + (string)dKysH3hjIcAPCtKiaXeQ(-2107978722 ^ -2107976792) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858866351), values) + (string)dKysH3hjIcAPCtKiaXeQ(-538519530 ^ -538523734) != text))
				{
					num2 = 13;
					break;
				}
				goto case 17;
			case 14:
				_003C_003Ec__DisplayClass0_2.scriptShortName = (string)QeaCUNhjR1aPcCioamBY(text, 0, EpAtVehjihRS3luTnh4g(text, '('));
				num2 = 9;
				break;
			case 9:
			{
				MethodInfo[] array2 = Array.FindAll(type.GetMethods(), _003C_003Ec__DisplayClass0_2._003CGetMethodInfo_003Eb__1);
				text = (string)Ur7LgDhjKmgn1ogQKyKS(b5illXhjqQmVbQfO83SP(text, '+', '.'), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABEDCA), "");
				array = array2;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 7;
				}
				break;
			}
			case 2:
				result = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				num3 = 0;
				num2 = 5;
				break;
			default:
				if (!text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710575748)))
				{
					num2 = 10;
					break;
				}
				goto case 18;
			case 13:
				result = methodInfo;
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 11;
				}
				break;
			case 16:
				methodInfo2 = type.GetMethod(text);
				if ((object)methodInfo2 != null)
				{
					goto IL_0341;
				}
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 7;
				}
				break;
			case 20:
				methodInfo2 = Array.Find(type.GetMethods(), _003C_003Ec__DisplayClass0_._003CGetMethodInfo_003Eb__0);
				goto IL_0341;
			case 3:
				{
					values = methodInfo.GetParameters().Select(delegate(ParameterInfo q)
					{
						int num4 = 1;
						int num5 = num4;
						string typeInfo = default(string);
						while (true)
						{
							switch (num5)
							{
							case 1:
								typeInfo = GetTypeInfo(_003C_003Ec.FuUH7dvmkRAQBfINHS2E(q));
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num5 = 0;
								}
								break;
							default:
								return typeInfo.Substring(1, _003C_003Ec.anSEIEvmnF7i9yrDwJhl(typeInfo) - 2);
							}
						}
					});
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 12;
					}
					break;
				}
				IL_0341:
				result = methodInfo2;
				num2 = 12;
				break;
			}
		}
	}

	private static string GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_0040, IL_004f, IL_00cc, IL_00db
		int num = 1;
		int num2 = num;
		string result = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				return result;
			case 1:
				if (!type.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 6:
				text = string.Join((string)dKysH3hjIcAPCtKiaXeQ(-1824388195 ^ -1824368275), type.GetGenericArguments().Select(GetTypeInfo));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				result = (string)dKysH3hjIcAPCtKiaXeQ(-1886646897 ^ -1886586003) + type.Namespace + (string)dKysH3hjIcAPCtKiaXeQ(-2099751081 ^ -2099753581) + type.Name + (string)dKysH3hjIcAPCtKiaXeQ(-542721635 ^ -542748801) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576171784);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 3;
				}
				break;
			default:
			{
				object obj = dKysH3hjIcAPCtKiaXeQ(-218496594 ^ -218433716);
				string fullName = type.FullName;
				result = (string)HO8diehjk0aaIJfRf63p(obj, (fullName != null) ? aqUVMMhjT4i9XIBPW7X8(fullName, '+', '.') : null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A715A2));
				num2 = 4;
				break;
			}
			}
		}
	}

	internal static string ServiceNamespace(string nameSpace)
	{
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					text = (string)CcDPvdhjOc55yiyX2qow(text);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					text = string.Format((string)dKysH3hjIcAPCtKiaXeQ(0x66F566B6 ^ 0x66F5BC34), text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				default:
					return (string)Ur7LgDhjKmgn1ogQKyKS(Ur7LgDhjKmgn1ogQKyKS(Ur7LgDhjKmgn1ogQKyKS(Ur7LgDhjKmgn1ogQKyKS(Ur7LgDhjKmgn1ogQKyKS(Regex.Replace(nameSpace, text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E25E1)), dKysH3hjIcAPCtKiaXeQ(-643786247 ^ -643760697), ""), dKysH3hjIcAPCtKiaXeQ(-867826612 ^ -867850946), ""), dKysH3hjIcAPCtKiaXeQ(0x4A1640F ^ 0x4A17ECB), dKysH3hjIcAPCtKiaXeQ(0x31326106 ^ 0x31326D7C)), dKysH3hjIcAPCtKiaXeQ(-1858887263 ^ -1858883635), dKysH3hjIcAPCtKiaXeQ(-1979251663 ^ -1979250613)), dKysH3hjIcAPCtKiaXeQ(0x2ACE37D ^ 0x2AC872D), "");
				}
				break;
			}
			text = new string((char[])FI2inehjnE9l8hbmU5VL());
			num = 2;
		}
	}

	internal static object dKysH3hjIcAPCtKiaXeQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VeyrwJhjVE7vxNGXcUty(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object IXSelwhjSuuWcceXLq36(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static int EpAtVehjihRS3luTnh4g(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object QeaCUNhjR1aPcCioamBY(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object b5illXhjqQmVbQfO83SP(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object Ur7LgDhjKmgn1ogQKyKS(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object eo3RcehjXaaaEb85eXqx(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool HGquUghjZqlNQmuQlrxw()
	{
		return LFQkhyhj8ZDAlWEIiyI1 == null;
	}

	internal static ScriptHelper qC2cPjhju5Q7DU3wcTZ9()
	{
		return LFQkhyhj8ZDAlWEIiyI1;
	}

	internal static object aqUVMMhjT4i9XIBPW7X8(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object HO8diehjk0aaIJfRf63p(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object FI2inehjnE9l8hbmU5VL()
	{
		return Path.GetInvalidFileNameChars();
	}

	internal static object CcDPvdhjOc55yiyX2qow(object P_0)
	{
		return Regex.Escape((string)P_0);
	}
}
