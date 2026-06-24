using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Type = ComponentType.WebServer)]
public class ReplacementPeriodJobRepository : ISchedulerJobRepository
{
	private class ReplacementPeriodJob : SchedulerJobBase
	{
		private class ReplacementJobImpl : IJob
		{
			private static object M7xii7pJD3xhA0jdL1rC;

			private ReplacementManager Manager => (ReplacementManager)RaIPvapJYXkKo1AXJ1CJ();

			public Guid Id => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335C0E13));

			public string Name => (string)J9qxilpJICimp2YLnHrg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417CC83E));

			public Image Icon => null;

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
						ziMLXNpJV0W3fCawrkmC(jobResult, JobStatus.Success);
						jobResult.Information = (string)J9qxilpJICimp2YLnHrg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40944BC4 ^ 0x409501DA));
						return jobResult;
					}
					case 1:
						nbYFDZpJ4attR686gFUY(Manager);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public ReplacementJobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				fRjydxpJQbVvrTxCIXSv();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object RaIPvapJYXkKo1AXJ1CJ()
			{
				return ReplacementManager.Instance;
			}

			internal static bool DInKRbpJMkV1t715U5tt()
			{
				return M7xii7pJD3xhA0jdL1rC == null;
			}

			internal static ReplacementJobImpl rRYBGupJsWh4vZVaIf9t()
			{
				return (ReplacementJobImpl)M7xii7pJD3xhA0jdL1rC;
			}

			internal static object J9qxilpJICimp2YLnHrg(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void nbYFDZpJ4attR686gFUY(object P_0)
			{
				((ReplacementManager)P_0).ConversionPlanReplacement();
			}

			internal static void ziMLXNpJV0W3fCawrkmC(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void fRjydxpJQbVvrTxCIXSv()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}
		}

		private class AbsenceJobImpl : IJob
		{
			internal static object XEFR23pJd7ikmstagt1m;

			private AbsenceManager Manager => (AbsenceManager)OiMuY8pJ889oEAJC9fTr();

			public Guid Id => new Guid((string)B8b7ZQpJrw30AhVIvSj8(0x5EE4A7B ^ 0x5EF0031));

			public string Name => (string)AZrZvdpJ3TqITbaKcJBY(B8b7ZQpJrw30AhVIvSj8(-1889123947 ^ -1889072381));

			public Image Icon => null;

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
						zsyfI5pJbnfZN1227t7y(jobResult, JobStatus.Success);
						L4DCtXpJSsMiRYUiL5T3(jobResult, AZrZvdpJ3TqITbaKcJBY(B8b7ZQpJrw30AhVIvSj8(0x40944BC4 ^ 0x4095010A)));
						return jobResult;
					}
					case 1:
						c2HxBYpJyukGhhAahC4W(Manager);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public AbsenceJobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				qtgbkPpJ94TqarL2HIFo();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object OiMuY8pJ889oEAJC9fTr()
			{
				return AbsenceManager.Instance;
			}

			internal static object B8b7ZQpJrw30AhVIvSj8(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool eYy6MlpJTovi7gxIgruQ()
			{
				return XEFR23pJd7ikmstagt1m == null;
			}

			internal static AbsenceJobImpl DGfkClpJgyUVq2SrXvEe()
			{
				return (AbsenceJobImpl)XEFR23pJd7ikmstagt1m;
			}

			internal static object AZrZvdpJ3TqITbaKcJBY(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void c2HxBYpJyukGhhAahC4W(object P_0)
			{
				((AbsenceManager)P_0).UpdateAbsencesCache();
			}

			internal static void zsyfI5pJbnfZN1227t7y(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void L4DCtXpJSsMiRYUiL5T3(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}

			internal static void qtgbkPpJ94TqarL2HIFo()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}
		}

		private readonly object _trigger;

		private ICollection<IJob> _jobs;

		internal static object ih6Vbdp7rvC4xbNnit4S;

		public override ITrigger Trigger => (ITrigger)_trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public ReplacementPeriodJob()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TxThhfp7bxHvnH2o0tkD();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
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
						new ReplacementJobImpl(),
						new AbsenceJobImpl()
					};
					num = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
					{
						num = 2;
					}
					continue;
				}
				NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
				{
					ScheduleType = ScheduleType.Daily,
					DailySettings = new DailySettings
					{
						EveryDay = 1,
						OnlyWorkDays = false
					},
					StartDate = HSebwZp7Sr3fgy1BBpWe().AddMinutes(10.0),
					OvertimeToRun = HmuColp79fJANofownSu(1.0)
				}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule());
				WjX7ZPp7zh52VVR9WDKe(nthIncludedDayTrigger, b7xNoPp71tfsb1kNsXAf(CWSefap7f7xy90Woovrg(-1586242415 ^ -1586301251)));
				nthIncludedDayTrigger.Id = new Guid((string)CWSefap7f7xy90Woovrg(-724676315 ^ -724599991));
				_trigger = nthIncludedDayTrigger;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num = 0;
				}
			}
		}

		internal static void TxThhfp7bxHvnH2o0tkD()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static DateTime HSebwZp7Sr3fgy1BBpWe()
		{
			return DateTime.Today;
		}

		internal static TimeSpan HmuColp79fJANofownSu(double P_0)
		{
			return TimeSpan.FromDays(P_0);
		}

		internal static object CWSefap7f7xy90Woovrg(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object b7xNoPp71tfsb1kNsXAf(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void WjX7ZPp7zh52VVR9WDKe(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static bool jdEu9up73Tw2WlVnjd05()
		{
			return ih6Vbdp7rvC4xbNnit4S == null;
		}

		internal static ReplacementPeriodJob uCVX4Rp7yhNGU6lthQHU()
		{
			return (ReplacementPeriodJob)ih6Vbdp7rvC4xbNnit4S;
		}
	}

	internal static ReplacementPeriodJobRepository FYT8NMltLfRUgwyEPgZ;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new ISchedulerJob[1]
		{
			new ReplacementPeriodJob()
		};
	}

	public ReplacementPeriodJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uLOAVhlq2m0tcQCcQVQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void uLOAVhlq2m0tcQCcQVQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool kIh2qSlhwD5IL1RLCWv()
	{
		return FYT8NMltLfRUgwyEPgZ == null;
	}

	internal static ReplacementPeriodJobRepository jbR0LOlOOCNxSUIudYq()
	{
		return FYT8NMltLfRUgwyEPgZ;
	}
}
