using System;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Scheduling.Impl;

[Component]
internal sealed class SchedulerTaskEventListener : PostFlushEventListener
{
	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly ContextVars.Local<bool> needRefresh;

	internal static SchedulerTaskEventListener gJUcw1BkKw6Ltp4N8mU3;

	public SchedulerTaskEventListener(IActorModelRuntime actorModelRuntime, IUnitOfWorkManager unitOfWorkManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tjtEyoBkkYq8eBNIXurM();
		needRefresh = new ContextVars.Local<bool>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.unitOfWorkManager = unitOfWorkManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
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
				Refresh(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISchedulerTask);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
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
				Refresh(NIpIASBkn1HwjUODQJfX(@event) as ISchedulerTask);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Refresh(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ISchedulerTask);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void Refresh(ISchedulerTask schedulerTask)
	{
		int num = 3;
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
				return;
			case 1:
				gwbEwTBkOvMZS86kAm7Q(unitOfWorkManager, (Action)delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							actorModelRuntime.GetActor<ISchedulerJobDbRepositoryActor>(Guid.Empty).Refresh();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (schedulerTask == null)
				{
					return;
				}
				num2 = 2;
				break;
			case 2:
				if (!needRefresh.Value)
				{
					needRefresh.Value = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	internal static void tjtEyoBkkYq8eBNIXurM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MyTU9NBkXRYWt5h6eyUA()
	{
		return gJUcw1BkKw6Ltp4N8mU3 == null;
	}

	internal static SchedulerTaskEventListener uMD2xXBkT8O11kkuD23N()
	{
		return gJUcw1BkKw6Ltp4N8mU3;
	}

	internal static object NIpIASBkn1HwjUODQJfX(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void gwbEwTBkOvMZS86kAm7Q(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}
}
