using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
internal sealed class MonitorCacheSweepJobRepository : ISchedulerJobRepository
{
	private class SchedulerJob : SchedulerJobBase
	{
		private readonly object monitorCacheUpdateService;

		private readonly object workflowInstanceManager;

		private static object MFYYnLpPBwrGAB2FaKV;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public SchedulerJob(IProductionCalendarService productionCalendarService, MonitorCacheUpdateService monitorCacheUpdateService, ProcessesWorkflowInstanceManager workflowInstanceManager, MonitorUpdateActionQueueItemManager monitorUpdateActionQueueItemManager, ISessionProvider sessionProvider, WorkflowMonitorSettings workflowMonitorSettings, ThreadSubPool subPool)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			YOJtL5pTRwJ2ja0jKlV();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 1:
					this.workflowInstanceManager = workflowInstanceManager;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
					{
						num = 0;
					}
					continue;
				case 3:
					this.monitorCacheUpdateService = monitorCacheUpdateService;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
					{
						num = 0;
					}
					continue;
				case 4:
					return;
				case 2:
				{
					IJob[] array2;
					if (!cey2LxpSTLvZA5YYv8w(workflowMonitorSettings) && CanUpdate())
					{
						IJob[] array = new Job[1]
						{
							new Job(monitorCacheUpdateService, workflowInstanceManager, monitorUpdateActionQueueItemManager, sessionProvider, subPool)
						};
						array2 = array;
					}
					else
					{
						array2 = Array.Empty<IJob>();
					}
					Jobs = array2;
					num = 4;
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
						RepeatEvery = GetRepeatEveryTimeSpan(),
						RepeatTo = bsuBHgpcCYeCTqnZNUZ(24.0)
					},
					StartDate = AmnlojpN2o54T8qptnA().AddMinutes(6.0)
				}, productionCalendarService);
				UkukTOpdCPZM9ft4cAx(nthIncludedDayTrigger, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-869419654 ^ -869454050)));
				nthIncludedDayTrigger.Name = (string)segR1IpjQ6gvhgBrLkT(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30532583));
				Trigger = nthIncludedDayTrigger;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
				{
					num = 2;
				}
			}
		}

		private TimeSpan GetRepeatEveryTimeSpan()
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (num3 <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return p0TdpTpbGf2bvpYHSSn(num3);
				default:
					num3 = 3;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					num3 = SR.GetSetting((string)bpTYa1pk9vFO97beYvI(0x60D28137 ^ 0x60D21A31), 3);
					num2 = 2;
					break;
				}
			}
		}

		private bool CanUpdate()
		{
			//Discarded unreachable code: IL_00c3, IL_00d2, IL_00e2, IL_00f1
			int num = 2;
			DateTime dateTime = default(DateTime);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!S885JgpACHfN7BTp13e(dateTime.Add(GetRepeatEveryTimeSpan()), evieUtpmfvGaKfLcbkM()))
						{
							num2 = 6;
							continue;
						}
						goto case 5;
					case 4:
						return false;
					case 3:
						return true;
					case 2:
						dateTime = WUSvUOpUXhdNOXJ2SJJ(monitorCacheUpdateService);
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						return false;
					case 6:
						if (!((ProcessesWorkflowInstanceManager)workflowInstanceManager).GlobalRecreateCacheSchedulerTaskActived())
						{
							num2 = 3;
							continue;
						}
						break;
					}
					break;
				}
				((MonitorCacheUpdateService)monitorCacheUpdateService).CacheUpdated();
				num = 4;
			}
		}

		internal static void YOJtL5pTRwJ2ja0jKlV()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static TimeSpan bsuBHgpcCYeCTqnZNUZ(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static DateTime AmnlojpN2o54T8qptnA()
		{
			return DateTime.Today;
		}

		internal static void UkukTOpdCPZM9ft4cAx(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static object segR1IpjQ6gvhgBrLkT(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool cey2LxpSTLvZA5YYv8w(object P_0)
		{
			return ((WorkflowMonitorSettings)P_0).DisableAutoUpdateMonitorCache;
		}

		internal static bool l5SRTip4k7699KWmLfj()
		{
			return MFYYnLpPBwrGAB2FaKV == null;
		}

		internal static SchedulerJob Ew6GFIp9cAxGmSAeZvQ()
		{
			return (SchedulerJob)MFYYnLpPBwrGAB2FaKV;
		}

		internal static object bpTYa1pk9vFO97beYvI(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static TimeSpan p0TdpTpbGf2bvpYHSSn(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static DateTime WUSvUOpUXhdNOXJ2SJJ(object P_0)
		{
			return ((MonitorCacheUpdateService)P_0).GetLastUpdateTime();
		}

		internal static DateTime evieUtpmfvGaKfLcbkM()
		{
			return DateTime.Now;
		}

		internal static bool S885JgpACHfN7BTp13e(DateTime P_0, DateTime P_1)
		{
			return P_0 >= P_1;
		}
	}

	private class Job : IJob
	{
		private readonly object monitorCacheUpdateService;

		private readonly object workflowInstanceManager;

		private readonly object monitorUpdateActionQueueItemManager;

		private readonly object sessionProvider;

		private readonly object subPool;

		internal static object Yxv3LxppNRaKeofuLFV;

		public Guid Id => new Guid((string)Fv5Q0cpOoM90etyG7aD(0x5DD795B3 ^ 0x5DD70EFB));

		public string Name => (string)wR8QrFp6J60ZP62bwrl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51B6C0BE ^ 0x51B65B2A));

		public Image Icon => null;

		public Job(MonitorCacheUpdateService monitorCacheUpdateService, ProcessesWorkflowInstanceManager workflowInstanceManager, MonitorUpdateActionQueueItemManager monitorUpdateActionQueueItemManager, ISessionProvider sessionProvider, ThreadSubPool subPool)
		{
			//Discarded unreachable code: IL_002a
			E2jMPTpy3RYlLDIjEXH();
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 == 0)
			{
				num = 5;
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					this.workflowInstanceManager = workflowInstanceManager;
					num = 2;
					break;
				case 5:
				{
					this.monitorCacheUpdateService = monitorCacheUpdateService;
					int num2 = 4;
					num = num2;
					break;
				}
				default:
					this.subPool = subPool;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
					{
						num = 1;
					}
					break;
				case 3:
					this.sessionProvider = sessionProvider;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.monitorUpdateActionQueueItemManager = monitorUpdateActionQueueItemManager;
					num = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
					{
						num = 3;
					}
					break;
				case 1:
					return;
				}
			}
		}

		public JobResult Do(DateTime dateToRun)
		{
			//Discarded unreachable code: IL_017c, IL_018f, IL_019e, IL_028a, IL_02c2
			int num = 5;
			int num2 = num;
			int num3 = default(int);
			long num6 = default(long);
			int num7 = default(int);
			long[] array = default(long[]);
			ISession session = default(ISession);
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = SR.GetSetting((string)Fv5Q0cpOoM90etyG7aD(-179265198 ^ -179291510), 1000);
					num2 = 4;
					break;
				case 3:
				{
					JobResult jobResult2 = new JobResult();
					aHZfORpWhTwlTLF7FdA(jobResult2, JobStatus.Success);
					jobResult2.NoSaveResult = true;
					iqL3RRplR7GmW7uXJtl(jobResult2, wR8QrFp6J60ZP62bwrl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-465190147 ^ -465215965)));
					return jobResult2;
				}
				case 1:
					NPp7kSpePPGc2kZTYbu(false);
					num2 = 9;
					break;
				case 9:
					try
					{
						int num4 = SR.GetSetting((string)Fv5Q0cpOoM90etyG7aD(0x20C96B1E ^ 0x20C9F7BC), 5);
						int num5 = 4;
						while (true)
						{
							switch (num5)
							{
							case 2:
								new MonitorCacheResolver((MonitorUpdateActionQueueItemManager)monitorUpdateActionQueueItemManager, num6, (IThreadPool)subPool).Send();
								num5 = 5;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
								{
									num5 = 5;
								}
								continue;
							case 10:
								num4 = 5;
								num5 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
								{
									num5 = 1;
								}
								continue;
							case 7:
								num7 = 0;
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
								{
									num5 = 0;
								}
								continue;
							case 4:
								if (num4 > 0)
								{
									int num8 = 3;
									num5 = num8;
									continue;
								}
								goto case 10;
							default:
								if (num7 >= array.Length)
								{
									num5 = 10;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
									{
										num5 = 11;
									}
									continue;
								}
								goto case 6;
							case 1:
							case 3:
							{
								object obj = abBt5SpiNCY62Q2pEow(monitorUpdateActionQueueItemManager, num4);
								cK4e40pRJAV2dl96STq(monitorCacheUpdateService);
								array = (long[])obj;
								num5 = 4;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
								{
									num5 = 7;
								}
								continue;
							}
							case 6:
								num6 = array[num7];
								num5 = 9;
								continue;
							case 9:
								if (processingItems.TryAdd(num6, null))
								{
									num5 = 2;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
									{
										num5 = 0;
									}
									continue;
								}
								break;
							case 5:
								break;
							case 11:
								goto end_IL_00d1;
							}
							num7++;
							num5 = 8;
							continue;
							end_IL_00d1:
							break;
						}
					}
					finally
					{
						NPp7kSpePPGc2kZTYbu(true);
						int num9 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								Gx9JUSpuTF5V1eUDLMy(session);
								num9 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
								{
									num9 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 3;
				case 6:
				{
					JobResult jobResult = new JobResult();
					aHZfORpWhTwlTLF7FdA(jobResult, JobStatus.Success);
					sZY9uQpHwEBhf7l0LlX(jobResult, true);
					jobResult.Information = (string)wR8QrFp6J60ZP62bwrl(Fv5Q0cpOoM90etyG7aD(0x48FEDADC ^ 0x48FE46C0));
					return jobResult;
				}
				case 8:
					if (((MonitorUpdateActionQueueItemManager)monitorUpdateActionQueueItemManager).GetActiveOperationCount() <= num3)
					{
						session = ((ISessionProvider)sessionProvider).GetSession("");
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
						{
							num2 = 7;
						}
					}
					break;
				case 7:
					cK4e40pRJAV2dl96STq(monitorCacheUpdateService);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (num3 <= 0)
					{
						num2 = 2;
						break;
					}
					goto case 8;
				case 2:
					num3 = 1000;
					num2 = 8;
					break;
				default:
					j1JJCBpBokRArmKyQF8(workflowInstanceManager, new NthIncludedDaySettings
					{
						ScheduleType = ScheduleType.Once,
						StartDate = Q5fVjap0JggpssiCrRi()
					});
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void E2jMPTpy3RYlLDIjEXH()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool vqxkfQpG75FDb4785CC()
		{
			return Yxv3LxppNRaKeofuLFV == null;
		}

		internal static Job TPMICBpnr2LrURQQcw9()
		{
			return (Job)Yxv3LxppNRaKeofuLFV;
		}

		internal static object Fv5Q0cpOoM90etyG7aD(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object wR8QrFp6J60ZP62bwrl(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void cK4e40pRJAV2dl96STq(object P_0)
		{
			((MonitorCacheUpdateService)P_0).CacheUpdated();
		}

		internal static DateTime Q5fVjap0JggpssiCrRi()
		{
			return DateTime.Now;
		}

		internal static void j1JJCBpBokRArmKyQF8(object P_0, object P_1)
		{
			((ProcessesWorkflowInstanceManager)P_0).InvokeCreateOrUpdatePlanRecreateCacheJob((NthIncludedDaySettings)P_1);
		}

		internal static void aHZfORpWhTwlTLF7FdA(object P_0, JobStatus P_1)
		{
			((JobResult)P_0).Status = P_1;
		}

		internal static void sZY9uQpHwEBhf7l0LlX(object P_0, bool P_1)
		{
			((JobResult)P_0).NoSaveResult = P_1;
		}

		internal static void NPp7kSpePPGc2kZTYbu(bool P_0)
		{
			EventSettings.Enabled = P_0;
		}

		internal static object abBt5SpiNCY62Q2pEow(object P_0, int P_1)
		{
			return ((MonitorUpdateActionQueueItemManager)P_0).GetTopElemets(P_1);
		}

		internal static void Gx9JUSpuTF5V1eUDLMy(object P_0)
		{
			((ISession)P_0).Clear();
		}

		internal static void iqL3RRplR7GmW7uXJtl(object P_0, object P_1)
		{
			((JobResult)P_0).Information = (string)P_1;
		}
	}

	private class MonitorCacheResolver
	{
		private readonly object manager;

		private readonly long id;

		private readonly object pool;

		internal static object ebyOhKpfm8aTW04Tu6x;

		public MonitorCacheResolver(MonitorUpdateActionQueueItemManager manager, long id, IThreadPool pool)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			NCnVK7prE69LlJR5vTt();
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					this.pool = pool;
					num = 2;
					break;
				case 2:
					this.manager = manager;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
					{
						num = 1;
					}
					break;
				case 3:
					this.id = id;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Send()
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
					JWr3cTp7TlUhCcKN7ak(pool, (ThreadStart)delegate
					{
						//Discarded unreachable code: IL_009c, IL_00e0, IL_00f3, IL_0102
						switch (1)
						{
						case 0:
							break;
						case 1:
							try
							{
								Hui0j0pI38TMSMmxDwR(new BackgroundTask(delegate
								{
									//Discarded unreachable code: IL_0052, IL_00c5, IL_0126, IL_0135
									switch (1)
									{
									case 1:
										try
										{
											IMonitorUpdateActionQueueItem monitorUpdateActionQueueItem = ((AbstractNHEntityManager<IMonitorUpdateActionQueueItem, long>)manager).LoadOrNull(id);
											int num5 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
											{
												num5 = 0;
											}
											while (true)
											{
												switch (num5)
												{
												case 1:
													((MonitorUpdateActionQueueItemManager)manager).ExecuteAction(monitorUpdateActionQueueItem);
													num5 = 2;
													break;
												default:
													if (monitorUpdateActionQueueItem == null)
													{
														return;
													}
													num5 = 1;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
													{
														num5 = 1;
													}
													break;
												case 2:
													return;
												}
											}
										}
										catch (Exception ex)
										{
											int num6 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													voYfp4GEsNYekngpP06(UlVk1IpZFnx7v1ANW6R(), fBdLUVpzGRPhBswBjWd(ovlHO4pgbSSplx0kB4n(-1737696342 ^ -1737734556), id), ex);
													num6 = 1;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 != 0)
													{
														num6 = 0;
													}
													break;
												case 1:
													return;
												}
											}
										}
									case 0:
										break;
									}
								}, sYlvrsp5Cl4PC1B84WO(typeof(MonitorCacheResolver).TypeHandle), (string)ovlHO4pgbSSplx0kB4n(0x713816B4 ^ 0x71388BF8), (string)FYl3Zqp1xYZ0TWY4L25(ovlHO4pgbSSplx0kB4n(--286570904 ^ 0x111424E0), new object[1] { id })));
								int num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 != 0)
								{
									num3 = 0;
								}
								switch (num3)
								{
								case 0:
									break;
								}
								break;
							}
							finally
							{
								processingItems.TryRemove(id, out var _);
								int num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void NCnVK7prE69LlJR5vTt()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool Pr299kpLArEmQbX2jKw()
		{
			return ebyOhKpfm8aTW04Tu6x == null;
		}

		internal static MonitorCacheResolver c5N1nppJJJScT1Ts7xS()
		{
			return (MonitorCacheResolver)ebyOhKpfm8aTW04Tu6x;
		}

		internal static void JWr3cTp7TlUhCcKN7ak(object P_0, object P_1)
		{
			((IThreadPool)P_0).Queue((ThreadStart)P_1);
		}

		internal static Type sYlvrsp5Cl4PC1B84WO(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object ovlHO4pgbSSplx0kB4n(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object FYl3Zqp1xYZ0TWY4L25(object P_0, object P_1)
		{
			return SR.T((string)P_0, (object[])P_1);
		}

		internal static void Hui0j0pI38TMSMmxDwR(object P_0)
		{
			((BackgroundTask)P_0).Execute();
		}

		internal static object UlVk1IpZFnx7v1ANW6R()
		{
			return Logger.Log;
		}

		internal static object fBdLUVpzGRPhBswBjWd(object P_0, object P_1)
		{
			return string.Concat(P_0, P_1);
		}

		internal static void voYfp4GEsNYekngpP06(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Debug(P_1, (Exception)P_2);
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly MonitorCacheUpdateService monitorCacheUpdateService;

	private readonly ProcessesWorkflowInstanceManager processesWorkflowInstanceManager;

	private readonly MonitorUpdateActionQueueItemManager monitorUpdateActionQueueItemManager;

	private readonly ISessionProvider sessionProvider;

	private readonly ILazy<WorkflowMonitorSettingsModule> workflowMonitorSettingsModule;

	private readonly ThreadSubPool subPool;

	internal static readonly ConcurrentDictionary<long, object> processingItems;

	internal static MonitorCacheSweepJobRepository O42S8n8mp13sxK8dZYf;

	public MonitorCacheSweepJobRepository(IProductionCalendarService productionCalendarService, MonitorCacheUpdateService monitorCacheUpdateService, ProcessesWorkflowInstanceManager processesWorkflowInstanceManager, MonitorUpdateActionQueueItemManager monitorUpdateActionQueueItemManager, ISessionProvider sessionProvider, ILazy<WorkflowMonitorSettingsModule> workflowMonitorSettingsModule)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		this.productionCalendarService = productionCalendarService;
		this.monitorCacheUpdateService = monitorCacheUpdateService;
		this.processesWorkflowInstanceManager = processesWorkflowInstanceManager;
		this.monitorUpdateActionQueueItemManager = monitorUpdateActionQueueItemManager;
		this.sessionProvider = sessionProvider;
		this.workflowMonitorSettingsModule = workflowMonitorSettingsModule;
		subPool = new ThreadSubPool(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882678999 ^ -882680841), 1);
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		if (workflowMonitorSettingsModule.IsRegistered)
		{
			return new SchedulerJob[1]
			{
				new SchedulerJob(productionCalendarService, monitorCacheUpdateService, processesWorkflowInstanceManager, monitorUpdateActionQueueItemManager, sessionProvider, workflowMonitorSettingsModule.Value.Settings, subPool)
			};
		}
		return Array.Empty<ISchedulerJob>();
	}

	static MonitorCacheSweepJobRepository()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Gnuq6C8GmwkxPPgakcd();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				processingItems = new ConcurrentDictionary<long, object>();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void Gnuq6C8GmwkxPPgakcd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool Ku4S328Af89fkZpPTgH()
	{
		return O42S8n8mp13sxK8dZYf == null;
	}

	internal static MonitorCacheSweepJobRepository D2CpBa8pavNv7tFPFF1()
	{
		return O42S8n8mp13sxK8dZYf;
	}
}
