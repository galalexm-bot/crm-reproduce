using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Impl;

[Component(Type = ComponentType.WebServer)]
internal class TrialLicenseChecker : ISweepHandler
{
	private DateTime? lastCheck;

	private static TrialLicenseChecker gnv2ej7aFh2P7aZnLBD;

	public void Execute()
	{
		//Discarded unreachable code: IL_00a9, IL_017b, IL_01a6, IL_01f7, IL_0206, IL_0288, IL_0297
		int num = 5;
		int num2 = num;
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					int num4;
					if (!uiaXAy7A4nauwgJE0ZW())
					{
						int num3 = 8;
						num4 = num3;
						goto IL_0051;
					}
					goto IL_00d4;
					IL_0051:
					while (true)
					{
						switch (num4)
						{
						case 4:
							wNKBLw7mGuTAr3SOA94(licensedUnit);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num4 = 2;
							}
							continue;
						case 8:
							return;
						case 5:
							if (licenseInfo == null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num4 = 7;
								}
								continue;
							}
							goto case 6;
						case 3:
							break;
						case 9:
							if (licensedUnit != null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
								{
									num4 = 0;
								}
								continue;
							}
							return;
						default:
							if (hKnh1t70RcUSoyfWEiw(licenseInfo) == 2)
							{
								num4 = 4;
								continue;
							}
							return;
						case 6:
							if (licenseInfo.LicenseType != 1)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 4;
						case 1:
							licenseInfo = licensedUnit.GetLicenseInfo();
							num4 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num4 = 1;
							}
							continue;
						case 7:
							return;
						case 2:
							return;
						}
						break;
					}
					goto IL_00d4;
					IL_00d4:
					licensedUnit = ((IModuleManager)wWLkfM7xXbOiRvN0w0J(NdUK0k77b4kg5FPFOJs())).MainApplication as ILicensedUnit;
					num4 = 9;
					goto IL_0051;
				}
				catch (Exception exception)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							((ILogger)nYg8lK7yttlSAn6RWP9()).Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317763126), exception);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 2:
				return;
			case 4:
				if (!UBs1D37HKHUrxAqa97e(KySmc374dY1cYew429Q(x6Ayjh7wWvNl6NeATRA(), lastCheck.Value), aJkQiT76ZA6nuUlaBbA(1.0)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 5:
				if (lastCheck.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				return;
			}
			lastCheck = x6Ayjh7wWvNl6NeATRA();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num2 = 1;
			}
		}
	}

	public TrialLicenseChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pJxSPN7M88ch9RZ2EHY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static DateTime x6Ayjh7wWvNl6NeATRA()
	{
		return DateTime.Now;
	}

	internal static TimeSpan KySmc374dY1cYew429Q(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static TimeSpan aJkQiT76ZA6nuUlaBbA(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static bool UBs1D37HKHUrxAqa97e(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static bool uiaXAy7A4nauwgJE0ZW()
	{
		return ComponentManager.Initialized;
	}

	internal static object NdUK0k77b4kg5FPFOJs()
	{
		return ComponentManager.Current;
	}

	internal static object wWLkfM7xXbOiRvN0w0J(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static byte hKnh1t70RcUSoyfWEiw(object P_0)
	{
		return ((ILicenseInfo)P_0).LicenseType;
	}

	internal static void wNKBLw7mGuTAr3SOA94(object P_0)
	{
		((ILicensedUnit)P_0).UpdateLicenseInfo();
	}

	internal static object nYg8lK7yttlSAn6RWP9()
	{
		return Logger.Log;
	}

	internal static bool JpNJGl7DHOZhcXjVyPX()
	{
		return gnv2ej7aFh2P7aZnLBD == null;
	}

	internal static TrialLicenseChecker yPi2EL7tnPho8CmL3ym()
	{
		return gnv2ej7aFh2P7aZnLBD;
	}

	internal static void pJxSPN7M88ch9RZ2EHY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
