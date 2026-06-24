using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.BackgroundOperations;

public static class DelegateHelper
{
	internal static DelegateHelper iECxFsWce5HFZ17arvB7;

	public static string DelegateToString(Delegate @delegate)
	{
		//Discarded unreachable code: IL_0062
		int num = 2;
		int num2 = num;
		string name = default(string);
		IEnumerable<string> values = default(IEnumerable<string>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return string.Empty;
			case 1:
				name = @delegate.Method.Name;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if ((object)@delegate != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				return (string)YFeO0hWcpnKevHs85Nkp(nZ9dLZWc3h9PgHgtgIeE(0x92F12D5 ^ 0x92FC89B), name, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088305190), values));
			default:
				values = from arg in ((MethodBase)m1oSUdWcNq1oTsfCeJs5(@delegate)).GetParameters()
					select arg.ParameterType.ToString();
				num2 = 3;
				break;
			}
		}
	}

	public static void ThrowIfAnonymousLambda(Delegate @delegate)
	{
		//Discarded unreachable code: IL_0035, IL_00ab, IL_00ba
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				if ((object)@delegate == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 2:
				throw new ArgumentException((string)XFiO8iWcDGKiHs3dRJBK(nZ9dLZWc3h9PgHgtgIeE(-1767720453 ^ -1767834317)));
			case 3:
				return;
			case 1:
				if (!pTK8T0WcaVIDS67AF6Vb(m1oSUdWcNq1oTsfCeJs5(@delegate)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static void ThrowIfNotPublic(Delegate @delegate)
	{
		//Discarded unreachable code: IL_0087, IL_0096
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				throw new ArgumentException((string)XFiO8iWcDGKiHs3dRJBK(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106371454)));
			case 0:
				return;
			case 2:
				if (BtGBv3Wcts3v2tbmaMxp(m1oSUdWcNq1oTsfCeJs5(@delegate)))
				{
					return;
				}
				num2 = 3;
				break;
			case 1:
				if ((object)@delegate == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string[] GetDelegateArgumentNames(Delegate @delegate)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((object)@delegate != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new string[0];
			default:
				return ((IEnumerable<ParameterInfo>)LHXoTuWcwcChjK3ruLD8(@delegate.Method)).Select((ParameterInfo p) => p.Name).ToArray();
			}
		}
	}

	internal static object m1oSUdWcNq1oTsfCeJs5(object P_0)
	{
		return ((Delegate)P_0).Method;
	}

	internal static object nZ9dLZWc3h9PgHgtgIeE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YFeO0hWcpnKevHs85Nkp(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool hwsuCgWcPriGiGncpK3g()
	{
		return iECxFsWce5HFZ17arvB7 == null;
	}

	internal static DelegateHelper w2R21iWc185W5S5GjkQ3()
	{
		return iECxFsWce5HFZ17arvB7;
	}

	internal static bool pTK8T0WcaVIDS67AF6Vb(object P_0)
	{
		return ((MethodInfo)P_0).IsAnonymous();
	}

	internal static object XFiO8iWcDGKiHs3dRJBK(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool BtGBv3Wcts3v2tbmaMxp(object P_0)
	{
		return ((MethodBase)P_0).IsPublic;
	}

	internal static object LHXoTuWcwcChjK3ruLD8(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}
}
