using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Impl;

[Service(Type = ComponentType.WebServer, EnableInterceptors = false)]
public class StepScheduler : IStepScheduler
{
	internal static StepScheduler JuGM38BkNEHtaPxdnZnE;

	[NotNull]
	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ISchedulerJobRepository> SchedulerJobRepository { get; set; }

	public SchedulerJobRepository OnceSchedulerJobRepository
	{
		[CompilerGenerated]
		get
		{
			return _003COnceSchedulerJobRepository_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003COnceSchedulerJobRepository_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public SchedulerJobRunInfoManager SchedulerJobRunInfoReposotory
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerJobRunInfoReposotory_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSchedulerJobRunInfoReposotory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMembershipService MembershipService
	{
		[CompilerGenerated]
		get
		{
			return _003CMembershipService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CMembershipService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public SessionFactoryHolder SessionFactoryHolder
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionFactoryHolder_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSessionFactoryHolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void RunTrigger(Guid triggerId)
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
				ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).RunTrigger(triggerId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RunSchedulerJob(ISchedulerJob schedulerJob, DateTime now)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				VaEY5ABkDSP6VtUXg2Uf(wIkjqoBktesZbTwb6oD2(schedulerJob), PB6Bt3BkadgpCXAbdSNF(-867826612 ^ -867748808));
				num2 = 3;
				break;
			case 3:
				ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).RunSchedulerJob(NT3NDdBkwbSR9e5VhZ3e(wIkjqoBktesZbTwb6oD2(schedulerJob)), now, forceRun: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				VaEY5ABkDSP6VtUXg2Uf(schedulerJob, PB6Bt3BkadgpCXAbdSNF(0x1DE3DD89 ^ 0x1DE2EDD1));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ForceRunSchedulerJob(ISchedulerJob schedulerJob, DateTime now)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				cx12xWBk4UOkC7mLx8qx(ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty), NT3NDdBkwbSR9e5VhZ3e(schedulerJob.Trigger), now, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				VaEY5ABkDSP6VtUXg2Uf(wIkjqoBktesZbTwb6oD2(schedulerJob), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542668311));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				VaEY5ABkDSP6VtUXg2Uf(schedulerJob, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70060203));
				num2 = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public ISchedulerJobRunInfo ForceRunJob(ISchedulerJob schedulerJob, IJob job, DateTime now)
	{
		int num = 2;
		int num2 = num;
		ISchedulerActor actor = default(ISchedulerActor);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				SchedulerJobRunInfoManager schedulerJobRunInfoReposotory = SchedulerJobRunInfoReposotory;
				object trigger = wIkjqoBktesZbTwb6oD2(schedulerJob);
				JobResult jobResult = new JobResult();
				pkEht7Bk6fuNeVcJUr9O(jobResult, JobStatus.Pending);
				ISchedulerJobRunInfo result = schedulerJobRunInfoReposotory.SetResult((ITrigger)trigger, job, now, jobResult);
				actor.ForceRunJob(((ITrigger)wIkjqoBktesZbTwb6oD2(schedulerJob)).Id, UvlmUuBkHEUIThd4KDJx(job), now);
				return result;
			}
			case 2:
				Contract.ArgumentNotNull(schedulerJob, (string)PB6Bt3BkadgpCXAbdSNF(-889460160 ^ -889529832));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				Contract.ArgumentNotNull(job, (string)PB6Bt3BkadgpCXAbdSNF(-1459557599 ^ -1459501475));
				num2 = 3;
				break;
			case 1:
				VaEY5ABkDSP6VtUXg2Uf(schedulerJob.Trigger, PB6Bt3BkadgpCXAbdSNF(-281842504 ^ -281912116));
				num2 = 4;
				break;
			case 3:
				actor = Locator.GetServiceNotNull<IActorModelRuntime>().GetActor<ISchedulerActor>(Guid.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public StepScheduler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P3nrJIBkAShpTSN3ETr2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JTT744Bk3eyNFuQT8K7B()
	{
		return JuGM38BkNEHtaPxdnZnE == null;
	}

	internal static StepScheduler O1K4vUBkpp1JtwjhXtfR()
	{
		return JuGM38BkNEHtaPxdnZnE;
	}

	internal static object PB6Bt3BkadgpCXAbdSNF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void VaEY5ABkDSP6VtUXg2Uf(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object wIkjqoBktesZbTwb6oD2(object P_0)
	{
		return ((ISchedulerJob)P_0).Trigger;
	}

	internal static Guid NT3NDdBkwbSR9e5VhZ3e(object P_0)
	{
		return ((ITrigger)P_0).Id;
	}

	internal static object cx12xWBk4UOkC7mLx8qx(object P_0, Guid triggerUid, DateTime currentDateTime, bool forceRun)
	{
		return ((ISchedulerActor)P_0).RunSchedulerJob(triggerUid, currentDateTime, forceRun);
	}

	internal static void pkEht7Bk6fuNeVcJUr9O(object P_0, JobStatus value)
	{
		((JobResult)P_0).Status = value;
	}

	internal static Guid UvlmUuBkHEUIThd4KDJx(object P_0)
	{
		return ((IJob)P_0).Id;
	}

	internal static void P3nrJIBkAShpTSN3ETr2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
