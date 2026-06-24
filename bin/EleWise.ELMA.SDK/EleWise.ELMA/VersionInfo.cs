using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA;

public static class VersionInfo
{
	private static VersionInfo V2KJygC7n9lDkuMxrng;

	public static Version GetVersion<T>()
	{
		return GetVersion(typeof(T));
	}

	public static Version GetVersion([NotNull] Type type)
	{
		//Discarded unreachable code: IL_00db, IL_00ea
		int num = 3;
		int num2 = num;
		AssemblyFileVersionAttribute assemblyFileVersionAttribute = default(AssemblyFileVersionAttribute);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentNullException((string)fcJU1FCmWflAlPV0qp1(-195614443 ^ -195615433));
			case 2:
				assemblyFileVersionAttribute = (AssemblyFileVersionAttribute)((IEnumerable<object>)oyyviiCMVbNVVLiHGqU(type.Assembly, imU4dgCyO3LP4dBaIIi(typeof(AssemblyFileVersionAttribute).TypeHandle), false)).FirstOrDefault();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (!(type == null))
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			case 4:
				return new Version(1, 0, 0, 0);
			}
			if (assemblyFileVersionAttribute != null)
			{
				return new Version((string)pMABvtCJjNXentJi4DD(assemblyFileVersionAttribute));
			}
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
			{
				num2 = 3;
			}
		}
	}

	public static string GetInfoVersion<T>()
	{
		return GetInfoVersion(typeof(T));
	}

	public static string GetDemoActivationUrl(bool useStudentActivationUrl, string regKey)
	{
		//Discarded unreachable code: IL_00b3, IL_00c2
		int num = 5;
		int num2 = num;
		CultureInfo cultureFromSettings = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				cultureFromSettings = SR.GetCultureFromSettings();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (cultureFromSettings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_008e;
			case 3:
				return (string)o8vb04CloUkP2E0xJ04(fcJU1FCmWflAlPV0qp1(0x17ADCCD8 ^ 0x17ADF6BA), regKey);
			case 2:
				return (string)o8vb04CloUkP2E0xJ04(fcJU1FCmWflAlPV0qp1(0x76DD48E ^ 0x76DEE32), regKey);
			case 1:
				return (string)o8vb04CloUkP2E0xJ04(fcJU1FCmWflAlPV0qp1(-1411196499 ^ -1411194213), regKey);
			default:
				{
					if (QQxGRRCdH4bgiADqc3l(tac6EkC9OZqQiD05lA7(cultureFromSettings), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538525102)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_008e;
				}
				IL_008e:
				if (useStudentActivationUrl)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string GetCEActivationUrl(string regKey)
	{
		//Discarded unreachable code: IL_008e, IL_009d
		int num = 3;
		int num2 = num;
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return (string)o8vb04CloUkP2E0xJ04(fcJU1FCmWflAlPV0qp1(0x31326106 ^ 0x31325AB4), regKey);
			case 1:
				return (string)o8vb04CloUkP2E0xJ04(fcJU1FCmWflAlPV0qp1(-105199646 ^ -105186326), regKey);
			default:
				if (QQxGRRCdH4bgiADqc3l(tac6EkC9OZqQiD05lA7(cultureInfo), fcJU1FCmWflAlPV0qp1(0x269E5FCA ^ 0x269E458E)))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 3:
				cultureInfo = (CultureInfo)X8pl7uCrxNKbMgu9PoK();
				num2 = 2;
				break;
			case 2:
				if (cultureInfo == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static string GetInfoVersion([NotNull] Type type)
	{
		//Discarded unreachable code: IL_004f, IL_005e, IL_007f
		int num = 3;
		int num2 = num;
		AssemblyInformationalVersionAttribute assemblyInformationalVersionAttribute = default(AssemblyInformationalVersionAttribute);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!kJ4olECgvwuJXKj99GS(type, null))
				{
					num2 = 2;
					break;
				}
				goto case 4;
			default:
				if (assemblyInformationalVersionAttribute != null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 1:
				return GetVersion(type).ToString();
			case 5:
				return (string)aLWNUCC5DRTVI5y1piJ(assemblyInformationalVersionAttribute);
			case 4:
				throw new ArgumentNullException((string)fcJU1FCmWflAlPV0qp1(0x12441CA4 ^ 0x12441086));
			case 2:
				assemblyInformationalVersionAttribute = (AssemblyInformationalVersionAttribute)((IEnumerable<object>)oyyviiCMVbNVVLiHGqU(type.Assembly, imU4dgCyO3LP4dBaIIi(typeof(AssemblyInformationalVersionAttribute).TypeHandle), false)).FirstOrDefault();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string GetShortVersion<T>()
	{
		return GetVersion<T>().ToString(2);
	}

	public static ElmaEdition? GetEditionType()
	{
		GetEdition(out var editionType);
		return editionType;
	}

	public static string GetEdition()
	{
		ElmaEdition? editionType;
		return GetEdition(out editionType);
	}

	public static string GetEdition(out ElmaEdition? editionType)
	{
		string dbVersion;
		return GetEdition(out editionType, out dbVersion);
	}

	public static string GetEdition(out ElmaEdition? editionType, out string dbVersion)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (string)hSQXFKCYuVS0oixx4RG(ElmaEdition.CE);
			case 2:
				dbVersion = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				if (OysxoxCj2VgoCr6Joox())
				{
					num2 = 5;
					continue;
				}
				break;
			case 4:
				return "";
			case 5:
				editionType = ElmaEdition.CE;
				num2 = 2;
				continue;
			case 3:
				dbVersion = null;
				num2 = 4;
				continue;
			}
			editionType = null;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static object fcJU1FCmWflAlPV0qp1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type imU4dgCyO3LP4dBaIIi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object oyyviiCMVbNVVLiHGqU(object P_0, Type P_1, bool P_2)
	{
		return ((Assembly)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static object pMABvtCJjNXentJi4DD(object P_0)
	{
		return ((AssemblyFileVersionAttribute)P_0).Version;
	}

	internal static bool I4PcLjCxmEiSB0wBksy()
	{
		return V2KJygC7n9lDkuMxrng == null;
	}

	internal static VersionInfo oGwLVYC0552PMtOr3EO()
	{
		return V2KJygC7n9lDkuMxrng;
	}

	internal static object tac6EkC9OZqQiD05lA7(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static bool QQxGRRCdH4bgiADqc3l(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object o8vb04CloUkP2E0xJ04(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object X8pl7uCrxNKbMgu9PoK()
	{
		return SR.GetCultureFromSettings();
	}

	internal static bool kJ4olECgvwuJXKj99GS(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object aLWNUCC5DRTVI5y1piJ(object P_0)
	{
		return ((AssemblyInformationalVersionAttribute)P_0).InformationalVersion;
	}

	internal static bool OysxoxCj2VgoCr6Joox()
	{
		return ComponentManager.Initialized;
	}

	internal static object hSQXFKCYuVS0oixx4RG(ElmaEdition edition)
	{
		return LicensedUnitBase.Providers.GetVersionName(edition);
	}
}
