using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
public class RecreateMonitorCacheJobExecutor : ISchedulerTaskJobExecutor
{
	internal static RecreateMonitorCacheJobExecutor z3KbCB8iE5Egee2txQK;

	public bool CanExecute(ISchedulerTaskJob job)
	{
		return job is IRecreateMonitorCacheJob;
	}

	public JobResult Do(ISchedulerTaskJob job, DateTime dateToRun)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(job is IRecreateMonitorCacheJob))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
					{
						num2 = 0;
					}
					break;
				}
				Jr0p7n8LG5k17lYFSB8(W1H6N78fEH0YN0yi7Ut());
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				ProcessesWorkflowInstanceManager.Instance.RecreateCacheByUsers();
				num2 = 4;
				break;
			default:
				return null;
			case 4:
			{
				JobResult jobResult = new JobResult();
				yV86tC85m27ioBV6lpH(jobResult, H4kjkF87bqjD4qO3qs4(BbpedU8r57Y8td83Sn9(0x2C817E00 ^ 0x2C814796)));
				EuyyTo8ggJNQZYptDmJ(jobResult, JobStatus.Success);
				return jobResult;
			}
			case 2:
				qL3lZs8JdQQgMYBXbea(MonitorCacheItemManager.Instance);
				num2 = 3;
				break;
			}
		}
	}

	public RecreateMonitorCacheJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KEjmt481KdjbNelr4w9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool N1AUiI8uLans6ek7KRK()
	{
		return z3KbCB8iE5Egee2txQK == null;
	}

	internal static RecreateMonitorCacheJobExecutor Bjvswu8lX2Mb01aRr4r()
	{
		return z3KbCB8iE5Egee2txQK;
	}

	internal static object W1H6N78fEH0YN0yi7Ut()
	{
		return MonitorUpdateActionQueueItemManager.Instance;
	}

	internal static void Jr0p7n8LG5k17lYFSB8(object P_0)
	{
		((MonitorUpdateActionQueueItemManager)P_0).ClearQueue();
	}

	internal static void qL3lZs8JdQQgMYBXbea(object P_0)
	{
		((MonitorCacheItemManager)P_0).RecreateCache();
	}

	internal static object BbpedU8r57Y8td83Sn9(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object H4kjkF87bqjD4qO3qs4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void yV86tC85m27ioBV6lpH(object P_0, object P_1)
	{
		((JobResult)P_0).Information = (string)P_1;
	}

	internal static void EuyyTo8ggJNQZYptDmJ(object P_0, JobStatus P_1)
	{
		((JobResult)P_0).Status = P_1;
	}

	internal static void KEjmt481KdjbNelr4w9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
