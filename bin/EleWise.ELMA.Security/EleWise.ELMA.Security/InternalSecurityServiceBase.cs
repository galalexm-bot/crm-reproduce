using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.ActiveUserSession;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

internal abstract class InternalSecurityServiceBase : LicensedUnitBase
{
	private static InternalSecurityServiceBase zOeiGZAORbteRXdQKOR;

	protected virtual uint UsedLicenseCount
	{
		get
		{
			//Discarded unreachable code: IL_017c
			int num = 11;
			ActiveUserSessionService service = default(ActiveUserSessionService);
			byte licSubType = default(byte);
			int? num3 = default(int?);
			int? totalLoginCount = default(int?);
			ActiveUsersSessionInfo activeUsersSessionInfo = default(ActiveUsersSessionInfo);
			int? loginCount = default(int?);
			int? num4 = default(int?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int? num5;
					switch (num2)
					{
					case 5:
						service = Locator.GetService<ActiveUserSessionService>();
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
						{
							num2 = 7;
						}
						continue;
					case 11:
					{
						Check(out licSubType, out var _, out var _);
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					case 3:
						return 0u;
					case 12:
						num3 = null;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
						totalLoginCount = activeUsersSessionInfo.TotalLoginCount;
						num = 2;
						break;
					case 1:
						num5 = num3;
						goto IL_0254;
					case 8:
						loginCount = activeUsersSessionInfo.LoginCount;
						num2 = 9;
						continue;
					case 2:
						if (totalLoginCount.HasValue)
						{
							return (uint)totalLoginCount.GetValueOrDefault();
						}
						num = 8;
						break;
					case 9:
						if (!loginCount.HasValue)
						{
							num = 12;
							break;
						}
						num5 = -loginCount.GetValueOrDefault();
						goto IL_0254;
					case 6:
					{
						ActiveUserSessionService activeUserSessionService = service;
						AuthenticatedSessionInfo authenticatedSessionInfo = new AuthenticatedSessionInfo();
						YPcOYLAGyfStUrt8qTF(authenticatedSessionInfo, -1L);
						activeUsersSessionInfo = (ActiveUsersSessionInfo)cOCljrAFUYc5kLUv6IT(activeUserSessionService, authenticatedSessionInfo);
						num2 = 4;
						continue;
					}
					case 10:
						if (licSubType != 1)
						{
							object obj = OdcgSfA0AMjPArhvXq6(Locator.GetServiceNotNull<ISessionProvider>(), "");
							ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
							return (uint)TqqkBlAVt9AoPQkr2W2(UZjZ69A4NawJdxTeIvn(KhQyuPAIynM6JpItFvs(YCMLLGAY3koQHAHqwEs(obj, N9CYg0As42K3p0ge1OO(rPTwmjAEwvacN1STrhk(-1965109395 ^ -1965108383), wGBp5LAMhllQG6Opkp3(nEFYX5ADdCpqFTqiK1k(serviceNotNull), rPTwmjAEwvacN1STrhk(0x1A9A1A63 ^ 0x1A9A15BF)), 0, wGBp5LAMhllQG6Opkp3(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x715704E9)))), false)));
						}
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
						{
							num2 = 2;
						}
						continue;
					default:
						if (num4.HasValue)
						{
							return (uint)num4.GetValueOrDefault();
						}
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
						{
							num2 = 3;
						}
						continue;
					case 7:
						{
							if (service == null)
							{
								return 0u;
							}
							num2 = 6;
							continue;
						}
						IL_0254:
						num4 = num5;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}
	}

	protected virtual uint UsedPrivilegeCount
	{
		get
		{
			int num = 1;
			int num2 = num;
			ActiveUserSessionService service = default(ActiveUserSessionService);
			byte licSubType = default(byte);
			while (true)
			{
				switch (num2)
				{
				case 4:
					service = Locator.GetService<ActiveUserSessionService>();
					num2 = 3;
					break;
				case 3:
					if (service == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return (uint)service.GetPrivilegeUserIds(includeAdmin: false).Count();
				case 1:
				{
					Check(out licSubType, out var _, out var _);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					if (licSubType == 1)
					{
						num2 = 4;
						break;
					}
					return 0u;
				case 2:
					return 0u;
				}
			}
		}
	}

	protected abstract void Check(out byte licSubType, out ushort licCount, out ushort privilegeCount);

	protected virtual void CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		if (user == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580395993));
		}
		Check(out var _, out var _, out var _);
		if (isAlreadyLoggedFunc != null && isCurrentPrivilegeFunc != null && otherUsersCountFunc != null && !isCurrentPrivilegeFunc(0) && !(user.Uid == SecurityConstants.SystemUserUid))
		{
			bool num = isAlreadyLoggedFunc();
			int num2 = otherUsersCountFunc();
			if ((!num || num2 > 5000) && num2 >= 5000)
			{
				throw new SimultaneousSessionExceededException(user);
			}
		}
	}

	protected virtual bool CanCreateNewUser()
	{
		int num = 1;
		int num2 = num;
		byte licSubType = default(byte);
		ushort licCount = default(ushort);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				Check(out licSubType, out licCount, out var _);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				return true;
			}
			if (licSubType != 1)
			{
				object obj = OdcgSfA0AMjPArhvXq6(Locator.GetServiceNotNull<ISessionProvider>(), "");
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				return TqqkBlAVt9AoPQkr2W2(UZjZ69A4NawJdxTeIvn(KhQyuPAIynM6JpItFvs(((ISession)obj).CreateSQLQuery((string)N9CYg0As42K3p0ge1OO(rPTwmjAEwvacN1STrhk(-1826813434 ^ -1826810248), wGBp5LAMhllQG6Opkp3(nEFYX5ADdCpqFTqiK1k(serviceNotNull), rPTwmjAEwvacN1STrhk(0xCDF201B ^ 0xCDF2FC7)), 0, wGBp5LAMhllQG6Opkp3(nEFYX5ADdCpqFTqiK1k(serviceNotNull), rPTwmjAEwvacN1STrhk(-1842376086 ^ -1842380166)))), false))) < licCount;
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
			{
				num2 = 0;
			}
		}
	}

	protected override string GetComponentId()
	{
		return (string)rPTwmjAEwvacN1STrhk(0x116C2699 ^ 0x116C3A75);
	}

	protected override string GetComponentVersion()
	{
		return VersionInfo.GetVersion<SR>().ToString();
	}

	protected InternalSecurityServiceBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		osJPj5AQ9Hdp1LVWK0G();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void YPcOYLAGyfStUrt8qTF(object P_0, object P_1)
	{
		((AuthenticatedSessionInfo)P_0).UserId = P_1;
	}

	internal static object cOCljrAFUYc5kLUv6IT(object P_0, object P_1)
	{
		return ((ActiveUserSessionService)P_0).GetOtherUsersCount((AuthenticatedSessionInfo)P_1);
	}

	internal static object OdcgSfA0AMjPArhvXq6(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object rPTwmjAEwvacN1STrhk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nEFYX5ADdCpqFTqiK1k(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object wGBp5LAMhllQG6Opkp3(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object N9CYg0As42K3p0ge1OO(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object YCMLLGAY3koQHAHqwEs(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object KhQyuPAIynM6JpItFvs(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object UZjZ69A4NawJdxTeIvn(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static int TqqkBlAVt9AoPQkr2W2(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static bool XCnP2JAqVkKhy9LALlP()
	{
		return zOeiGZAORbteRXdQKOR == null;
	}

	internal static InternalSecurityServiceBase BOm6aRAcc6tSLkabNR5()
	{
		return zOeiGZAORbteRXdQKOR;
	}

	internal static void osJPj5AQ9Hdp1LVWK0G()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
