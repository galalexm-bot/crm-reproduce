using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class SetTimeWorkflowIndicatorJobRepository : ISchedulerJobRepository
{
	private class SetTimeWorkflowIndicatorJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			internal static object WHdsPdvTjlaBKqDQhFoq;

			public Guid Id => new Guid((string)YicYURvTqEyn3awboAjV(-1638225214 ^ -1638378676));

			public string Name => SR.T((string)YicYURvTqEyn3awboAjV(-2111219045 ^ -2111069375));

			public Image Icon => (Image)KTtOSFvT3ROgLgYVPZvE();

			public JobResult Do(DateTime dateToRun)
			{
				int num = 5;
				int num2 = num;
				Stopwatch stopwatch = default(Stopwatch);
				StringBuilder stringBuilder = default(StringBuilder);
				while (true)
				{
					switch (num2)
					{
					case 4:
						stopwatch = new Stopwatch();
						num2 = 7;
						break;
					case 6:
					{
						JobResult jobResult = new JobResult();
						JHPiCvvTk8ZTnP3qFuXY(jobResult, JobStatus.Success);
						IMLlX0vTU0um0uHBSrY8(jobResult, stringBuilder.ToString());
						return jobResult;
					}
					case 5:
						stringBuilder = new StringBuilder();
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
						{
							num2 = 4;
						}
						break;
					default:
						WkNYV1vTpwgyIoCRtsh0(cKYC36vTQrk2jjM6NbJG());
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						mxMm9JvTCqy7FM2jRm6X(stringBuilder, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135578546), nDwHZWvTMsjM4lL2DCJ8(stopwatch)));
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
						{
							num2 = 2;
						}
						break;
					case 7:
						WRKVGwvTTxQ1luthqY77(stopwatch);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						mxMm9JvTCqy7FM2jRm6X(stringBuilder, "");
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						stopwatch.Stop();
						num2 = 2;
						break;
					}
				}
			}

			public JobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object YicYURvTqEyn3awboAjV(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool t0LkyRvTRyOc07WmOjKL()
			{
				return WHdsPdvTjlaBKqDQhFoq == null;
			}

			internal static JobImpl VYQKYTvT6tNpgc4yHSpg()
			{
				return (JobImpl)WHdsPdvTjlaBKqDQhFoq;
			}

			internal static object KTtOSFvT3ROgLgYVPZvE()
			{
				return Resources.BPMNProcess16;
			}

			internal static void WRKVGwvTTxQ1luthqY77(object P_0)
			{
				((Stopwatch)P_0).Start();
			}

			internal static object cKYC36vTQrk2jjM6NbJG()
			{
				return MetricValueDataManager.Instance;
			}

			internal static void WkNYV1vTpwgyIoCRtsh0(object P_0)
			{
				((MetricValueDataManager)P_0).CheckCriticalTimeMetric();
			}

			internal static object mxMm9JvTCqy7FM2jRm6X(object P_0, object P_1)
			{
				return ((StringBuilder)P_0).AppendLine((string)P_1);
			}

			internal static long nDwHZWvTMsjM4lL2DCJ8(object P_0)
			{
				return ((Stopwatch)P_0).ElapsedMilliseconds;
			}

			internal static void JHPiCvvTk8ZTnP3qFuXY(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void IMLlX0vTU0um0uHBSrY8(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}
		}

		private readonly object _trigger;

		private readonly ICollection<IJob> _jobs;

		internal static object sfFJuAZW4eUoL7nKLfNb;

		public override ITrigger Trigger => (ITrigger)_trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public SetTimeWorkflowIndicatorJob()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			r1BL63ZjOxTvNo4FAoDA();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					_jobs = new List<IJob>
					{
						new JobImpl()
					};
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num = 2;
					}
					continue;
				}
				NthIncludedDayTrigger obj = new NthIncludedDayTrigger(new NthIncludedDaySettings
				{
					ScheduleType = ScheduleType.Daily,
					DailySettings = new DailySettings
					{
						EveryDay = 1,
						OnlyWorkDays = false
					},
					StartDate = K0CCO4ZjZuSIQ2KjbNmR().AddMinutes(1.0),
					OvertimeToRun = fZRYOSZjvUgCKvkDMXD8(1.0),
					RepeatSettings = new RepeatSettings
					{
						Enabled = true,
						RepeatEvery = fZRYOSZjvUgCKvkDMXD8(1.0)
					}
				}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
				{
					Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862245930))
				};
				vW1tXmZjYY6wZV37Qu9t(obj, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B7D4C5)));
				_trigger = obj;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num = 1;
				}
			}
		}

		internal static void r1BL63ZjOxTvNo4FAoDA()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static DateTime K0CCO4ZjZuSIQ2KjbNmR()
		{
			return DateTime.Today;
		}

		internal static TimeSpan fZRYOSZjvUgCKvkDMXD8(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static void vW1tXmZjYY6wZV37Qu9t(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static bool qoRX8vZWz2FLYFvwOrbb()
		{
			return sfFJuAZW4eUoL7nKLfNb == null;
		}

		internal static SetTimeWorkflowIndicatorJob esNAxgZjKTdXtAnlAyyM()
		{
			return (SetTimeWorkflowIndicatorJob)sfFJuAZW4eUoL7nKLfNb;
		}
	}

	private static SetTimeWorkflowIndicatorJobRepository qlVuEetbChPG7Jga2KC;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new SetTimeWorkflowIndicatorJob()
		};
	}

	public SetTimeWorkflowIndicatorJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		I7s4CMtBBLKZ2ix3GxR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void I7s4CMtBBLKZ2ix3GxR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool YpFP3at5BUvA1icjEZu()
	{
		return qlVuEetbChPG7Jga2KC == null;
	}

	internal static SetTimeWorkflowIndicatorJobRepository cI7EOHtgtBG5wONNI98()
	{
		return qlVuEetbChPG7Jga2KC;
	}
}
