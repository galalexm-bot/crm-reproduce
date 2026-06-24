using System;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Service]
public class MonitorCacheUpdateService : IMonitorCacheUpdateService
{
	private DateTime _lastUpdateTime;

	private readonly object _sinchUpdateTime;

	private static MonitorCacheUpdateService U33H5GCz638twAQk11f;

	[Transaction]
	public virtual void InvokeAction(IProcessHeader header, Guid action)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				P1IjooXXsRnQcWrAcXs(this, header, action, null);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void InvokeAction(IProcessHeader header, Guid action, IUser user)
	{
		//Discarded unreachable code: IL_00ac
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				return;
			case 1:
			{
				InstanceOf<IMonitorUpdateActionQueueItem> instanceOf = new InstanceOf<IMonitorUpdateActionQueueItem>();
				M9auKoX3IqZKuDCtFoV(instanceOf.New, action);
				Thr9JFXhs2pvRVHAgfp(instanceOf.New, header);
				wP4ub0XxuAd4w5El28i(instanceOf.New, user);
				instanceOf.New.Save();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				if (((MonitorUpdateActionQueueItemManager)CdYtO8XoJ1xYA7i5crq()).HasAction(header, action, user))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DateTime GetLastUpdateTime()
	{
		return _lastUpdateTime;
	}

	public void CacheUpdated()
	{
		//Discarded unreachable code: IL_006d, IL_00ce, IL_0106, IL_0115
		int num = 3;
		int num2 = num;
		bool lockTaken = default(bool);
		object sinchUpdateTime = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				sinchUpdateTime = _sinchUpdateTime;
				num2 = 2;
				continue;
			case 1:
				return;
			}
			try
			{
				Monitor.Enter(sinchUpdateTime, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					_lastUpdateTime = DateTime.Now;
					num3 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 != 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							DVqPotXFwXn9254cRVJ(sinchUpdateTime);
							num4 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public MonitorCacheUpdateService()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		_lastUpdateTime = DateTime.MinValue;
		_sinchUpdateTime = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void P1IjooXXsRnQcWrAcXs(object P_0, object P_1, Guid action, object P_3)
	{
		((MonitorCacheUpdateService)P_0).InvokeAction((IProcessHeader)P_1, action, (IUser)P_3);
	}

	internal static bool usFpyIXE5Bes9VHhshA()
	{
		return U33H5GCz638twAQk11f == null;
	}

	internal static MonitorCacheUpdateService A1Xe4CXCp9HkcJ54MGt()
	{
		return U33H5GCz638twAQk11f;
	}

	internal static object CdYtO8XoJ1xYA7i5crq()
	{
		return MonitorUpdateActionQueueItemManager.Instance;
	}

	internal static void M9auKoX3IqZKuDCtFoV(object P_0, Guid P_1)
	{
		((IMonitorUpdateActionQueueItem)P_0).ActionTypeUid = P_1;
	}

	internal static void Thr9JFXhs2pvRVHAgfp(object P_0, object P_1)
	{
		((IMonitorUpdateActionQueueItem)P_0).ProcessHeader = (IProcessHeader)P_1;
	}

	internal static void wP4ub0XxuAd4w5El28i(object P_0, object P_1)
	{
		((IMonitorUpdateActionQueueItem)P_0).User = (IUser)P_1;
	}

	internal static void DVqPotXFwXn9254cRVJ(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
