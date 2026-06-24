using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service]
public class InstanceMetricService : IInstanceMetricService
{
	private static InstanceMetricService asaxbQMCRIWe52cCAgs;

	public void UpdateWithExecutionTime(IWorkflowInstance instance, ProcessInstanceMetric metric, TimeSpan? time)
	{
		TimeSpan? timeSpan = instance.MetricValues.GetPropertyValue(metric.Uid) as TimeSpan?;
		if (time.HasValue && timeSpan.HasValue)
		{
			switch (metric.TimeMetricProcessTaskRepeatAction)
			{
			case ProcessMetricTaskRepeatAction.Sum:
				time = timeSpan + time;
				break;
			case ProcessMetricTaskRepeatAction.Minimum:
				time = ((timeSpan > time) ? time : timeSpan);
				break;
			case ProcessMetricTaskRepeatAction.Maximum:
				time = ((timeSpan < time) ? time : timeSpan);
				break;
			case ProcessMetricTaskRepeatAction.First:
				time = timeSpan ?? time;
				break;
			default:
				throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720483061), metric.TimeMetricProcessTaskRepeatAction.ToString()));
			case ProcessMetricTaskRepeatAction.Average:
			case ProcessMetricTaskRepeatAction.Last:
				break;
			}
		}
		instance.MetricValues.SetPropertyValue(metric.Uid, time);
	}

	public InstanceMetricService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool z2yV5WMMJIkbPEPZKWF()
	{
		return asaxbQMCRIWe52cCAgs == null;
	}

	internal static InstanceMetricService btidaNMklWwUP0SUPf4()
	{
		return asaxbQMCRIWe52cCAgs;
	}
}
