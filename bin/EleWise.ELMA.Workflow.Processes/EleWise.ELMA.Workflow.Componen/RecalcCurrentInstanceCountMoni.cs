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
public class RecalcCurrentInstanceCountMonitorUpdateQueueAction : BaseMonitorUpdateQueueAction
{
	public static Guid UID;

	private static RecalcCurrentInstanceCountMonitorUpdateQueueAction eY0xGMc720tLkaRJNBQ;

	public override Guid ActionUid => UID;

	public override string ActionName => (string)axYZcpcIGJS1N0Hx9bo(dLnNlPc17UkbnX05Wax(-282877824 ^ -282862392));

	protected override List<CountProcessInfo> GetCountByUsers(IProcessHeader header, bool isEmulation)
	{
		return MonitorCacheItemManager.Instance.GetCurrentInstanceCountByUsers(header.Id, isEmulation);
	}

	public override void DoAction(IProcessHeader header, IUser user)
	{
		//Discarded unreachable code: IL_0069
		int num = 2;
		IMonitorCacheItem monitorCacheItem = default(IMonitorCacheItem);
		CountProcessInfo currentInstanceCount = default(CountProcessInfo);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		List<IUser> list = default(List<IUser>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					SetNullToCache(header, (string)dLnNlPc17UkbnX05Wax(-1329217772 ^ -1329216584), (string)dLnNlPc17UkbnX05Wax(-1774307336 ^ -1774302432), null);
					num = 9;
					break;
				case 6:
				case 7:
					((ISession)IKEhduN3mWNRdNMxNPN(Locator.GetServiceNotNull<ISessionProvider>(), "")).Flush();
					num2 = 15;
					continue;
				case 14:
					UH6ZByNXcaxgjVkTlVC(monitorCacheItem, currentInstanceCount.CountResEml);
					num2 = 11;
					continue;
				case 16:
					if (monitorCacheItem.CurrentInstanceCount == UBKO4DczkKFStbFfCPs(currentInstanceCount))
					{
						num2 = 13;
						continue;
					}
					goto case 5;
				case 3:
					bojbRWNh7f6n7JDIsK0(IKEhduN3mWNRdNMxNPN(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 8;
					continue;
				case 13:
					if (EPy7dtNEVSYTXWCifuE(monitorCacheItem) != znbIckNC0vpgfGkewXR(currentInstanceCount))
					{
						num2 = 5;
						continue;
					}
					goto case 8;
				case 15:
					return;
				case 2:
					monitorCacheItem = (IMonitorCacheItem)rTCbqrcZyaGZnLNTpIL(this, header, user);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass6_.users = CacheUpdateDate(header);
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
					{
						num2 = 14;
					}
					continue;
				case 5:
					monitorCacheItem.CurrentInstanceCount = currentInstanceCount.CountRes;
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					if (user != null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num = 4;
					break;
				case 11:
					xedY9WNowMqVtUmbpdS(monitorCacheItem);
					num2 = 3;
					continue;
				case 9:
					if (Yvm0NcNx8vVwNRs9s84(list) <= 0)
					{
						num2 = 6;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 10:
					GetCacheItems(header, list).ForEach(_003C_003Ec__DisplayClass6_._003CDoAction_003Eb__1);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					currentInstanceCount = MonitorCacheItemManager.Instance.GetCurrentInstanceCount(header.Id, user?.Id);
					num2 = 16;
					continue;
				case 17:
					list = _003C_003Ec__DisplayClass6_.users.Select((Pair<IUser, Pair<long, long>> u) => u.First).ToList();
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	public RecalcCurrentInstanceCountMonitorUpdateQueueAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RAEF3mNFslPuCUtDr9p();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RecalcCurrentInstanceCountMonitorUpdateQueueAction()
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
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)dLnNlPc17UkbnX05Wax(-465190147 ^ -465190921));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object dLnNlPc17UkbnX05Wax(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object axYZcpcIGJS1N0Hx9bo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool uAUCtsc5qlslXutxqI9()
	{
		return eY0xGMc720tLkaRJNBQ == null;
	}

	internal static RecalcCurrentInstanceCountMonitorUpdateQueueAction jNlh59cgUAeVfTPrw7I()
	{
		return eY0xGMc720tLkaRJNBQ;
	}

	internal static object rTCbqrcZyaGZnLNTpIL(object P_0, object P_1, object P_2)
	{
		return ((BaseMonitorUpdateQueueAction)P_0).GetCacheItem((IProcessHeader)P_1, (IUser)P_2);
	}

	internal static long UBKO4DczkKFStbFfCPs(object P_0)
	{
		return ((CountProcessInfo)P_0).CountRes;
	}

	internal static long EPy7dtNEVSYTXWCifuE(object P_0)
	{
		return ((IMonitorCacheItem)P_0).CurrentInstanceEmlCount;
	}

	internal static long znbIckNC0vpgfGkewXR(object P_0)
	{
		return ((CountProcessInfo)P_0).CountResEml;
	}

	internal static void UH6ZByNXcaxgjVkTlVC(object P_0, long P_1)
	{
		((IMonitorCacheItem)P_0).CurrentInstanceEmlCount = P_1;
	}

	internal static void xedY9WNowMqVtUmbpdS(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object IKEhduN3mWNRdNMxNPN(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void bojbRWNh7f6n7JDIsK0(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static int Yvm0NcNx8vVwNRs9s84(object P_0)
	{
		return ((List<IUser>)P_0).Count;
	}

	internal static void RAEF3mNFslPuCUtDr9p()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
