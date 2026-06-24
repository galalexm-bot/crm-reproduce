using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class RecalcTerminateInstanceCountMonitorUpdateQueueAction : BaseMonitorUpdateQueueAction
{
	public static Guid UID;

	private static RecalcTerminateInstanceCountMonitorUpdateQueueAction HrBGHiN81blfKgu3AOg;

	public override Guid ActionUid => UID;

	public override string ActionName => (string)gxXeV2N2sPFNAeCBge7(boOpe1Ns22JCLKfV23b(0x138E9AEB ^ 0x138EE7B1));

	protected override List<CountProcessInfo> GetCountByUsers(IProcessHeader header, bool isEmulation)
	{
		return MonitorCacheItemManager.Instance.GetTerminateInstanceCountByUsers(header.Id, isEmulation);
	}

	public override void DoAction(IProcessHeader header, IUser user)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4
		int num = 9;
		int num2 = num;
		List<IUser> list = default(List<IUser>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		IMonitorCacheItem monitorCacheItem = default(IMonitorCacheItem);
		CountProcessInfo terminateInstanceCount = default(CountProcessInfo);
		while (true)
		{
			switch (num2)
			{
			case 17:
				if (qvoH8SNYhUeTqFR1w1Y(list) <= 0)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				GetCacheItems(header, list).ForEach(_003C_003Ec__DisplayClass6_._003CDoAction_003Eb__1);
				num2 = 10;
				break;
			case 13:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 12;
				break;
			case 4:
				monitorCacheItem.TerminatedInstanceEmlCount = uYN8XlND3Ir2Y757the(terminateInstanceCount);
				num2 = 5;
				break;
			case 16:
				fcObDwNaV4s2qbsa7Ld(MSuSsENMoy5cs61Epf6(Locator.GetServiceNotNull<ISessionProvider>(), ""));
				num2 = 14;
				break;
			case 15:
				monitorCacheItem.TerminatedInstanceCount = K4KQG0NKnb5B67rOtCc(terminateInstanceCount);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 4;
				}
				break;
			case 14:
				if (user == null)
				{
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 12:
				_003C_003Ec__DisplayClass6_.users = CacheUpdateDate(header);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				if (monitorCacheItem.TerminatedInstanceCount == terminateInstanceCount.CountRes)
				{
					num2 = 11;
					break;
				}
				goto case 15;
			case 9:
				monitorCacheItem = (IMonitorCacheItem)CTtybwNqslSMdricOAh(this, header, user);
				num2 = 8;
				break;
			case 2:
			case 10:
				fcObDwNaV4s2qbsa7Ld(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				if (AHIJZZNV2Dsf5E7cTmV(monitorCacheItem) != uYN8XlND3Ir2Y757the(terminateInstanceCount))
				{
					num2 = 15;
					break;
				}
				goto case 14;
			default:
				SetNullToCache(header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFA4957C ^ 0xFA4E8B8), (string)boOpe1Ns22JCLKfV23b(-1633140121 ^ -1633140847), null);
				num2 = 17;
				break;
			case 3:
				return;
			case 5:
				monitorCacheItem.Save();
				num2 = 16;
				break;
			case 8:
				terminateInstanceCount = ((MonitorCacheItemManager)uRp457NQ5ZEuEhxOngN()).GetTerminateInstanceCount(header.Id, user?.Id);
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				list = _003C_003Ec__DisplayClass6_.users.Select((Pair<IUser, Pair<long, long>> u) => u.First).ToList();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public RecalcTerminateInstanceCountMonitorUpdateQueueAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i4dA44NvUfZFlmQJWM8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RecalcTerminateInstanceCountMonitorUpdateQueueAction()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)boOpe1Ns22JCLKfV23b(0xFAE81C9 ^ 0xFAEFFE7));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object boOpe1Ns22JCLKfV23b(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gxXeV2N2sPFNAeCBge7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool zNUsBONw0otZvMMGxpj()
	{
		return HrBGHiN81blfKgu3AOg == null;
	}

	internal static RecalcTerminateInstanceCountMonitorUpdateQueueAction OhvoN1Nt0Kv2ZILT0Wb()
	{
		return HrBGHiN81blfKgu3AOg;
	}

	internal static object CTtybwNqslSMdricOAh(object P_0, object P_1, object P_2)
	{
		return ((BaseMonitorUpdateQueueAction)P_0).GetCacheItem((IProcessHeader)P_1, (IUser)P_2);
	}

	internal static object uRp457NQ5ZEuEhxOngN()
	{
		return MonitorCacheItemManager.Instance;
	}

	internal static long AHIJZZNV2Dsf5E7cTmV(object P_0)
	{
		return ((IMonitorCacheItem)P_0).TerminatedInstanceEmlCount;
	}

	internal static long uYN8XlND3Ir2Y757the(object P_0)
	{
		return ((CountProcessInfo)P_0).CountResEml;
	}

	internal static long K4KQG0NKnb5B67rOtCc(object P_0)
	{
		return ((CountProcessInfo)P_0).CountRes;
	}

	internal static object MSuSsENMoy5cs61Epf6(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void fcObDwNaV4s2qbsa7Ld(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static int qvoH8SNYhUeTqFR1w1Y(object P_0)
	{
		return ((List<IUser>)P_0).Count;
	}

	internal static void i4dA44NvUfZFlmQJWM8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
