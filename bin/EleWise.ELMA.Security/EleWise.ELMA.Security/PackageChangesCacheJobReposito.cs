using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Properties;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Type = ComponentType.WebServer)]
public class PackageChangesCacheJobRepository : ISchedulerJobRepository
{
	private class PackageChangesCacheJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private object securityService;

			private object packageChangesManager;

			internal static object fkn9gapJRtOE4sOQ6fGu;

			private ISecurityService SecurityService
			{
				get
				{
					int num = 2;
					int num2 = num;
					ISecurityService securityService = default(ISecurityService);
					object obj;
					while (true)
					{
						switch (num2)
						{
						case 1:
							securityService = (ISecurityService)(this.securityService = Locator.GetServiceNotNull<ISecurityService>());
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							obj = this.securityService;
							if (obj != null)
							{
								break;
							}
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
							{
								num2 = 1;
							}
							continue;
						default:
							obj = securityService;
							break;
						}
						break;
					}
					return (ISecurityService)obj;
				}
			}

			private PackageChangesManager PackageChangesManager
			{
				get
				{
					int num = 1;
					int num2 = num;
					PackageChangesManager packageChangesManager = default(PackageChangesManager);
					object obj;
					while (true)
					{
						switch (num2)
						{
						default:
							packageChangesManager = (PackageChangesManager)(this.packageChangesManager = Locator.GetServiceNotNull<PackageChangesManager>());
							num2 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
							{
								num2 = 2;
							}
							continue;
						case 1:
							obj = this.packageChangesManager;
							if (obj != null)
							{
								break;
							}
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							obj = packageChangesManager;
							break;
						}
						break;
					}
					return (PackageChangesManager)obj;
				}
			}

			public Guid Id => new Guid((string)ktj9vLpJPfxA3oypUaAx(0x8875F5C ^ 0x886198A));

			public string Name => (string)aes6t0pJvq1HKL7AhrHG(ktj9vLpJPfxA3oypUaAx(0x335D4787 ^ 0x335C00A5));

			public Image Icon => Resources.ELMA;

			public JobResult Do(DateTime dateToRun)
			{
				int num = 5;
				int num2 = num;
				_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
				while (true)
				{
					switch (num2)
					{
					case 5:
						_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
						num2 = 4;
						break;
					case 3:
						return _003C_003Ec__DisplayClass12_.jobResult;
					case 4:
						_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
						num2 = 2;
						break;
					default:
						CGyZ0YpJCWuE4URCosy1(SecurityService, new Action(_003C_003Ec__DisplayClass12_._003CDo_003Eb__0));
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						_003C_003Ec__DisplayClass12_.jobResult = null;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass12_.dateToRun = dateToRun;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			private JobResult DoJob(DateTime dateToRun)
			{
				//Discarded unreachable code: IL_004e, IL_0058, IL_0137, IL_014a
				int num = 2;
				int num2 = num;
				List<EleWise.ELMA.Security.Models.IUser>.Enumerator enumerator = default(List<EleWise.ELMA.Security.Models.IUser>.Enumerator);
				EleWise.ELMA.Security.Models.IUser current = default(EleWise.ELMA.Security.Models.IUser);
				JobResult jobResult = default(JobResult);
				int valueFromSettings = default(int);
				List<EleWise.ELMA.Security.Models.IUser> list = default(List<EleWise.ELMA.Security.Models.IUser>);
				int valueFromSettings2 = default(int);
				while (true)
				{
					switch (num2)
					{
					case 3:
						try
						{
							while (true)
							{
								IL_00e5:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
									{
										num3 = 4;
									}
									goto IL_005c;
								}
								goto IL_007a;
								IL_007a:
								current = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
								{
									num3 = 1;
								}
								goto IL_005c;
								IL_005c:
								while (true)
								{
									switch (num3)
									{
									case 3:
										break;
									case 1:
										if (current != null)
										{
											num3 = 2;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
											{
												num3 = 1;
											}
											continue;
										}
										goto IL_00e5;
									case 2:
										FZbXP2pJKkRC2h7RtfQX(PackageChangesManager, current);
										num3 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
										{
											num3 = 0;
										}
										continue;
									default:
										goto IL_00e5;
									case 4:
										goto end_IL_00e5;
									}
									break;
								}
								goto IL_007a;
								continue;
								end_IL_00e5:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto case 10;
					case 8:
						jobResult.Status = JobStatus.Success;
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
						{
							num2 = 9;
						}
						break;
					case 10:
						jobResult = new JobResult();
						num2 = 7;
						break;
					case 2:
						valueFromSettings = GetValueFromSettings(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B1D6430 ^ 0x3B1C234A), 10);
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
					{
						JobResult obj = new JobResult
						{
							Information = (string)aes6t0pJvq1HKL7AhrHG(ktj9vLpJPfxA3oypUaAx(-1429357207 ^ -1429408413))
						};
						AYoh9UpJJ6CxaywhQ6IW(obj, JobStatus.Success);
						return obj;
					}
					case 5:
						if (CHMqNEpJoYd0ylEERkJD(list) != 0)
						{
							enumerator = list.GetEnumerator();
							num2 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
							{
								num2 = 3;
							}
						}
						else
						{
							num2 = 4;
						}
						break;
					case 9:
						return jobResult;
					case 1:
						valueFromSettings2 = GetValueFromSettings((string)ktj9vLpJPfxA3oypUaAx(0x4E6718AE ^ 0x4E665F16), 1);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
						{
							num2 = 0;
						}
						break;
					case 6:
						list = PackageChangesManager.GetTopUsersForPrepare(valueFromSettings2).ToList();
						num2 = 5;
						break;
					default:
						g0GnkPpJU1pabfVpITeE(PackageChangesManager, valueFromSettings);
						num2 = 6;
						break;
					case 7:
						AJAqQhpJOSq3odI7dnqA(jobResult, (CHMqNEpJoYd0ylEERkJD(list) == 1) ? qvQnMbpJhRCSriVEsXPX(ktj9vLpJPfxA3oypUaAx(0xCDF201B ^ 0xCDE68E5), new object[1] { VJn2bxpJtwpCbu1dOZvG(list.First()) }) : SR.T((string)ktj9vLpJPfxA3oypUaAx(-179348817 ^ -179432757), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD42BEC), list)));
						num2 = 8;
						break;
					}
				}
			}

			private int GetValueFromSettings(string key, int defaultValue)
			{
				//Discarded unreachable code: IL_0041
				int num = 6;
				int num2 = num;
				int result = default(int);
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 6:
						result = -1;
						num2 = 5;
						break;
					case 7:
						result = defaultValue;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
						{
							num2 = 2;
						}
						break;
					case 5:
						text = (string)yFOPYNpJqK16eFCLtcgu(key, null);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						if (!Nf9ci4pJcqHsKKoRkCtf(text))
						{
							num2 = 4;
							break;
						}
						goto case 1;
					case 1:
						if (result >= 0)
						{
							num2 = 3;
							break;
						}
						goto case 7;
					case 4:
						int.TryParse(text, out result);
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
					case 3:
						return result;
					}
				}
			}

			public JobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool PmyaP4pJwMAotRK8aq93()
			{
				return fkn9gapJRtOE4sOQ6fGu == null;
			}

			internal static JobImpl bcxsU8pJ2PAsCUZZamh1()
			{
				return (JobImpl)fkn9gapJRtOE4sOQ6fGu;
			}

			internal static object ktj9vLpJPfxA3oypUaAx(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object aes6t0pJvq1HKL7AhrHG(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static void CGyZ0YpJCWuE4URCosy1(object P_0, object P_1)
			{
				((ISecurityService)P_0).RunBySystemUser((Action)P_1);
			}

			internal static void g0GnkPpJU1pabfVpITeE(object P_0, int count)
			{
				((PackageChangesManager)P_0).CreatePackageChangesForUser(count);
			}

			internal static int CHMqNEpJoYd0ylEERkJD(object P_0)
			{
				return ((List<EleWise.ELMA.Security.Models.IUser>)P_0).Count;
			}

			internal static void AYoh9UpJJ6CxaywhQ6IW(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void FZbXP2pJKkRC2h7RtfQX(object P_0, object P_1)
			{
				((PackageChangesManager)P_0).CreateCacheForUser((EleWise.ELMA.Security.Models.IUser)P_1);
			}

			internal static object VJn2bxpJtwpCbu1dOZvG(object P_0)
			{
				return ((EleWise.ELMA.Security.Models.IUser)P_0).UserName;
			}

			internal static object qvQnMbpJhRCSriVEsXPX(object P_0, object P_1)
			{
				return SR.T((string)P_0, (object[])P_1);
			}

			internal static void AJAqQhpJOSq3odI7dnqA(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}

			internal static object yFOPYNpJqK16eFCLtcgu(object P_0, object P_1)
			{
				return SR.GetSetting((string)P_0, (string)P_1);
			}

			internal static bool Nf9ci4pJcqHsKKoRkCtf(object P_0)
			{
				return string.IsNullOrEmpty((string)P_0);
			}
		}

		private readonly object trigger;

		private readonly ICollection<IJob> jobs;

		private static object kp0uj2pWMcQVPpk50rl3;

		public override ITrigger Trigger => (ITrigger)trigger;

		public override ICollection<IJob> Jobs => jobs;

		public PackageChangesCacheJob()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			N1A7kKpWIvHXm6toEMgY();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
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
					trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
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
							RepeatEvery = jUd1wkpW4VcZVNsjqubh(10.0),
							RepeatTo = OSH8UQpWVOAAyKjk3aos(24.0)
						},
						StartDate = DateTime.Today
					}, (IProductionSchedule)QJc0rXpWQ1qX8V2D42Ft(Locator.GetServiceNotNull<IProductionCalendarService>()))
					{
						Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37FE8EDE ^ 0x37FFAA5C)),
						Id = new Guid((string)blghrvpWd0XZOclaiQg3(-1586242415 ^ -1586300827))
					};
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num = 0;
					}
					break;
				default:
					jobs = new List<IJob>
					{
						new JobImpl()
					};
					num = 2;
					break;
				}
			}
		}

		internal static void N1A7kKpWIvHXm6toEMgY()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static TimeSpan jUd1wkpW4VcZVNsjqubh(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static TimeSpan OSH8UQpWVOAAyKjk3aos(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static object QJc0rXpWQ1qX8V2D42Ft(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object blghrvpWd0XZOclaiQg3(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool z2s5OHpWsKu5bsiiVb1Z()
		{
			return kp0uj2pWMcQVPpk50rl3 == null;
		}

		internal static PackageChangesCacheJob yADMaOpWY95u8i9VwW9c()
		{
			return (PackageChangesCacheJob)kp0uj2pWMcQVPpk50rl3;
		}
	}

	private static PackageChangesCacheJobRepository Q8ODl15oT4cr8Yn2Jmo;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new PackageChangesCacheJob()
		};
	}

	public PackageChangesCacheJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zbS7hI5JCTJLfg7Rl6o()
	{
		return Q8ODl15oT4cr8Yn2Jmo == null;
	}

	internal static PackageChangesCacheJobRepository koIT9D5KKmnZ4qU17Yw()
	{
		return Q8ODl15oT4cr8Yn2Jmo;
	}
}
