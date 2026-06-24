using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
internal class UserSecurityProfileSchedulerJobRepository : ISchedulerJobRepository
{
	private class ForcedChangePasswordJob : SchedulerJobBase
	{
		private class Job : IJob
		{
			private readonly object userSecurityProfileManager;

			private readonly object settings;

			private readonly object userGroupManager;

			internal static object iXoWQypKEA4BTHKLDvpX;

			public Guid Id { get; }

			public string Name { get; }

			public Image Icon => null;

			public Job(UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings, UserGroupManager userGroupManager)
			{
				//Discarded unreachable code: IL_0076, IL_007b
				OwAHrFpKsRRdQxuVTSWE();
				Id = new Guid((string)Cyui3apKYfDeiZGeBaly(-95913524 ^ -95865410));
				Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076828428));
				base._002Ector();
				int num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num = 2;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 3:
						this.userSecurityProfileManager = userSecurityProfileManager;
						num = 2;
						break;
					case 1:
						this.userGroupManager = userGroupManager;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
						{
							num = 0;
						}
						break;
					case 2:
						this.settings = settings;
						num = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
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
					default:
					{
						JobResult jobResult = new JobResult();
						kvGicxpKIep9OdROYoFq(jobResult, JobStatus.Success);
						HZZS9jpK4hiexKkWCVyc(jobResult, true);
						w3mQJDpKQLHD8ZLL9XGb(jobResult, u164GppKVlUfRji2FN8L(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738F7CCD)));
						return jobResult;
					}
					case 1:
						((UserSecurityProfileManager)userSecurityProfileManager).SetForcedChangePasswordWithCheck(GetExcludedUsersId(), TimeSpan.FromDays(((SecuritySettings)settings).PeriodicityOfForcedChangePassword));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			private ICollection<long> GetExcludedUsersId()
			{
				long exclusionGroupId = ((SecuritySettings)settings).ExclusionGroupId;
				if (exclusionGroupId == 0L)
				{
					return null;
				}
				return ((UserGroupManager)userGroupManager).GetUsersByGroup(exclusionGroupId).CastToListOrNull<long>();
			}

			internal static void OwAHrFpKsRRdQxuVTSWE()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}

			internal static object Cyui3apKYfDeiZGeBaly(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool M9gF2qpKDgMFIcF51D1a()
			{
				return iXoWQypKEA4BTHKLDvpX == null;
			}

			internal static Job TqNTgXpKMvRLZJb9pIQY()
			{
				return (Job)iXoWQypKEA4BTHKLDvpX;
			}

			internal static void kvGicxpKIep9OdROYoFq(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void HZZS9jpK4hiexKkWCVyc(object P_0, bool P_1)
			{
				((JobResult)P_0).NoSaveResult = P_1;
			}

			internal static object u164GppKVlUfRji2FN8L(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void w3mQJDpKQLHD8ZLL9XGb(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}
		}

		internal static object CCZgZApUfTX9Z7uegOTk;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public ForcedChangePasswordJob(IProductionCalendarService productionCalendarService, UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings, UserGroupManager userGroupManager)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			v0cn1opokrOX8qYiNP5T();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
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
							RepeatEvery = TimeSpan.FromHours(12.0),
							RepeatTo = IMYPuTpop41YyknnVAP1(6.0)
						},
						StartDate = lConWxpo5uKA3VJhxOcV().AddHours(2.0)
					}, productionCalendarService.GetGlobalProductionSchedule())
					{
						Id = new Guid((string)pRLvskpoALBWsQ4nEEQH(0x2E78F5A0 ^ 0x2E79B6E2)),
						Name = SR.T((string)pRLvskpoALBWsQ4nEEQH(-236222459 ^ -236270709))
					};
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
					{
						num = 0;
					}
					break;
				default:
				{
					IJob[] array2;
					if (iOp2wjpoWlw6xYh5mWek(settings) > 0)
					{
						IJob[] array = new Job[1]
						{
							new Job(userSecurityProfileManager, settings, userGroupManager)
						};
						array2 = array;
					}
					else
					{
						array2 = Array.Empty<IJob>();
					}
					Jobs = array2;
					num = 2;
					break;
				}
				}
			}
		}

		internal static void v0cn1opokrOX8qYiNP5T()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static TimeSpan IMYPuTpop41YyknnVAP1(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static DateTime lConWxpo5uKA3VJhxOcV()
		{
			return DateTime.Today;
		}

		internal static object pRLvskpoALBWsQ4nEEQH(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static int iOp2wjpoWlw6xYh5mWek(object P_0)
		{
			return ((SecuritySettings)P_0).PeriodicityOfForcedChangePassword;
		}

		internal static bool MhgihopU1o2vdl3rb02t()
		{
			return CCZgZApUfTX9Z7uegOTk == null;
		}

		internal static ForcedChangePasswordJob sMxOenpUzWsjUYXwWQBX()
		{
			return (ForcedChangePasswordJob)CCZgZApUfTX9Z7uegOTk;
		}
	}

	private class ResetCountFailedLogonJob : SchedulerJobBase
	{
		private class Job : IJob
		{
			private readonly object userSecurityProfileManager;

			private readonly object settings;

			private static object Y3w2JZpKdX7E57jQRWQy;

			public Guid Id { get; }

			public string Name { get; }

			public Image Icon => null;

			public Job(UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings)
			{
				//Discarded unreachable code: IL_0060, IL_0065
				MGYgDSpK87j1ZU2orR9u();
				Id = new Guid((string)TNY4MjpKrETKFXOxI7k7(-698589567 ^ -698543217));
				Name = (string)kQnHyopK3MhqAw5iMEP9(TNY4MjpKrETKFXOxI7k7(-764392425 ^ -764346035));
				base._002Ector();
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.settings = settings;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
						{
							num = 0;
						}
						break;
					case 2:
						this.userSecurityProfileManager = userSecurityProfileManager;
						num = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
						{
							num = 1;
						}
						break;
					case 0:
						return;
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
					default:
					{
						JobResult jobResult = new JobResult();
						slvdQOpKSI31VWRdeFx3(jobResult, JobStatus.Success);
						jobResult.NoSaveResult = true;
						jobResult.Information = (string)kQnHyopK3MhqAw5iMEP9(TNY4MjpKrETKFXOxI7k7(0x738E3073 ^ 0x738F7DCD));
						return jobResult;
					}
					case 1:
						((UserSecurityProfileManager)userSecurityProfileManager).ResetCountFailedLogonAllWithCheck(wrbARBpKbF7uOk2w9k77(q9pkLbpKyCf5qlJp5Xtb(settings)));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static void MGYgDSpK87j1ZU2orR9u()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}

			internal static object TNY4MjpKrETKFXOxI7k7(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object kQnHyopK3MhqAw5iMEP9(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static bool U0pi1ypKTRUPtLUIqPF0()
			{
				return Y3w2JZpKdX7E57jQRWQy == null;
			}

			internal static Job KoNORIpKgv9vxBGEiC9C()
			{
				return (Job)Y3w2JZpKdX7E57jQRWQy;
			}

			internal static int q9pkLbpKyCf5qlJp5Xtb(object P_0)
			{
				return ((SecuritySettings)P_0).PeriodResetCountLogonAttempts;
			}

			internal static TimeSpan wrbARBpKbF7uOk2w9k77(double P_0)
			{
				return TimeSpan.FromMinutes(P_0);
			}

			internal static void slvdQOpKSI31VWRdeFx3(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}
		}

		internal static object o4wZcTpoXOIHixtZixDY;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public ResetCountFailedLogonJob(IProductionCalendarService productionCalendarService, UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			RAAe4spo7qmYYNLZIkuK();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
			{
				num = 1;
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
				{
					NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
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
							RepeatEvery = GetTimeSpan(X57uhFpo6kPddI0pV0bU(settings)),
							RepeatTo = ERpIoUpolk9f350KBI1V(24.0)
						},
						StartDate = DateTime.Today
					}, (IProductionSchedule)MOGS98poNfGQu4KV6J1g(productionCalendarService));
					MEkUJLpoxJOXU4uCdNQw(nthIncludedDayTrigger, new Guid((string)Mdv5YxpoZqE6hSaWxUSh(0x2CFDCC80 ^ 0x2CFC88BA)));
					vtIB0VpouMDMHRIL5aRd(nthIncludedDayTrigger, w1iFy2poB75cNp5VgvPb(Mdv5YxpoZqE6hSaWxUSh(-1378061210 ^ -1378012960)));
					Trigger = nthIncludedDayTrigger;
					num = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num = 0;
					}
					break;
				}
				case 2:
				{
					IJob[] array2;
					if (X57uhFpo6kPddI0pV0bU(settings) > 0)
					{
						IJob[] array = new Job[1]
						{
							new Job(userSecurityProfileManager, settings)
						};
						array2 = array;
					}
					else
					{
						array2 = Array.Empty<IJob>();
					}
					Jobs = array2;
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
					{
						num = 0;
					}
					break;
				}
				}
			}
		}

		internal static void RAAe4spo7qmYYNLZIkuK()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static int X57uhFpo6kPddI0pV0bU(object P_0)
		{
			return ((SecuritySettings)P_0).PeriodResetCountLogonAttempts;
		}

		internal static TimeSpan ERpIoUpolk9f350KBI1V(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static object MOGS98poNfGQu4KV6J1g(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object Mdv5YxpoZqE6hSaWxUSh(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void MEkUJLpoxJOXU4uCdNQw(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static object w1iFy2poB75cNp5VgvPb(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void vtIB0VpouMDMHRIL5aRd(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static bool SGNGsupon8NnD9seXNgH()
		{
			return o4wZcTpoXOIHixtZixDY == null;
		}

		internal static ResetCountFailedLogonJob MZWcXtpoivdBmiVF7JEK()
		{
			return (ResetCountFailedLogonJob)o4wZcTpoXOIHixtZixDY;
		}
	}

	private class UnblockLogonUsersJob : SchedulerJobBase
	{
		private class Job : IJob
		{
			private readonly object userSecurityProfileManager;

			private readonly object settings;

			private static object JxgXOKpK9UfU2o8jJNNh;

			public Guid Id { get; }

			public string Name { get; }

			public Image Icon => null;

			public Job(UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings)
			{
				//Discarded unreachable code: IL_006a, IL_006f
				Dj2UOSpKzVLh8pmcShic();
				Id = new Guid((string)rhbT86ptk4d4aKNixCnO(-2037738356 ^ -2037654854));
				Name = (string)r0nx5pptpZySj2tYFt9l(rhbT86ptk4d4aKNixCnO(-2037738356 ^ -2037655026));
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						this.settings = settings;
						num = 2;
						break;
					case 2:
						return;
					case 1:
						this.userSecurityProfileManager = userSecurityProfileManager;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
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
						xhN0TCptA4QFdsvC9NyC(userSecurityProfileManager, o1JKrPpt5fA4m9EIHVbb(((SecuritySettings)settings).BlockingPeriod));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
						{
							num2 = 0;
						}
						break;
					default:
					{
						JobResult jobResult = new JobResult();
						smX3haptWc0wjrieRJ8h(jobResult, JobStatus.Success);
						RyhMxiptXLN6HQqQnxgi(jobResult, true);
						jobResult.Information = (string)r0nx5pptpZySj2tYFt9l(rhbT86ptk4d4aKNixCnO(0x2121ECF9 ^ 0x2120A3C5));
						return jobResult;
					}
					}
				}
			}

			internal static void Dj2UOSpKzVLh8pmcShic()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			}

			internal static object rhbT86ptk4d4aKNixCnO(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object r0nx5pptpZySj2tYFt9l(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static bool SUJ1DUpKfpg2GrBeqInt()
			{
				return JxgXOKpK9UfU2o8jJNNh == null;
			}

			internal static Job SNLncdpK1qJZhrEYfGP9()
			{
				return (Job)JxgXOKpK9UfU2o8jJNNh;
			}

			internal static TimeSpan o1JKrPpt5fA4m9EIHVbb(double P_0)
			{
				return TimeSpan.FromMinutes(P_0);
			}

			internal static void xhN0TCptA4QFdsvC9NyC(object P_0, TimeSpan period)
			{
				((UserSecurityProfileManager)P_0).AllowLogonAllWithCheck(period);
			}

			internal static void smX3haptWc0wjrieRJ8h(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void RyhMxiptXLN6HQqQnxgi(object P_0, bool P_1)
			{
				((JobResult)P_0).NoSaveResult = P_1;
			}
		}

		private static object ymcplxpomLsTsrx5ZyDS;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public UnblockLogonUsersJob(IProductionCalendarService productionCalendarService, UserSecurityProfileManager userSecurityProfileManager, SecuritySettings settings)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			jG0bK7poj6OK8p5wXUdr();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
				{
					IJob[] array2;
					if (hliKLJpovjZWTADPogVG(settings) > 0)
					{
						IJob[] array = new Job[1]
						{
							new Job(userSecurityProfileManager, settings)
						};
						array2 = array;
					}
					else
					{
						array2 = Array.Empty<IJob>();
					}
					Jobs = array2;
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
					{
						num = 1;
					}
					continue;
				}
				}
				NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
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
						RepeatEvery = zYuTuYpoHq5YVVcsyt3D(settings.BlockingPeriod),
						RepeatTo = oHqlOFpoaV4BfF72WvTl(24.0)
					},
					StartDate = zHBnEKpoRTZ1kjRCmIeS()
				}, (IProductionSchedule)h6j1mXpow3ZImw9OjkVf(productionCalendarService));
				I9UJGcpoPEKLlMCqYAX6(nthIncludedDayTrigger, new Guid((string)JLjWAfpo2NQSlmSejdLr(0x190F47B7 ^ 0x190E02E9)));
				nthIncludedDayTrigger.Name = SR.T((string)JLjWAfpo2NQSlmSejdLr(-2068904634 ^ -2068954900));
				Trigger = nthIncludedDayTrigger;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num = 0;
				}
			}
		}

		internal static void jG0bK7poj6OK8p5wXUdr()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static TimeSpan zYuTuYpoHq5YVVcsyt3D(int period)
		{
			return GetTimeSpan(period);
		}

		internal static TimeSpan oHqlOFpoaV4BfF72WvTl(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static DateTime zHBnEKpoRTZ1kjRCmIeS()
		{
			return DateTime.Today;
		}

		internal static object h6j1mXpow3ZImw9OjkVf(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object JLjWAfpo2NQSlmSejdLr(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void I9UJGcpoPEKLlMCqYAX6(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static int hliKLJpovjZWTADPogVG(object P_0)
		{
			return ((SecuritySettings)P_0).BlockingPeriod;
		}

		internal static bool TTJVr1poefQOBCZYhuPF()
		{
			return ymcplxpomLsTsrx5ZyDS == null;
		}

		internal static UnblockLogonUsersJob KMPYFEpoLWD0SZw7KbGQ()
		{
			return (UnblockLogonUsersJob)ymcplxpomLsTsrx5ZyDS;
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly UserSecurityProfileManager userSecurityProfileManager;

	private readonly UserGroupManager userGroupManager;

	private readonly ILazy<SecuritySettingsModule> securitySettingsModule;

	internal static UserSecurityProfileSchedulerJobRepository AYByf71d60vKY198fbd;

	public UserSecurityProfileSchedulerJobRepository(IProductionCalendarService productionCalendarService, UserSecurityProfileManager userSecurityProfileManager, UserGroupManager userGroupManager, ILazy<SecuritySettingsModule> securitySettingsModule)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.productionCalendarService = productionCalendarService;
		this.userSecurityProfileManager = userSecurityProfileManager;
		this.userGroupManager = userGroupManager;
		this.securitySettingsModule = securitySettingsModule;
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		if (securitySettingsModule.IsRegistered)
		{
			return new ISchedulerJob[3]
			{
				new ForcedChangePasswordJob(productionCalendarService, userSecurityProfileManager, securitySettingsModule.Value.Settings, userGroupManager),
				new ResetCountFailedLogonJob(productionCalendarService, userSecurityProfileManager, securitySettingsModule.Value.Settings),
				new UnblockLogonUsersJob(productionCalendarService, userSecurityProfileManager, securitySettingsModule.Value.Settings)
			};
		}
		return Array.Empty<ISchedulerJob>();
	}

	private static TimeSpan GetTimeSpan(int period)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return MKcwRl18wZVpX2Inkdu(1.0);
			case 2:
				if (period > 15)
				{
					if (period <= 90)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (period > 1440)
					{
						return dTuJit1rJCumRwQSIgF(4.0);
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return dTuJit1rJCumRwQSIgF(1.0);
			case 3:
				return MKcwRl18wZVpX2Inkdu(10.0);
			}
		}
	}

	internal static TimeSpan MKcwRl18wZVpX2Inkdu(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static TimeSpan dTuJit1rJCumRwQSIgF(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static bool mAvlR51T6F25Py5swPZ()
	{
		return AYByf71d60vKY198fbd == null;
	}

	internal static UserSecurityProfileSchedulerJobRepository Gb78bq1g1UDtxTGnCs2()
	{
		return AYByf71d60vKY198fbd;
	}
}
