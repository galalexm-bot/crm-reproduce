using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports;

[Service(Type = ComponentType.WebServer, Scope = ServiceScope.Shell)]
internal class DiagnosticsReportExporter
{
	private DateTime? _lastRunTime;

	private string _lastRunFileName;

	internal static DiagnosticsReportExporter EqYNCDEh6dhctPWLhIos;

	public DiagnosticsReportExporter()
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0085, IL_00cb, IL_00f6, IL_0147
		t4Fa1LEh7SpRPwQWmVoT();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				if (!rATjqeEh0TSRA8j3vvj4(_lastRunFileName))
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 0;
				}
				continue;
			case 1:
				_lastRunFileName = Path.Combine(((ComponentManager)iNWJZdEhxeafaolo2d3F()).WorkDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477406074));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 2;
				}
				continue;
			}
			try
			{
				int num2;
				if (!DateTime.TryParse((string)zbRZxAEhmf95WRC3QJYm(_lastRunFileName), (IFormatProvider)sH3l5KEhyVUPsYyXNRli(), DateTimeStyles.None, out var result))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					goto IL_0089;
				}
				goto IL_009f;
				IL_009f:
				_lastRunTime = result;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				goto IL_0089;
				IL_0089:
				switch (num2)
				{
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				case 1:
					return;
				}
				goto IL_009f;
			}
			catch (Exception ex)
			{
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						PDMwwLEh9CHuPwcq2IXe(h8rSK4EhMaI22MJvWAkZ(), Thk43iEhJEuuS55GqhkA(0x35C0467B ^ 0x35C477E3), ex);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}
	}

	public void Execute()
	{
		//Discarded unreachable code: IL_00e1, IL_0128, IL_015b, IL_01ac, IL_01bb, IL_0205, IL_0238, IL_028a, IL_0299
		int num = 9;
		int num2 = num;
		DateTime? nextTimeAfterUnfolded = default(DateTime?);
		DiagnosticsSettings settings = default(DiagnosticsSettings);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				_lastRunTime = nextTimeAfterUnfolded.Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				if (!kvIJsbEhlj67mBFiGlHb(settings))
				{
					num2 = 4;
					break;
				}
				goto case 10;
			case 5:
				if (nextTimeAfterUnfolded.HasValue)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			case 9:
				settings = ((DiagnosticsManager)QNsjUbEhdh6KRdWFL6bL()).Settings;
				num2 = 8;
				break;
			case 10:
				if (!QkORRJEhriws3qMJW5br(settings))
				{
					num2 = 2;
					break;
				}
				num3 = js8vFcEhgko7fti2ZQyw(settings);
				num2 = 6;
				break;
			case 4:
				return;
			case 3:
				return;
			case 2:
				return;
			case 7:
				try
				{
					Export(nextTimeAfterUnfolded.Value);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							huWm7pEhsA5ycEuwR21p(Logger.Log, Thk43iEhJEuuS55GqhkA(0x638095EB ^ 0x6384A74F), ex2);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num7 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto default;
			case 1:
				try
				{
					gigTZrEhcQ43VGXiHIbQ(_lastRunFileName, _lastRunTime.Value.ToString((IFormatProvider)sH3l5KEhyVUPsYyXNRli()));
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
					return;
				}
				catch (Exception ex)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							huWm7pEhsA5ycEuwR21p(Logger.Log, Thk43iEhJEuuS55GqhkA(--1360331293 ^ 0x511130F5), ex);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				}
			case 6:
				nextTimeAfterUnfolded = new NthIncludedDayTrigger(new NthIncludedDaySettings
				{
					ScheduleType = ScheduleType.Daily,
					DailySettings = new DailySettings
					{
						EveryDay = 1,
						OnlyWorkDays = false
					},
					RepeatSettings = new RepeatSettings
					{
						Enabled = (num3 > 0 && num3 < 1440),
						RepeatEvery = I3kRkXEh5NLMfY7EgF45(num3),
						RepeatTo = GPCjWaEhjMEM9X7rhFIp(24.0)
					},
					StartDate = DateTime.Today.Add(settings.ExportReportStartTime.TimeOfDay)
				}, (IProductionSchedule)NKJMgAEhYO4mruHQxmPN(Locator.GetServiceNotNull<IProductionCalendarService>()))
				{
					Name = (string)sRAYNpEhL8mp1N071dgn(Thk43iEhJEuuS55GqhkA(0x92F12D5 ^ 0x92B2339)),
					Id = new Guid((string)Thk43iEhJEuuS55GqhkA(0x10E41EDB ^ 0x10E02C8F))
				}.GetNextTimeAfterUnfolded(_lastRunTime, etjPF0EhUppWVc2B5Akj());
				num2 = 5;
				break;
			}
		}
	}

	private void Export(DateTime dateToRun)
	{
		//Discarded unreachable code: IL_006a, IL_0074, IL_00ee, IL_0121, IL_017e, IL_018d, IL_01be, IL_01fe, IL_0209, IL_0218, IL_0228, IL_039d, IL_03ac
		int num = 2;
		IEnumerator<IDiagnosticsReport> enumerator = default(IEnumerator<IDiagnosticsReport>);
		IDiagnosticsReport current = default(IDiagnosticsReport);
		DateTime value = default(DateTime);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!AT0kuqEGWTiFRJVRdxQg(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 0;
								}
								goto IL_0078;
							}
							goto IL_0092;
							IL_0092:
							current = enumerator.Current;
							num3 = 2;
							goto IL_0078;
							IL_0078:
							switch (num3)
							{
							case 3:
								goto IL_0092;
							case 1:
								continue;
							case 2:
								try
								{
									Ih7vcyEhzUUwNx9Prx2Z(current);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								catch (Exception exception)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											((ILogger)h8rSK4EhMaI22MJvWAkZ()).Error(BdGc0pEGBfwfIGYTRH3A(Thk43iEhJEuuS55GqhkA(-35995181 ^ -35720465), ApkuuJEGFr83h2XXfljK(current)), exception);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num6 = 1;
							}
							goto IL_01c2;
						}
						goto IL_01d8;
						IL_01d8:
						F60JoVEGonOf4p5SHeg3(enumerator);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num6 = 0;
						}
						goto IL_01c2;
						IL_01c2:
						switch (num6)
						{
						default:
							goto end_IL_019d;
						case 2:
							break;
						case 1:
							goto end_IL_019d;
						case 0:
							goto end_IL_019d;
						}
						goto IL_01d8;
						end_IL_019d:;
					}
					goto case 13;
				case 16:
					DiagnosticsManager.Instance.ClearStatistics();
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					return;
				case 11:
					n43W09EGEXG9YMW8RpE3(DiagnosticsManager.Instance);
					num = 3;
					break;
				case 14:
					if (_lastRunTime.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 10:
					if (!R36FeLEGGxy2ZBMEXv7R(value.Date, dateToRun.Date))
					{
						num2 = 9;
						continue;
					}
					goto case 11;
				case 5:
					OUt5o2EGfrXijYwghsfy(Logger.Log, Thk43iEhJEuuS55GqhkA(0x2A7797B7 ^ 0x2A73A43D));
					num2 = 8;
					continue;
				case 17:
					flag = true;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 7;
					}
					continue;
				case 12:
					if (xnQwykEGhF10ivOw6TWi(DlIYb6EGbhHNm2Wbb8NL(DiagnosticsManager.Instance)) == ClearStatisticsPeriod.AfterEveryReport)
					{
						num2 = 16;
						continue;
					}
					goto default;
				case 7:
				case 9:
				case 15:
					if (!flag)
					{
						return;
					}
					num2 = 4;
					continue;
				case 13:
					flag = false;
					num = 12;
					break;
				case 2:
					enumerator = ComponentManager.Current.GetExtensionPoints<IDiagnosticsReport>().GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					value = _lastRunTime.Value;
					num2 = 10;
					continue;
				case 4:
					if (!((ILogger)h8rSK4EhMaI22MJvWAkZ()).IsDebugEnabled())
					{
						return;
					}
					num2 = 5;
					continue;
				case 3:
					flag = true;
					num2 = 15;
					continue;
				default:
					if (((DiagnosticsSettings)DlIYb6EGbhHNm2Wbb8NL(QNsjUbEhdh6KRdWFL6bL())).ClearStatisticsPeriod == ClearStatisticsPeriod.AfterFirstReportAtDay)
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	internal static void t4Fa1LEh7SpRPwQWmVoT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object iNWJZdEhxeafaolo2d3F()
	{
		return ComponentManager.Current;
	}

	internal static bool rATjqeEh0TSRA8j3vvj4(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object zbRZxAEhmf95WRC3QJYm(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static object sH3l5KEhyVUPsYyXNRli()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object h8rSK4EhMaI22MJvWAkZ()
	{
		return Logger.Log;
	}

	internal static object Thk43iEhJEuuS55GqhkA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PDMwwLEh9CHuPwcq2IXe(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool ydXcnKEhHnK5EEyiejJW()
	{
		return EqYNCDEh6dhctPWLhIos == null;
	}

	internal static DiagnosticsReportExporter q1QIriEhAo5N2F7PxxU5()
	{
		return EqYNCDEh6dhctPWLhIos;
	}

	internal static object QNsjUbEhdh6KRdWFL6bL()
	{
		return DiagnosticsManager.Instance;
	}

	internal static bool kvIJsbEhlj67mBFiGlHb(object P_0)
	{
		return ((DiagnosticsSettings)P_0).Enabled;
	}

	internal static bool QkORRJEhriws3qMJW5br(object P_0)
	{
		return ((DiagnosticsSettings)P_0).ExportReports;
	}

	internal static int js8vFcEhgko7fti2ZQyw(object P_0)
	{
		return ((DiagnosticsSettings)P_0).ExportReportPeriod;
	}

	internal static TimeSpan I3kRkXEh5NLMfY7EgF45(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static TimeSpan GPCjWaEhjMEM9X7rhFIp(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static object NKJMgAEhYO4mruHQxmPN(object P_0)
	{
		return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
	}

	internal static object sRAYNpEhL8mp1N071dgn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static DateTime etjPF0EhUppWVc2B5Akj()
	{
		return DateTime.Now;
	}

	internal static void huWm7pEhsA5ycEuwR21p(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void gigTZrEhcQ43VGXiHIbQ(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}

	internal static object Ih7vcyEhzUUwNx9Prx2Z(object P_0)
	{
		return ((IDiagnosticsReport)P_0).Export();
	}

	internal static object ApkuuJEGFr83h2XXfljK(object P_0)
	{
		return ((IDiagnosticsReport)P_0).Name;
	}

	internal static object BdGc0pEGBfwfIGYTRH3A(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool AT0kuqEGWTiFRJVRdxQg(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void F60JoVEGonOf4p5SHeg3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object DlIYb6EGbhHNm2Wbb8NL(object P_0)
	{
		return ((DiagnosticsManager)P_0).Settings;
	}

	internal static ClearStatisticsPeriod xnQwykEGhF10ivOw6TWi(object P_0)
	{
		return ((DiagnosticsSettings)P_0).ClearStatisticsPeriod;
	}

	internal static bool R36FeLEGGxy2ZBMEXv7R(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static void n43W09EGEXG9YMW8RpE3(object P_0)
	{
		((DiagnosticsManager)P_0).ClearStatistics();
	}

	internal static void OUt5o2EGfrXijYwghsfy(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}
}
