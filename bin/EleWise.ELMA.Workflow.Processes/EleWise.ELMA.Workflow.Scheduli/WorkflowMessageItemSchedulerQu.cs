using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component(Type = ComponentType.WebServer)]
internal class WorkflowMessageItemSchedulerQueue : ISchedulerJobRepository
{
	private class MessageQueueSchedulerJob : SchedulerJobBase
	{
		private class ProcessQueueJob : IJob
		{
			private static object o52dYOiCp5CdIdEBbY4;

			public Guid Id => new Guid((string)pgjsndi342Xj77rIabi(0x7AADECE0 ^ 0x7AAD3C80));

			public string Name => (string)VgnGPTih73O5Bok79xv(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275509479));

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				int num = 3;
				int num2 = num;
				JobResult jobResult = default(JobResult);
				WorkflowMessageQueueInfo workflowMessageQueueInfo = default(WorkflowMessageQueueInfo);
				while (true)
				{
					switch (num2)
					{
					case 4:
						rFjyvoisKTYglhwPS98(jobResult, SR.T((string)pgjsndi342Xj77rIabi(0x60D28137 ^ 0x60D25015), hQDTP5iwuHqwuSsW0iI(workflowMessageQueueInfo), JeAg50itdte8BBv9jkX(workflowMessageQueueInfo), workflowMessageQueueInfo.ReceiversCount));
						num2 = 5;
						break;
					default:
						e9XTwUi8Z0A2K79Trtl(jobResult, true);
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
						{
							num2 = 4;
						}
						break;
					case 3:
						workflowMessageQueueInfo = (WorkflowMessageQueueInfo)BI5F5RixcyrTB45wQZg(Locator.GetServiceNotNull<WorkflowMessagingService>());
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						bULyKciF90qwE2p44W1(jobResult, JobStatus.Success);
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						return jobResult;
					case 2:
						jobResult = new JobResult();
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			public ProcessQueueJob()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				hHKFFEi2vJoIBYQRSFJ();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object pgjsndi342Xj77rIabi(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool mu0YTgiXkhccb6t6gFY()
			{
				return o52dYOiCp5CdIdEBbY4 == null;
			}

			internal static ProcessQueueJob DPKuXOioTQ677Pxr2GV()
			{
				return (ProcessQueueJob)o52dYOiCp5CdIdEBbY4;
			}

			internal static object VgnGPTih73O5Bok79xv(object P_0)
			{
				return SR.T((string)P_0);
			}

			internal static object BI5F5RixcyrTB45wQZg(object P_0)
			{
				return ((WorkflowMessagingService)P_0).ProcessMessageQueue();
			}

			internal static void bULyKciF90qwE2p44W1(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void e9XTwUi8Z0A2K79Trtl(object P_0, bool P_1)
			{
				((JobResult)P_0).NoSaveResult = P_1;
			}

			internal static int hQDTP5iwuHqwuSsW0iI(object P_0)
			{
				return ((WorkflowMessageQueueInfo)P_0).StaleCount;
			}

			internal static int JeAg50itdte8BBv9jkX(object P_0)
			{
				return ((WorkflowMessageQueueInfo)P_0).MessagesCount;
			}

			internal static void rFjyvoisKTYglhwPS98(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}

			internal static void hHKFFEi2vJoIBYQRSFJ()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			}
		}

		private readonly object trigger;

		private readonly ICollection<IJob> jobs;

		private static object BwDsmYGOZahCxI2xy1h;

		public override ITrigger Trigger => (ITrigger)trigger;

		public override ICollection<IJob> Jobs => jobs;

		public override Guid? OwnerUid => WorkflowMessageItemSchedulerTaskOwner.UID;

		public override bool Hidden => false;

		public MessageQueueSchedulerJob()
		{
			//Discarded unreachable code: IL_001a, IL_001f
			iooJkQG0ymhasPG9RgF();
			base._002Ector();
			int num = 3;
			NthIncludedDaySettings nthIncludedDaySettings = default(NthIncludedDaySettings);
			while (true)
			{
				switch (num)
				{
				default:
					jobs = new List<IJob>
					{
						new ProcessQueueJob()
					};
					num = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
					{
						num = 2;
					}
					break;
				case 1:
				{
					NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(nthIncludedDaySettings, Locator.GetService<IProductionCalendarService>());
					E7meEHGeEXTeYCs6def(nthIncludedDayTrigger, TriggerGuid);
					A1fAEkGuUGunIq8yOm0(nthIncludedDayTrigger, SR.T((string)TNnRSAGixlImhP9ewDm(--47835757 ^ 0x2D94BA7)));
					trigger = nthIncludedDayTrigger;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
					{
						num = 0;
					}
					break;
				}
				case 3:
					nthIncludedDaySettings = new NthIncludedDaySettings
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
							RepeatEvery = wtLnuTGBsFXwLDkmAk6(2.0),
							RepeatTo = oYBFh3GWJelucvKe69D(24.0)
						},
						StartDate = GKk4fqGH3gVwyBw1nW1()
					};
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static void iooJkQG0ymhasPG9RgF()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static TimeSpan wtLnuTGBsFXwLDkmAk6(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static TimeSpan oYBFh3GWJelucvKe69D(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static DateTime GKk4fqGH3gVwyBw1nW1()
		{
			return DateTime.Today;
		}

		internal static void E7meEHGeEXTeYCs6def(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static object TNnRSAGixlImhP9ewDm(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void A1fAEkGuUGunIq8yOm0(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static bool fqGWlfG6qWAVOL9X2b2()
		{
			return BwDsmYGOZahCxI2xy1h == null;
		}

		internal static MessageQueueSchedulerJob j5BvUSGR6G9toa6vTWd()
		{
			return (MessageQueueSchedulerJob)BwDsmYGOZahCxI2xy1h;
		}
	}

	public static readonly Guid TriggerGuid;

	internal static WorkflowMessageItemSchedulerQueue IaYaXiw4dmDuIFQSCy7;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new ISchedulerJob[1]
		{
			new MessageQueueSchedulerJob()
		};
	}

	public WorkflowMessageItemSchedulerQueue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		e709HbwcCKT2BJ3sKVP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessageItemSchedulerQueue()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				e709HbwcCKT2BJ3sKVP();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TriggerGuid = new Guid((string)eNUXsdwNSTAfVnZgDfy(-1635137248 ^ -1635126702));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void e709HbwcCKT2BJ3sKVP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool k0cOrGw9qaFJ878Rj6n()
	{
		return IaYaXiw4dmDuIFQSCy7 == null;
	}

	internal static WorkflowMessageItemSchedulerQueue EF7nG1wTqnQO4fIaYWH()
	{
		return IaYaXiw4dmDuIFQSCy7;
	}

	internal static object eNUXsdwNSTAfVnZgDfy(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
