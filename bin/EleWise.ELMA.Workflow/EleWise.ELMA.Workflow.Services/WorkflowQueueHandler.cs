using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Timers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Component]
internal class WorkflowQueueHandler : IModuleContainerEvents
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly WorkflowQueueItemManager workflowQueueItemManager;

	private readonly WorkflowQueueService workflowQueueService;

	private readonly WorkflowQueueDbService workflowQueueDbService;

	private readonly ISessionProvider sessionProvider;

	private readonly IBackgroundOperationService backgroundOperationService;

	private readonly Type thisType;

	private System.Timers.Timer timer;

	private CultureInfo currentCulture;

	private CultureInfo currentUiCulture;

	private bool isStarted;

	private DateTime lastRun;

	private DateTime lastFree;

	private static WorkflowQueueHandler zZk8P5UxFDoNcmxJrde;

	public WorkflowQueueHandler(IRuntimeApplication runtimeApplication, WorkflowQueueItemManager workflowQueueItemManager, WorkflowQueueService workflowQueueService, WorkflowQueueDbService workflowQueueDbService, ISessionProvider sessionProvider, IBackgroundOperationService backgroundOperationService)
	{
		//Discarded unreachable code: IL_005f, IL_0064
		dMx0jQUhDX08gTkjR5I();
		thisType = typeof(WorkflowQueueHandler);
		lastRun = DateTime.MinValue;
		lastFree = DateTime.MinValue;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				this.backgroundOperationService = backgroundOperationService;
				num = 2;
				break;
			case 4:
				this.workflowQueueDbService = workflowQueueDbService;
				num = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			case 1:
				this.workflowQueueService = workflowQueueService;
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num = 3;
				}
				break;
			case 6:
				this.sessionProvider = sessionProvider;
				num = 3;
				break;
			default:
				this.runtimeApplication = runtimeApplication;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num = 5;
				}
				break;
			case 5:
				this.workflowQueueItemManager = workflowQueueItemManager;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Activated()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				KbEdBXVKWlA0uXZ8cWw(timer, false);
				num2 = 3;
				break;
			case 1:
				currentCulture = (CultureInfo)((CultureInfo)ABBDiaUwreU6AO5aePH(vWNOOGUECcpN8mPWyyR())).Clone();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				currentUiCulture = (CultureInfo)zILq6WU4ppjxEPsyj9H(((Thread)vWNOOGUECcpN8mPWyyR()).CurrentUICulture);
				num2 = 4;
				break;
			case 2:
				Gi6V8wUzLUXNBUoPhZ5(timer, new ElapsedEventHandler(TimerElapsed));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				return;
			case 3:
				aSkhQXVO3vxY2wSoYaG(timer);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				timer = new System.Timers.Timer(100.0);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void Terminating()
	{
	}

	private void TimerElapsed(object sender, ElapsedEventArgs e)
	{
		//Discarded unreachable code: IL_0047, IL_0092, IL_00a1, IL_00b0, IL_0210, IL_021f, IL_0279, IL_028c, IL_029b
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
				int num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num = 4;
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
						return;
					case 5:
						return;
					case 11:
						return;
					case 10:
						isStarted = true;
						num = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num = 0;
						}
						continue;
					case 4:
						CS_0024_003C_003E8__locals0._003C_003E4__this = this;
						num = 12;
						continue;
					case 8:
						if (!SxKs0pVZUGP1OgRuiPn(runtimeApplication))
						{
							num = 11;
							continue;
						}
						goto case 10;
					case 2:
						UxavESVvG13qXwq3a79(backgroundOperationService);
						num = 9;
						continue;
					case 13:
						CS_0024_003C_003E8__locals0.dateTime = JmKrsqV8k6GZZ05iv8D();
						num = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num = 6;
						}
						continue;
					case 12:
						if (!isStarted)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
							{
								num = 8;
							}
							continue;
						}
						break;
					case 3:
						if (workflowQueueService == null)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 2;
					case 6:
						new BackgroundTask(delegate
						{
							//Discarded unreachable code: IL_0289, IL_02a1, IL_02b0, IL_02bb, IL_0380, IL_03b4, IL_03c7
							int num3 = 8;
							int num4 = num3;
							TimeSpan timeSpan = default(TimeSpan);
							ISession val = default(ISession);
							int num5 = default(int);
							KeyValuePair<long, long> current = default(KeyValuePair<long, long>);
							while (true)
							{
								switch (num4)
								{
								case 12:
									CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueService.ReloadSettings();
									num4 = 9;
									break;
								case 6:
									if (timeSpan.TotalSeconds > (double)SR.GetSetting((string)_003C_003Ec__DisplayClass16_0.pFSIIUZotRSQldlwmrxd(-1393899982 ^ -1394076594), 30))
									{
										num4 = 10;
										break;
									}
									goto case 14;
								case 2:
									CS_0024_003C_003E8__locals0._003C_003E4__this.lastFree = CS_0024_003C_003E8__locals0.dateTime;
									num4 = 14;
									break;
								case 13:
									CS_0024_003C_003E8__locals0._003C_003E4__this.lastRun = CS_0024_003C_003E8__locals0.dateTime;
									num4 = 4;
									break;
								case 5:
									val = (ISession)_003C_003Ec__DisplayClass16_0.OOk6grZoupnLIcYJ7dAt(CS_0024_003C_003E8__locals0._003C_003E4__this.sessionProvider, "");
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
									{
										num4 = 11;
									}
									break;
								default:
									_003C_003Ec__DisplayClass16_0.rct9BDZocaQclANqDC3p(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueItemManager, _003C_003Ec__DisplayClass16_0.rw6rUTZoBkMmqMkI0e0v(_003C_003Ec__DisplayClass16_0.CUGPF9Zo5qLVfbcOvK7l(), _003C_003Ec__DisplayClass16_0.g5IlF3ZogyvlDP3TTNL5(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueService)));
									num4 = 2;
									break;
								case 9:
									num5 = (_003C_003Ec__DisplayClass16_0.DlBGKdZoXvFrA2qR8xOL(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueService.ProcessingPool) - _003C_003Ec__DisplayClass16_0.A3nqApZodPO22GFYv0wD(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueService.ProcessingPool)) * SR.GetSetting((string)_003C_003Ec__DisplayClass16_0.pFSIIUZotRSQldlwmrxd(-1028861977 ^ -1028776697), 2);
									num4 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
									{
										num4 = 15;
									}
									break;
								case 1:
									return;
								case 15:
									if (num5 > 0)
									{
										num4 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
										{
											num4 = 3;
										}
										break;
									}
									goto case 13;
								case 7:
									((Thread)_003C_003Ec__DisplayClass16_0.UbKakbZo0QHZt2cQI9th()).CurrentUICulture = (CultureInfo)_003C_003Ec__DisplayClass16_0.iTxWY2ZoyemlgbAfL18A(CS_0024_003C_003E8__locals0._003C_003E4__this.currentUiCulture);
									num4 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
									{
										num4 = 1;
									}
									break;
								case 11:
									try
									{
										Dictionary<long, long>.Enumerator enumerator = CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueItemManager.GetItems(num5, SR.GetSetting((string)_003C_003Ec__DisplayClass16_0.pFSIIUZotRSQldlwmrxd(-1542190822 ^ -1542131412), 10) - _003C_003Ec__DisplayClass16_0.XpuYC8ZoDH4fFxNJHJEE(CS_0024_003C_003E8__locals0._003C_003E4__this.backgroundOperationService)).GetEnumerator();
										int num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										default:
											try
											{
												while (true)
												{
													IL_031b:
													int num7;
													if (!enumerator.MoveNext())
													{
														num7 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
														{
															num7 = 0;
														}
														goto IL_02bf;
													}
													goto IL_0341;
													IL_0341:
													current = enumerator.Current;
													num7 = 3;
													goto IL_02bf;
													IL_02bf:
													while (true)
													{
														switch (num7)
														{
														case 3:
															CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueService.ProcessItemAsync(current.Key, current.Value, null);
															num7 = 2;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
															{
																num7 = 2;
															}
															continue;
														case 2:
															goto IL_031b;
														case 1:
															goto IL_0341;
														case 0:
															break;
														}
														break;
													}
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator).Dispose();
												int num8 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
												{
													num8 = 0;
												}
												switch (num8)
												{
												case 0:
													break;
												}
											}
											break;
										}
									}
									finally
									{
										_003C_003Ec__DisplayClass16_0.V9wnyvZon43EyHBqdP9l(val);
										int num9 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
										{
											num9 = 0;
										}
										switch (num9)
										{
										case 0:
											break;
										}
									}
									goto case 13;
								case 14:
									timeSpan = _003C_003Ec__DisplayClass16_0.wF15oHZoms9Bljea1bSD(CS_0024_003C_003E8__locals0.dateTime, CS_0024_003C_003E8__locals0._003C_003E4__this.lastRun);
									num4 = 16;
									break;
								case 10:
									_003C_003Ec__DisplayClass16_0.kfemy0ZobSE1gNyUqgVO(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueItemManager);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
									{
										num4 = 0;
									}
									break;
								case 4:
									return;
								case 8:
									((Thread)_003C_003Ec__DisplayClass16_0.UbKakbZo0QHZt2cQI9th()).CurrentCulture = (CultureInfo)CS_0024_003C_003E8__locals0._003C_003E4__this.currentCulture.Clone();
									num4 = 7;
									break;
								case 3:
									timeSpan = _003C_003Ec__DisplayClass16_0.wF15oHZoms9Bljea1bSD(CS_0024_003C_003E8__locals0.dateTime, CS_0024_003C_003E8__locals0._003C_003E4__this.lastFree);
									num4 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
									{
										num4 = 6;
									}
									break;
								case 16:
									if (!(timeSpan.TotalMilliseconds < (double)SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F4E6FA), 1000)))
									{
										_003C_003Ec__DisplayClass16_0.aUWDujZoPOX5Dk4FVxoS(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueDbService);
										num4 = 12;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
										{
											num4 = 10;
										}
									}
									else
									{
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
										{
											num4 = 1;
										}
									}
									break;
								}
							}
						}, thisType, (string)b3VBMVVsHLTo2HfmAgs(-495296780 ^ -495234420), (string)axmdwSVJMUoJ2nYynyy(b3VBMVVsHLTo2HfmAgs(-1214182792 ^ -1214249252))).Execute();
						num = 5;
						continue;
					case 9:
						if (GZX4c8VYbQYNd24Z07E(workflowQueueService.ProcessingPool) <= 0)
						{
							num = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
							{
								num = 1;
							}
							continue;
						}
						goto case 13;
					case 7:
						break;
					}
					if (workflowQueueItemManager == null)
					{
						break;
					}
					num = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num = 1;
					}
				}
				break;
			}
			finally
			{
				aSkhQXVO3vxY2wSoYaG(timer);
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	internal static void dMx0jQUhDX08gTkjR5I()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool flrinFUSMOSeD4OwEND()
	{
		return zZk8P5UxFDoNcmxJrde == null;
	}

	internal static WorkflowQueueHandler dhfSEXU1yL9EvMBRAMx()
	{
		return zZk8P5UxFDoNcmxJrde;
	}

	internal static object vWNOOGUECcpN8mPWyyR()
	{
		return Thread.CurrentThread;
	}

	internal static object ABBDiaUwreU6AO5aePH(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object zILq6WU4ppjxEPsyj9H(object P_0)
	{
		return ((CultureInfo)P_0).Clone();
	}

	internal static void Gi6V8wUzLUXNBUoPhZ5(object P_0, object P_1)
	{
		((System.Timers.Timer)P_0).Elapsed += (ElapsedEventHandler)P_1;
	}

	internal static void KbEdBXVKWlA0uXZ8cWw(object P_0, bool P_1)
	{
		((System.Timers.Timer)P_0).AutoReset = P_1;
	}

	internal static void aSkhQXVO3vxY2wSoYaG(object P_0)
	{
		((System.Timers.Timer)P_0).Start();
	}

	internal static bool SxKs0pVZUGP1OgRuiPn(object P_0)
	{
		return ((IRuntimeApplication)P_0).IsStarted;
	}

	internal static void UxavESVvG13qXwq3a79(object P_0)
	{
		((IBackgroundOperationService)P_0).ProcessBackgroundOperationsCancellation();
	}

	internal static int GZX4c8VYbQYNd24Z07E(object P_0)
	{
		return ((ThreadSubPool)P_0).MaxThreadCount;
	}

	internal static DateTime JmKrsqV8k6GZZ05iv8D()
	{
		return DateTime.Now;
	}

	internal static object b3VBMVVsHLTo2HfmAgs(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object axmdwSVJMUoJ2nYynyy(object P_0)
	{
		return SR.T((string)P_0);
	}
}
