using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Db;

[Component(Type = ComponentType.Server)]
internal class FillUserSecuritySetCache : IInitHandler
{
	internal static FillUserSecuritySetCache TNdoScbKCjMnBjF3pdF;

	public void Init()
	{
	}

	public void InitComplete()
	{
		//Discarded unreachable code: IL_01aa, IL_024b, IL_025a
		int num = 4;
		int num2 = num;
		ITransaction val2 = default(ITransaction);
		ISession val = default(ISession);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					val2 = val.BeginTransaction();
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 5:
							((IQuery)f9jst0bDVbYtdVZeOJq(axt9ZKbEZVryBUaBQa4(val, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B377A3F)), 0)).ExecuteUpdate(cleanUpCache: false);
							num3 = 3;
							break;
						case 1:
							PecX3JbMkbSh5w7PG2n(val2);
							num3 = 2;
							break;
						case 6:
							xfn5vkbckPWf1mEelQ1(zSLECmbFE4WDswCgnGU(val, VM0vI4bG08l5CHZtnei(0x84482CB ^ 0x8447D15)), false);
							num3 = 4;
							break;
						case 3:
							xfn5vkbckPWf1mEelQ1(((IQuery)axt9ZKbEZVryBUaBQa4(val, VM0vI4bG08l5CHZtnei(0x432996D0 ^ 0x432896FA))).SetTimeout(0), false);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
							{
								num3 = 1;
							}
							break;
						default:
							xfn5vkbckPWf1mEelQ1(val.CreateSQLQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47403B)), false);
							num3 = 6;
							break;
						case 4:
						{
							val2.Commit();
							int num4 = 7;
							num3 = num4;
							break;
						}
						case 7:
							val2 = (ITransaction)Hpij39b0Xu71CfocXGy(val);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
							{
								num3 = 5;
							}
							break;
						case 2:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							iwFswobIlspZZmDJgG3(val2);
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
							{
								num5 = 0;
							}
							break;
						case 3:
							if (val2 != null)
							{
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
								{
									num5 = 1;
								}
								break;
							}
							return;
						case 2:
							kfq3yEbYc5Ry2qlsTft(YCnhd6bsbQ3U6CcA8VA(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x397B0322 ^ 0x397B5AD8), ex);
							num5 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 1:
				return;
			default:
				val2 = null;
				num2 = 2;
				break;
			case 4:
				if (!CVoRYJbOPvD6LT6vyU3(Locator.GetServiceNotNull<IRuntimeApplication>()))
				{
					num2 = 3;
					break;
				}
				val = (ISession)TbVWkNbqsinwJbFVyed(Locator.GetServiceNotNull<ISessionProvider>(), "");
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public FillUserSecuritySetCache()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CVoRYJbOPvD6LT6vyU3(object P_0)
	{
		return ((IRuntimeApplication)P_0).IsFirstServerInCluster;
	}

	internal static object TbVWkNbqsinwJbFVyed(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static int xfn5vkbckPWf1mEelQ1(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static object VM0vI4bG08l5CHZtnei(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zSLECmbFE4WDswCgnGU(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object Hpij39b0Xu71CfocXGy(object P_0)
	{
		return ((ISession)P_0).BeginTransaction();
	}

	internal static object axt9ZKbEZVryBUaBQa4(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object f9jst0bDVbYtdVZeOJq(object P_0, int P_1)
	{
		return ((IQuery)P_0).SetTimeout(P_1);
	}

	internal static void PecX3JbMkbSh5w7PG2n(object P_0)
	{
		((ITransaction)P_0).Commit();
	}

	internal static object YCnhd6bsbQ3U6CcA8VA()
	{
		return Logger.Log;
	}

	internal static void kfq3yEbYc5Ry2qlsTft(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void iwFswobIlspZZmDJgG3(object P_0)
	{
		((ITransaction)P_0).Rollback();
	}

	internal static bool UHP4C0btSPd0hjgJ7hO()
	{
		return TNdoScbKCjMnBjF3pdF == null;
	}

	internal static FillUserSecuritySetCache rPGqOVbhsPxAZefC9iA()
	{
		return TNdoScbKCjMnBjF3pdF;
	}
}
