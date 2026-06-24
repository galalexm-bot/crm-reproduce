using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.DTO.Models;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public class StartTimerSettings
{
	internal static StartTimerSettings Id0hI8Zy8aLfcKJWJC71;

	public SchedulerTaskDTO SchedulerTask
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerTask_003Ek__BackingField;
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
					_003CSchedulerTask_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public StartTimerSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		e2c9TkZylKQhVfgR8kMA();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				((NthIncludedDaySettings)i2atwDZy0SUsLoj4n9rq(SchedulerTask)).OvertimeToRun = TimeSpan.MaxValue;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num = 0;
				}
				break;
			case 3:
				SchedulerTask = new SchedulerTaskDTO();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num = 1;
				}
				break;
			default:
				Ai1PK7ZyyLpNEbafIeTy(SchedulerTask, SchedulerTaskStatus.Enabled);
				num = 2;
				break;
			}
		}
	}

	internal static void e2c9TkZylKQhVfgR8kMA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object i2atwDZy0SUsLoj4n9rq(object P_0)
	{
		return ((SchedulerTaskDTO)P_0).Settings;
	}

	internal static void Ai1PK7ZyyLpNEbafIeTy(object P_0, SchedulerTaskStatus P_1)
	{
		((SchedulerTaskDTO)P_0).Status = P_1;
	}

	internal static bool YDyHQlZysM3sB2Xuc89n()
	{
		return Id0hI8Zy8aLfcKJWJC71 == null;
	}

	internal static StartTimerSettings dhdCTRZyJpqkpmlwey3C()
	{
		return Id0hI8Zy8aLfcKJWJC71;
	}
}
