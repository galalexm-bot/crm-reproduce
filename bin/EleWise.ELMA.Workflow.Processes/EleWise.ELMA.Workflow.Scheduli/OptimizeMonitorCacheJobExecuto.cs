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
public class OptimizeMonitorCacheJobExecutor : ISchedulerTaskJobExecutor
{
	internal static OptimizeMonitorCacheJobExecutor lS0ajr8nCs3rsJQ0bf4;

	public bool CanExecute(ISchedulerTaskJob job)
	{
		return job is IOptimizeMonitorCacheJob;
	}

	public JobResult Do(ISchedulerTaskJob job, DateTime dateToRun)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (job is IOptimizeMonitorCacheJob)
				{
					zsCLiJ8RDLBkU3t91ZG(ANOGum867PSRoem5MSX());
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
			{
				JobResult jobResult = new JobResult();
				RQij0n8WD31FyIgl5XX(jobResult, M5uQCI8BLNZEFpem7GE(TfMG0i80AQrELOMdrob(-2144947971 ^ -2144957967)));
				rDevb38H3Bm2ahyQST1(jobResult, JobStatus.Success);
				return jobResult;
			}
			}
		}
	}

	public OptimizeMonitorCacheJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dGdEPx8evW7qbNJq2RI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nX4Bgd8yt0sGC4ub6Ed()
	{
		return lS0ajr8nCs3rsJQ0bf4 == null;
	}

	internal static OptimizeMonitorCacheJobExecutor oFD2rJ8ONednr7hZRco()
	{
		return lS0ajr8nCs3rsJQ0bf4;
	}

	internal static object ANOGum867PSRoem5MSX()
	{
		return MonitorUpdateActionQueueItemManager.Instance;
	}

	internal static void zsCLiJ8RDLBkU3t91ZG(object P_0)
	{
		((MonitorUpdateActionQueueItemManager)P_0).OptimizeCacheActions();
	}

	internal static object TfMG0i80AQrELOMdrob(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M5uQCI8BLNZEFpem7GE(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void RQij0n8WD31FyIgl5XX(object P_0, object P_1)
	{
		((JobResult)P_0).Information = (string)P_1;
	}

	internal static void rDevb38H3Bm2ahyQST1(object P_0, JobStatus P_1)
	{
		((JobResult)P_0).Status = P_1;
	}

	internal static void dGdEPx8evW7qbNJq2RI()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
