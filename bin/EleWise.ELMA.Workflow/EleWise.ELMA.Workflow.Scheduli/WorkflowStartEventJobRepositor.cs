using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Workflow.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
internal sealed class WorkflowStartEventJobRepository : ISchedulerJobRepository
{
	private class SchedulerJob : SchedulerJobBase
	{
		private readonly IEnumerable<IEventTrigger> eventTriggers;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public SchedulerJob(IProductionCalendarService productionCalendarService, IEnumerable<IEventTrigger> eventTriggers)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			this.eventTriggers = eventTriggers;
			Trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				RepeatSettings = new RepeatSettings
				{
					Enabled = true,
					RepeatEvery = TimeSpan.FromMinutes(5.0),
					RepeatTo = TimeSpan.FromHours(24.0)
				},
				StartDate = DateTime.Today.AddMinutes(2.0)
			}, productionCalendarService)
			{
				Id = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539850425)),
				Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x14305C8))
			};
			Jobs = new Job[1]
			{
				new Job(eventTriggers)
			};
		}
	}

	private class Job : IJob
	{
		private readonly IEnumerable<IEventTrigger> eventTriggers;

		private static object eh2lO7ZjmmZWUf7MBSZa;

		public Guid Id => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708305238));

		public string Name => SR.T((string)D25XfWZj5GTHwNFPYSJB(0x1843E01F ^ 0x18412D29));

		public Image Icon => null;

		public Job(IEnumerable<IEventTrigger> eventTriggers)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			this.eventTriggers = eventTriggers;
		}

		public JobResult Do(DateTime dateToRun)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					JobResult jobResult = new JobResult();
					iBq60TZjgwWxy0yYEKW5(jobResult, JobStatus.Success);
					hIciDoZjBGL4WpUkIjmJ(jobResult, true);
					jobResult.Information = (string)X2FaMMZjc4i3OXZcCKqL(D25XfWZj5GTHwNFPYSJB(0xDF4D1F8 ^ 0xDF61C96));
					return jobResult;
				}
				case 1:
					eventTriggers.ForEach(delegate(IEventTrigger e)
					{
						_003C_003Ec.ckN0jrvT2VSw3v6PhpXl(e);
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool snZHFNZjthNpie0asE07()
		{
			return eh2lO7ZjmmZWUf7MBSZa == null;
		}

		internal static Job zGQ6WxZjbKUynowySC0Y()
		{
			return (Job)eh2lO7ZjmmZWUf7MBSZa;
		}

		internal static object D25XfWZj5GTHwNFPYSJB(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void iBq60TZjgwWxy0yYEKW5(object P_0, JobStatus P_1)
		{
			((JobResult)P_0).Status = P_1;
		}

		internal static void hIciDoZjBGL4WpUkIjmJ(object P_0, bool P_1)
		{
			((JobResult)P_0).NoSaveResult = P_1;
		}

		internal static object X2FaMMZjc4i3OXZcCKqL(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly IEnumerable<IEventTrigger> eventTriggers;

	public WorkflowStartEventJobRepository(IProductionCalendarService productionCalendarService, IEnumerable<IEventTrigger> eventTriggers)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		this.productionCalendarService = productionCalendarService;
		this.eventTriggers = eventTriggers;
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new SchedulerJob[1]
		{
			new SchedulerJob(productionCalendarService, eventTriggers)
		};
	}
}
