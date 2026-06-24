using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
internal sealed class WorkflowInstanceMigrationPackageSweepJobRepository : ISchedulerJobRepository
{
	private class SchedulerJob : SchedulerJobBase
	{
		internal static object PuPQ22GhO34spUp28CM;

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public SchedulerJob(IProductionCalendarService productionCalendarService, WorkflowInstanceMigrationPackageManager migrationPackageManager, ISecurityService securityService, ThreadSubPool subPool)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			paG5aVG8gbD3ZqJkptB();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					num2 = w0k3oHGDKTXJLk27fYx(subPool) - XIbPN1GKyMhMnlmYMZD(subPool);
					num = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
					{
						num = 3;
					}
					continue;
				case 3:
				{
					IJob[] array2;
					if (num2 > 0)
					{
						IJob[] array = new Job[1]
						{
							new Job(migrationPackageManager, securityService, num2, subPool)
						};
						array2 = array;
					}
					else
					{
						array2 = Array.Empty<IJob>();
					}
					Jobs = array2;
					num = 2;
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
						RepeatEvery = I2YLVxGwsX3JYXZJ1To(15.0),
						RepeatTo = QngSJTGtm7D4c3L5uWb(24.0)
					},
					StartDate = xdBLRQGsepLsg44souA().AddMinutes(7.0)
				}, productionCalendarService);
				M9XKkoG2m1soX558g3F(nthIncludedDayTrigger, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658670445)));
				CDjnoTGVFv6oIO7Pti2(nthIncludedDayTrigger, Hn2jprGQlihYgO1kMe4(unMhRwGq9afgWQvNmhJ(-693602260 ^ -693573970)));
				Trigger = nthIncludedDayTrigger;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
				{
					num = 0;
				}
			}
		}

		internal static void paG5aVG8gbD3ZqJkptB()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static TimeSpan I2YLVxGwsX3JYXZJ1To(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static TimeSpan QngSJTGtm7D4c3L5uWb(double P_0)
		{
			return TimeSpan.FromHours(P_0);
		}

		internal static DateTime xdBLRQGsepLsg44souA()
		{
			return DateTime.Today;
		}

		internal static void M9XKkoG2m1soX558g3F(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static object unMhRwGq9afgWQvNmhJ(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Hn2jprGQlihYgO1kMe4(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void CDjnoTGVFv6oIO7Pti2(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static int w0k3oHGDKTXJLk27fYx(object P_0)
		{
			return ((ThreadSubPool)P_0).MaxThreadCount;
		}

		internal static int XIbPN1GKyMhMnlmYMZD(object P_0)
		{
			return ((ThreadSubPool)P_0).ActiveThreadCount;
		}

		internal static bool nZdsrwGxVgVYWJBAZ7D()
		{
			return PuPQ22GhO34spUp28CM == null;
		}

		internal static SchedulerJob XpZmRfGFDSsVRwOlM3p()
		{
			return (SchedulerJob)PuPQ22GhO34spUp28CM;
		}
	}

	private class Job : IJob
	{
		private readonly object migrationPackageManager;

		private readonly object securityService;

		private readonly int packageCount;

		private readonly object subPool;

		internal static object ycv8gkGMNaKn441IrVm;

		public Guid Id => new Guid((string)lGrUnYGv7UlW6jIjHGp(0x3D87FABF ^ 0x3D876449));

		public string Name => (string)YJoYxbGPk9vaavk83r1(lGrUnYGv7UlW6jIjHGp(-2038986505 ^ -2039015499));

		public Image Icon => null;

		public Job(WorkflowInstanceMigrationPackageManager migrationPackageManager, ISecurityService securityService, int packageCount, ThreadSubPool subPool)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					this.packageCount = packageCount;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff != 0)
					{
						num = 2;
					}
					break;
				case 4:
					return;
				case 1:
					this.securityService = securityService;
					num = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
					{
						num = 1;
					}
					break;
				default:
					this.migrationPackageManager = migrationPackageManager;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
					{
						num = 1;
					}
					break;
				case 2:
					this.subPool = subPool;
					num = 4;
					break;
				}
			}
		}

		public JobResult Do(DateTime dateToRun)
		{
			//Discarded unreachable code: IL_005d, IL_006c, IL_0077, IL_0121, IL_0140, IL_014f, IL_017c, IL_018b
			int num = 1;
			int num2 = num;
			IEnumerator<IWorkflowInstanceMigrationPackage> enumerator = default(IEnumerator<IWorkflowInstanceMigrationPackage>);
			IWorkflowInstanceMigrationPackage current = default(IWorkflowInstanceMigrationPackage);
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					JobResult obj = new JobResult
					{
						Status = JobStatus.Success
					};
					hE3Gd6GTn0tn8gZ31RX(obj, true);
					vbFVqXGcIQtZSMtsODM(obj, YJoYxbGPk9vaavk83r1(lGrUnYGv7UlW6jIjHGp(-351702578 ^ -351670680)));
					return obj;
				}
				default:
					try
					{
						while (true)
						{
							IL_00a8:
							int num3;
							if (!q8NfUxG4UlCS6gc0PGm(enumerator))
							{
								num3 = 2;
								goto IL_007b;
							}
							goto IL_0095;
							IL_007b:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto IL_00a8;
								case 3:
									new WorkflowInstanceMigrationPackageSweeper((ISecurityService)securityService, (WorkflowInstanceMigrationPackageManager)migrationPackageManager, current.Id, (IThreadPool)subPool).Sweep();
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									goto end_IL_00a8;
								}
								break;
							}
							goto IL_0095;
							IL_0095:
							current = enumerator.Current;
							num3 = 3;
							goto IL_007b;
							continue;
							end_IL_00a8:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
							{
								num4 = 0;
							}
							goto IL_0125;
						}
						goto IL_015a;
						IL_015a:
						YKwfCUG9SyWQchNxcBh(enumerator);
						num4 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
						{
							num4 = 0;
						}
						goto IL_0125;
						IL_0125:
						switch (num4)
						{
						default:
							goto end_IL_0100;
						case 0:
							goto end_IL_0100;
						case 2:
							break;
						case 1:
							goto end_IL_0100;
						}
						goto IL_015a;
						end_IL_0100:;
					}
					goto case 2;
				case 1:
					enumerator = ((WorkflowInstanceMigrationPackageManager)migrationPackageManager).GetPacketsForProccesing(packageCount).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool mrh12JGaogOgJPKNlup()
		{
			return ycv8gkGMNaKn441IrVm == null;
		}

		internal static Job GQcfRwGY8nZPYv8eFlO()
		{
			return (Job)ycv8gkGMNaKn441IrVm;
		}

		internal static object lGrUnYGv7UlW6jIjHGp(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object YJoYxbGPk9vaavk83r1(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool q8NfUxG4UlCS6gc0PGm(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void YKwfCUG9SyWQchNxcBh(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static void hE3Gd6GTn0tn8gZ31RX(object P_0, bool P_1)
		{
			((JobResult)P_0).NoSaveResult = P_1;
		}

		internal static void vbFVqXGcIQtZSMtsODM(object P_0, object P_1)
		{
			((JobResult)P_0).Information = (string)P_1;
		}
	}

	private class WorkflowInstanceMigrationPackageSweeper
	{
		private readonly long packageId;

		private readonly object manager;

		private readonly object service;

		private readonly object pool;

		internal static object bQDgkkGNPLFa9U12isq;

		public WorkflowInstanceMigrationPackageSweeper(ISecurityService service, WorkflowInstanceMigrationPackageManager manager, long packageId, IThreadPool pool)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cqMEUrGSbdHiBPjXkFf();
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					return;
				default:
					this.pool = pool;
					num = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
					{
						num = 1;
					}
					break;
				case 2:
					this.manager = manager;
					num = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					this.packageId = packageId;
					num = 2;
					break;
				case 1:
					this.service = service;
					num = 4;
					break;
				}
			}
		}

		public void Sweep()
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
					AhT6FEGkx2X2Ism1sdm(pool, (ThreadStart)delegate
					{
						//Discarded unreachable code: IL_009b, IL_00ce, IL_012f, IL_013e
						switch (1)
						{
						case 0:
							break;
						case 1:
							try
							{
								wN6X5hGALgPsyj36UQn(new BackgroundTask(delegate
								{
									//Discarded unreachable code: IL_0057, IL_008a, IL_00eb, IL_00fa
									switch (1)
									{
									case 0:
										break;
									case 1:
										try
										{
											((ISecurityService)service).RunBySystemUser((Action)delegate
											{
												int num7 = 1;
												int num8 = num7;
												while (true)
												{
													switch (num8)
													{
													default:
														return;
													case 1:
														((WorkflowInstanceMigrationPackageManager)manager).StartMigration(((AbstractNHEntityManager<IWorkflowInstanceMigrationPackage, long>)gl9vsmGycLW7aVCJRrC()).Load(packageId));
														num8 = 0;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 != 0)
														{
															num8 = 0;
														}
														break;
													case 0:
														return;
													}
												}
											});
											int num5 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 != 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
											break;
										}
										catch (Exception exception)
										{
											int num6 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												case 1:
													return;
												default:
													((ILogger)FeFZMSGpATmQuNMrXFF()).Warn(kk0sAsGGGP2dfkjXPXX(kFGMrLGUg2l8i3LgAts(-1635137248 ^ -1635162012), packageId), exception);
													num6 = 1;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
													{
														num6 = 1;
													}
													break;
												}
											}
										}
									}
								}, m9qQrVGbMwsT2OaEgMh(typeof(WorkflowInstanceMigrationPackageSweeper).TypeHandle), (string)kFGMrLGUg2l8i3LgAts(0x3D87FABF ^ 0x3D875AA1), (string)QP7lNmGmHJYaQYddisp(kFGMrLGUg2l8i3LgAts(0x77F4B0AB ^ 0x77F41087), new object[1] { packageId })));
								int num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 != 0)
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
							catch (Exception ex)
							{
								int num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										MvrmSUGnW8CE3b3ZIP6(FeFZMSGpATmQuNMrXFF(), kk0sAsGGGP2dfkjXPXX(kFGMrLGUg2l8i3LgAts(0x3F8E27D0 ^ 0x3F8E8744), packageId), ex);
										num4 = 0;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
										{
											num4 = 0;
										}
										break;
									}
								}
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void cqMEUrGSbdHiBPjXkFf()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool NS34GQGdclj1chKAXcO()
		{
			return bQDgkkGNPLFa9U12isq == null;
		}

		internal static WorkflowInstanceMigrationPackageSweeper KdLDiwGjQydDlZNKFM3()
		{
			return (WorkflowInstanceMigrationPackageSweeper)bQDgkkGNPLFa9U12isq;
		}

		internal static void AhT6FEGkx2X2Ism1sdm(object P_0, object P_1)
		{
			((IThreadPool)P_0).Queue((ThreadStart)P_1);
		}

		internal static Type m9qQrVGbMwsT2OaEgMh(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object kFGMrLGUg2l8i3LgAts(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object QP7lNmGmHJYaQYddisp(object P_0, object P_1)
		{
			return SR.T((string)P_0, (object[])P_1);
		}

		internal static void wN6X5hGALgPsyj36UQn(object P_0)
		{
			((BackgroundTask)P_0).Execute();
		}

		internal static object FeFZMSGpATmQuNMrXFF()
		{
			return Logger.Log;
		}

		internal static object kk0sAsGGGP2dfkjXPXX(object P_0, object P_1)
		{
			return string.Concat(P_0, P_1);
		}

		internal static void MvrmSUGnW8CE3b3ZIP6(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Warn(P_1, (Exception)P_2);
		}

		internal static object gl9vsmGycLW7aVCJRrC()
		{
			return WorkflowInstanceMigrationPackageManager.Instance;
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly WorkflowInstanceMigrationPackageManager migrationPackageManager;

	private readonly ILazy<ISecurityService> securityService;

	private readonly ThreadSubPool subPool;

	public WorkflowInstanceMigrationPackageSweepJobRepository(IProductionCalendarService productionCalendarService, WorkflowInstanceMigrationPackageManager migrationPackageManager, ILazy<ISecurityService> securityService)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		this.productionCalendarService = productionCalendarService;
		this.migrationPackageManager = migrationPackageManager;
		this.securityService = securityService;
		int num = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x47356CA4 ^ 0x473557B4), 2);
		if (num <= 0)
		{
			num = 2;
		}
		subPool = new ThreadSubPool(num);
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		if (securityService.IsRegistered)
		{
			return new SchedulerJob[1]
			{
				new SchedulerJob(productionCalendarService, migrationPackageManager, securityService.Value, subPool)
			};
		}
		return Array.Empty<ISchedulerJob>();
	}
}
