using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
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
public class RecalcCompleteInstanceCountMonitorUpdateQueueAction : BaseMonitorUpdateQueueAction
{
	public static Guid UID;

	internal static RecalcCompleteInstanceCountMonitorUpdateQueueAction gVCRiec6ASWJ2EbfHPZ;

	public override Guid ActionUid => UID;

	public override string ActionName => SR.T((string)hd5r1FcBEVqZHPPuoiv(0x624F2FBE ^ 0x624F5498));

	protected override List<CountProcessInfo> GetCountByUsers(IProcessHeader header, bool isEmulation)
	{
		return MonitorCacheItemManager.Instance.GetCompleteInstanceCountByUsers(header.Id, isEmulation);
	}

	public override void DoAction(IProcessHeader header, IUser user)
	{
		//Discarded unreachable code: IL_0153
		int num = 9;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		IMonitorCacheItem cacheItem = default(IMonitorCacheItem);
		CountProcessInfo completeInstanceCount = default(CountProcessInfo);
		List<IUser> list = default(List<IUser>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					_003C_003Ec__DisplayClass6_.users = CacheUpdateDate(header);
					num2 = 2;
					continue;
				case 9:
					cacheItem = GetCacheItem(header, user);
					num2 = 8;
					continue;
				case 7:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 13;
					continue;
				default:
					tC3mGTclMfRQZmZIJUs(cacheItem);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					Bxw0NvcLop7m23hGYuc(fDVMBgcfMvGKaAXyloI(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					return;
				case 3:
					cacheItem.CompletedInstanceCount = E6fryhciOH6ceixgkte(completeInstanceCount);
					num2 = 11;
					continue;
				case 16:
					if (a3XNOicHQfqu8oU8O8Q(cacheItem) == completeInstanceCount.CountRes)
					{
						num2 = 17;
						continue;
					}
					goto case 3;
				case 11:
					OseUFQcuHdar99YNm0b(cacheItem, completeInstanceCount.CountResEml);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (user != null)
					{
						return;
					}
					num2 = 7;
					continue;
				case 17:
					if (rDcjTEceBDvXB5oCuwX(cacheItem) != completeInstanceCount.CountResEml)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 1:
				case 12:
					Bxw0NvcLop7m23hGYuc(fDVMBgcfMvGKaAXyloI(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 10;
					continue;
				case 5:
					SetNullToCache(header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62463138 ^ 0x62464AAA), (string)hd5r1FcBEVqZHPPuoiv(-1164596236 ^ -1164586954), null);
					num2 = 15;
					continue;
				case 15:
					if (pN1fg6cJKpGO3aYIN5A(list) <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 14:
					GetCacheItems(header, list).ForEach(_003C_003Ec__DisplayClass6_._003CDoAction_003Eb__1);
					num2 = 12;
					continue;
				case 8:
					completeInstanceCount = ((MonitorCacheItemManager)g1OjC8cWO5rVZFwdAhw()).GetCompleteInstanceCount(header.Id, user?.Id);
					num2 = 16;
					continue;
				case 2:
					list = _003C_003Ec__DisplayClass6_.users.Select((Pair<IUser, Pair<long, long>> u) => u.First).ToList();
					num = 5;
					break;
				}
				break;
			}
		}
	}

	public RecalcCompleteInstanceCountMonitorUpdateQueueAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xMNDfDcrhM5yrdTqnVI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RecalcCompleteInstanceCountMonitorUpdateQueueAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)hd5r1FcBEVqZHPPuoiv(-1535001335 ^ -1534998799));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				xMNDfDcrhM5yrdTqnVI();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object hd5r1FcBEVqZHPPuoiv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Y2j8fccRXD1Wg2GhGY5()
	{
		return gVCRiec6ASWJ2EbfHPZ == null;
	}

	internal static RecalcCompleteInstanceCountMonitorUpdateQueueAction dgOIdVc0hm916chOURG()
	{
		return gVCRiec6ASWJ2EbfHPZ;
	}

	internal static object g1OjC8cWO5rVZFwdAhw()
	{
		return MonitorCacheItemManager.Instance;
	}

	internal static long a3XNOicHQfqu8oU8O8Q(object P_0)
	{
		return ((IMonitorCacheItem)P_0).CompletedInstanceCount;
	}

	internal static long rDcjTEceBDvXB5oCuwX(object P_0)
	{
		return ((IMonitorCacheItem)P_0).CompletedInstanceEmlCount;
	}

	internal static long E6fryhciOH6ceixgkte(object P_0)
	{
		return ((CountProcessInfo)P_0).CountRes;
	}

	internal static void OseUFQcuHdar99YNm0b(object P_0, long P_1)
	{
		((IMonitorCacheItem)P_0).CompletedInstanceEmlCount = P_1;
	}

	internal static void tC3mGTclMfRQZmZIJUs(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object fDVMBgcfMvGKaAXyloI(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void Bxw0NvcLop7m23hGYuc(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static int pN1fg6cJKpGO3aYIN5A(object P_0)
	{
		return ((List<IUser>)P_0).Count;
	}

	internal static void xMNDfDcrhM5yrdTqnVI()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
