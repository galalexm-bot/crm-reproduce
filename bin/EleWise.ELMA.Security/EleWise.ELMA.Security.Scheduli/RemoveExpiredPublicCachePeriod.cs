using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class RemoveExpiredPublicCachePeriodJobRepository : ISchedulerJobRepository
{
	private class RemoveExpiredPublicCachePeriodJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			internal static object K2limfpJfEIuUfq30jTc;

			public Guid Id => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C65C9FC));

			public string Name => (string)MxOfJwpKpSBK1oOJYHHR(ECZ47EpKkM0LYnVlwgag(-737960346 ^ -738011858));

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				//Discarded unreachable code: IL_0087, IL_0096
				int num = 6;
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
						{
							JobResult jobResult = new JobResult();
							NpfkCOpK5M8FITb0cyIr(jobResult, JobStatus.Success);
							nlfZHlpKAsZcxamFGisR(jobResult, true);
							return jobResult;
						}
						case 5:
							_003C_003Ec__DisplayClass6_.expiredDayCount = SR.GetSetting((string)ECZ47EpKkM0LYnVlwgag(0x201ABE6B ^ 0x201BF5F9), 10);
							num2 = 3;
							continue;
						case 4:
							Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(_003C_003Ec__DisplayClass6_._003CDo_003Eb__0);
							num2 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
							{
								num2 = 1;
							}
							continue;
						default:
							_003C_003Ec__DisplayClass6_.expiredDayCount = 10;
							num = 2;
							break;
						case 2:
						case 7:
							_003C_003Ec__DisplayClass6_.cacheSvc = Locator.GetServiceNotNull<IPublicCacheService>();
							num2 = 8;
							continue;
						case 3:
							if (_003C_003Ec__DisplayClass6_.expiredDayCount >= 10)
							{
								num2 = 7;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
								{
									num2 = 4;
								}
								continue;
							}
							goto default;
						case 8:
							_003C_003Ec__DisplayClass6_.sessionSvc = Locator.GetServiceNotNull<IPublicClientService>();
							num2 = 4;
							continue;
						case 6:
							_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
							num = 5;
							break;
						}
						break;
					}
				}
			}

			public JobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				T35UyIpKWorRuIC1di4i();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool GWF9VPpJ1gfc9o15s1nF()
			{
				return K2limfpJfEIuUfq30jTc == null;
			}

			internal static JobImpl zcGEGopJzLIpxEjkkp04()
			{
				return (JobImpl)K2limfpJfEIuUfq30jTc;
			}

			internal static object ECZ47EpKkM0LYnVlwgag(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object MxOfJwpKpSBK1oOJYHHR(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void NpfkCOpK5M8FITb0cyIr(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void nlfZHlpKAsZcxamFGisR(object P_0, bool P_1)
			{
				((JobResult)P_0).NoSaveResult = P_1;
			}

			internal static void T35UyIpKWorRuIC1di4i()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}
		}

		private readonly object trigger;

		private readonly ICollection<IJob> jobs;

		internal static object RvjO1MplJSvRYlNc035o;

		public override ITrigger Trigger => (ITrigger)trigger;

		public override ICollection<IJob> Jobs => jobs;

		public RemoveExpiredPublicCachePeriodJob()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			WSMAe9plh9uTcCXifaTb();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				default:
					jobs = new List<IJob>
					{
						new JobImpl()
					};
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num = 2;
					}
					break;
				case 1:
				{
					NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
					{
						ScheduleType = ScheduleType.Daily,
						DailySettings = new DailySettings
						{
							EveryDay = 1,
							OnlyWorkDays = false
						},
						StartDate = fxQ7pVplO1dV7EA5CbEd().AddMinutes(10.0),
						OvertimeToRun = S7QyjJplqbXPBvTrCKyA(3.0)
					}, (IProductionSchedule)w0aTVjplclkupHp1H6HF(Locator.GetServiceNotNull<IProductionCalendarService>()));
					bDCFiMpl0DCKdGC732tg(nthIncludedDayTrigger, nxdVivplFDKRFcnSNPpA(a8GrjiplG7jYXfYQKqTH(-1718905545 ^ -1718961835)));
					cOcN9oplEiIVgJ3L9IrN(nthIncludedDayTrigger, new Guid((string)a8GrjiplG7jYXfYQKqTH(-230994601 ^ -231054869)));
					trigger = nthIncludedDayTrigger;
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num = 0;
					}
					break;
				}
				}
			}
		}

		internal static void WSMAe9plh9uTcCXifaTb()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static DateTime fxQ7pVplO1dV7EA5CbEd()
		{
			return DateTime.Today;
		}

		internal static TimeSpan S7QyjJplqbXPBvTrCKyA(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static object w0aTVjplclkupHp1H6HF(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object a8GrjiplG7jYXfYQKqTH(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object nxdVivplFDKRFcnSNPpA(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void bDCFiMpl0DCKdGC732tg(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static void cOcN9oplEiIVgJ3L9IrN(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static bool h9XydFplK4c0FfKJSJE6()
		{
			return RvjO1MplJSvRYlNc035o == null;
		}

		internal static RemoveExpiredPublicCachePeriodJob Pb87Whplt3SqwvhANH2s()
		{
			return (RemoveExpiredPublicCachePeriodJob)RvjO1MplJSvRYlNc035o;
		}
	}

	internal static RemoveExpiredPublicCachePeriodJobRepository JyBEmrHuACRM1UoEwLx;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new RemoveExpiredPublicCachePeriodJob()
		};
	}

	public RemoveExpiredPublicCachePeriodJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IMhfIKHmfopkoxbUUjP()
	{
		return JyBEmrHuACRM1UoEwLx == null;
	}

	internal static RemoveExpiredPublicCachePeriodJobRepository K9P5HcHe40kjm7vw1tH()
	{
		return JyBEmrHuACRM1UoEwLx;
	}
}
