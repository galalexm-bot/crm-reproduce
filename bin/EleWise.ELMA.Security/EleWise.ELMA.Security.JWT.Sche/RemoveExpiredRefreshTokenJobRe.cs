using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.JWT.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Scheduling;

[Component(Type = ComponentType.WebServer)]
internal sealed class RemoveExpiredRefreshTokenJobRepository : ISchedulerJobRepository
{
	private class RemoveExpiredRefreshTokenJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private readonly object refreshTokenService;

			private static object QDodIZpKK8PwTml7jXKD;

			public Guid Id => new Guid((string)VIg90kpKOxYHYyBwUxZv(0xAEB118D ^ 0xAEA5A31));

			public string Name => (string)sH9tbvpKqwK4CRcdRc0m(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1586242415 ^ -1586327399));

			public Image Icon => null;

			public JobImpl(IRefreshTokenService refreshTokenService)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						this.refreshTokenService = refreshTokenService;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public JobResult Do(DateTime dateToRun)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						((IRefreshTokenService)refreshTokenService).RemoveExpired();
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
						{
							num2 = 0;
						}
						break;
					default:
					{
						JobResult jobResult = new JobResult();
						aPS3aJpKcqWe9y8HHLsn(jobResult, JobStatus.Success);
						jobResult.NoSaveResult = true;
						return jobResult;
					}
					}
				}
			}

			internal static bool pwEXJHpKtDKKfUCZ292V()
			{
				return QDodIZpKK8PwTml7jXKD == null;
			}

			internal static JobImpl qa4tJlpKhZt72cwRFfg8()
			{
				return (JobImpl)QDodIZpKK8PwTml7jXKD;
			}

			internal static object VIg90kpKOxYHYyBwUxZv(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object sH9tbvpKqwK4CRcdRc0m(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void aPS3aJpKcqWe9y8HHLsn(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}
		}

		private readonly object trigger;

		private readonly ICollection<IJob> jobs;

		private static object hEhk2dpCAKJTUykYkJkg;

		public override ITrigger Trigger => (ITrigger)trigger;

		public override ICollection<IJob> Jobs => jobs;

		public RemoveExpiredRefreshTokenJob(IProductionCalendarService productionCalendar, IRefreshTokenService refreshTokenService)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			Xt96pdpCnT1Eu7HShmV8();
			base._002Ector();
			int num = 2;
			NthIncludedDayTrigger nthIncludedDayTrigger = default(NthIncludedDayTrigger);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					jobs = new List<IJob>
					{
						new JobImpl(refreshTokenService)
					};
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
					{
						ScheduleType = ScheduleType.Daily,
						DailySettings = new DailySettings
						{
							EveryDay = 1,
							OnlyWorkDays = false
						},
						StartDate = DateTime.Today.AddMinutes(10.0),
						OvertimeToRun = u3r1mPpCiYlOH6eVLPEW(3.0)
					}, (IProductionSchedule)V38u1epC7H9RODEeNAjK(productionCalendar));
					num = 3;
					break;
				case 3:
					mmu5KupCNVkhSuyJI903(nthIncludedDayTrigger, HUp5aUpClwdbWY5SJs66(YMC7HhpC6T7YlbIYFcJa(0x3E79A885 ^ 0x3E78861B)));
					num = 5;
					break;
				case 5:
					jd0bJ9pCZuO3ZGvVDZml(nthIncludedDayTrigger, new Guid((string)YMC7HhpC6T7YlbIYFcJa(0x1A9A1A63 ^ 0x1A9B357B)));
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					trigger = nthIncludedDayTrigger;
					num = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num = 4;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void Xt96pdpCnT1Eu7HShmV8()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static TimeSpan u3r1mPpCiYlOH6eVLPEW(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static object V38u1epC7H9RODEeNAjK(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object YMC7HhpC6T7YlbIYFcJa(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object HUp5aUpClwdbWY5SJs66(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void mmu5KupCNVkhSuyJI903(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static void jd0bJ9pCZuO3ZGvVDZml(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static bool fewZtMpCWwhBxPLroVO8()
		{
			return hEhk2dpCAKJTUykYkJkg == null;
		}

		internal static RemoveExpiredRefreshTokenJob wZTN83pCXuvm9pdUP4U5()
		{
			return (RemoveExpiredRefreshTokenJob)hEhk2dpCAKJTUykYkJkg;
		}
	}

	private readonly IProductionCalendarService productionCalendar;

	private readonly IRefreshTokenService refreshTokenService;

	internal static RemoveExpiredRefreshTokenJobRepository q41I5Gg4TjP322kfLQ1;

	public RemoveExpiredRefreshTokenJobRepository(IProductionCalendarService productionCalendar, IRefreshTokenService refreshTokenService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.productionCalendar = productionCalendar;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.refreshTokenService = refreshTokenService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new RemoveExpiredRefreshTokenJob(productionCalendar, refreshTokenService)
		};
	}

	internal static bool o5fED4gVxLnYQI7x1O3()
	{
		return q41I5Gg4TjP322kfLQ1 == null;
	}

	internal static RemoveExpiredRefreshTokenJobRepository uhTbX1gQNfOYVcs4OZo()
	{
		return q41I5Gg4TjP322kfLQ1;
	}
}
