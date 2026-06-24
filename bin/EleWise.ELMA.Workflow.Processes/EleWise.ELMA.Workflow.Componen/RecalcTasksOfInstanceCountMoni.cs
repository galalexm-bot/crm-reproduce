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
public class RecalcTasksOfInstanceCountMonitorUpdateQueueAction : BaseMonitorUpdateQueueAction
{
	public static Guid UID;

	internal static RecalcTasksOfInstanceCountMonitorUpdateQueueAction oT9fVfcceKFm3XwmhGC;

	public override Guid ActionUid => UID;

	public override string ActionName => (string)VqIugkcSNLpL876OEE9(pKoJIecjhmkeQej1hRJ(-1015538293 ^ -1015519461));

	protected override List<CountProcessInfo> GetCountByUsers(IProcessHeader header, bool isEmulation)
	{
		return MonitorCacheItemManager.Instance.GetActiveTaskCountByProcessByUsers(header.Id, isEmulation);
	}

	public override void DoAction(IProcessHeader header, IUser user)
	{
		int num = 10;
		IMonitorCacheItem monitorCacheItem = default(IMonitorCacheItem);
		CountProcessInfo activeTaskCountByProcess = default(CountProcessInfo);
		List<IUser> list = default(List<IUser>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (monitorCacheItem.ActiveTasksCount == Hd7GwicU8S1W6qoK6Xp(activeTaskCountByProcess))
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 16:
					if (user == null)
					{
						num2 = 15;
						continue;
					}
					return;
				case 13:
					sctNhucnx83YCcAVLN9(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
					num = 14;
					break;
				case 14:
					return;
				case 2:
					GetCacheItems(header, list).ForEach(_003C_003Ec__DisplayClass6_._003CDoAction_003Eb__1);
					num2 = 13;
					continue;
				case 4:
					SetNullToCache(header, (string)pKoJIecjhmkeQej1hRJ(-474638327 ^ -474619183), (string)pKoJIecjhmkeQej1hRJ(-1843608060 ^ -1843610376), null);
					num2 = 11;
					continue;
				case 10:
					monitorCacheItem = (IMonitorCacheItem)HeHXpyckDKjApUX6dPV(this, header, user);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
					{
						num2 = 9;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass6_.users = CacheUpdateDate(header);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (oBxNFmcmVba3uXkra6E(monitorCacheItem) != Fd99lIcAoovhjAo3unA(activeTaskCountByProcess))
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 16;
				case 12:
					monitorCacheItem.Save();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					AN7UHocpj3Saik8kWku(monitorCacheItem, activeTaskCountByProcess.CountRes);
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
					{
						num2 = 7;
					}
					continue;
				case 11:
					if (VZpgsJcyMP4b5fTSyCS(list) > 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 13;
				case 15:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num = 6;
					break;
				case 1:
					sctNhucnx83YCcAVLN9(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
					num2 = 16;
					continue;
				case 7:
					yeWa6AcGd49LWgytCO8(monitorCacheItem, Fd99lIcAoovhjAo3unA(activeTaskCountByProcess));
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					activeTaskCountByProcess = ((MonitorCacheItemManager)PV6yKQcbCd2aRQDs1mu()).GetActiveTaskCountByProcess(header.Id, user?.Id);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
					{
						num2 = 8;
					}
					continue;
				default:
					list = _003C_003Ec__DisplayClass6_.users.Select((Pair<IUser, Pair<long, long>> u) => u.First).ToList();
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public RecalcTasksOfInstanceCountMonitorUpdateQueueAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		b7K3oNcOx619iQEFAxj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RecalcTasksOfInstanceCountMonitorUpdateQueueAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object pKoJIecjhmkeQej1hRJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VqIugkcSNLpL876OEE9(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool yx1WIBcN11eOKLO06ZC()
	{
		return oT9fVfcceKFm3XwmhGC == null;
	}

	internal static RecalcTasksOfInstanceCountMonitorUpdateQueueAction dHkJS6cdcG5TFpptQeS()
	{
		return oT9fVfcceKFm3XwmhGC;
	}

	internal static object HeHXpyckDKjApUX6dPV(object P_0, object P_1, object P_2)
	{
		return ((BaseMonitorUpdateQueueAction)P_0).GetCacheItem((IProcessHeader)P_1, (IUser)P_2);
	}

	internal static object PV6yKQcbCd2aRQDs1mu()
	{
		return MonitorCacheItemManager.Instance;
	}

	internal static long Hd7GwicU8S1W6qoK6Xp(object P_0)
	{
		return ((CountProcessInfo)P_0).CountRes;
	}

	internal static long oBxNFmcmVba3uXkra6E(object P_0)
	{
		return ((IMonitorCacheItem)P_0).ActiveTasksCount;
	}

	internal static long Fd99lIcAoovhjAo3unA(object P_0)
	{
		return ((CountProcessInfo)P_0).CountResEml;
	}

	internal static void AN7UHocpj3Saik8kWku(object P_0, long P_1)
	{
		((IMonitorCacheItem)P_0).ActiveTasksCount = P_1;
	}

	internal static void yeWa6AcGd49LWgytCO8(object P_0, long P_1)
	{
		((IMonitorCacheItem)P_0).ActiveTasksEmlCount = P_1;
	}

	internal static void sctNhucnx83YCcAVLN9(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static int VZpgsJcyMP4b5fTSyCS(object P_0)
	{
		return ((List<IUser>)P_0).Count;
	}

	internal static void b7K3oNcOx619iQEFAxj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
