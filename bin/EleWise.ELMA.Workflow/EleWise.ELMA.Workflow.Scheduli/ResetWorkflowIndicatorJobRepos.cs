using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.KPI.Common.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class ResetWorkflowIndicatorJobRepository : ISchedulerJobRepository
{
	private class ResetWorkflowIndicatorJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private static object G7AbC4vTZ4P4rO6poGuw;

			public Guid Id => new Guid((string)YIQVrNvT8ZAnultUef4J(-360662087 ^ -360561677));

			public string Name => SR.T((string)YIQVrNvT8ZAnultUef4J(-667465279 ^ -667569833));

			public Image Icon => Resources.BPMNProcess16;

			public JobResult Do(DateTime dateToRun)
			{
				//Discarded unreachable code: IL_00b4, IL_00d0, IL_00df, IL_018b, IL_019a, IL_0200, IL_02e8, IL_0343, IL_0352, IL_0362, IL_0372, IL_0598, IL_05d8, IL_05e7, IL_05f3, IL_0602, IL_06de, IL_06ed, IL_0751, IL_0789, IL_0798, IL_07c3, IL_07fc, IL_080b, IL_0816, IL_0873, IL_0892, IL_08a1, IL_08be, IL_08cd
				int num = 8;
				int num2 = num;
				IEnumerable<ProcessMetricsContainer> publishedProcessMetrics = default(IEnumerable<ProcessMetricsContainer>);
				Stopwatch stopwatch = default(Stopwatch);
				string text = default(string);
				ProcessMetricsContainer current = default(ProcessMetricsContainer);
				IEnumerator<ProcessMetric> enumerator2 = default(IEnumerator<ProcessMetric>);
				ProcessMetric current2 = default(ProcessMetric);
				Guid? periodicityUid = default(Guid?);
				Guid guid = default(Guid);
				List<string> list = default(List<string>);
				ISession session = default(ISession);
				IUnitOfWork unitOfWork = default(IUnitOfWork);
				StringBuilder stringBuilder = default(StringBuilder);
				while (true)
				{
					switch (num2)
					{
					case 3:
						publishedProcessMetrics = Locator.GetServiceNotNull<WorkflowProcessManager>().GetPublishedProcessMetrics();
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
						{
							num2 = 3;
						}
						break;
					case 7:
						stopwatch = new Stopwatch();
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 4;
						}
						break;
					case 1:
						try
						{
							try
							{
								IEnumerator<ProcessMetricsContainer> enumerator = publishedProcessMetrics.GetEnumerator();
								int num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
								{
									num3 = 1;
								}
								switch (num3)
								{
								case 1:
									try
									{
										while (true)
										{
											IL_06f8:
											int num4;
											if (!taWT28vTckdFndjwkYh1(enumerator))
											{
												num4 = 5;
												goto IL_00ee;
											}
											goto IL_0162;
											IL_00ee:
											while (true)
											{
												switch (num4)
												{
												case 2:
													text = (string)YAs1ZwvTlW7IepjBYVuq(YIQVrNvT8ZAnultUef4J(0x5F800F5B ^ 0x5F82F643), current.TableName);
													num4 = 8;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
													{
														num4 = 3;
													}
													continue;
												case 4:
													break;
												case 6:
													try
													{
														while (true)
														{
															int num6;
															if (!taWT28vTckdFndjwkYh1(enumerator2))
															{
																num6 = 10;
																goto IL_01a9;
															}
															goto IL_032b;
															IL_01a9:
															while (true)
															{
																int num8;
																int num7;
																int num9;
																int num10;
																int num11;
																int num12;
																switch (num6)
																{
																case 7:
																	if (current2 == null)
																	{
																		num6 = 17;
																		continue;
																	}
																	goto case 16;
																case 13:
																	if (!qY4wINvTyk0NZhr7de6x(periodicityUid.Value, Guid.Empty))
																	{
																		num8 = 5;
																		goto IL_01a5;
																	}
																	goto case 14;
																case 4:
																	periodicityUid = current2.PeriodicityUid;
																	num6 = 8;
																	continue;
																case 14:
																	guid = PeriodicityService.DayPeriodicy.Uid;
																	num6 = 9;
																	continue;
																case 12:
																	list.Add((string)YAs1ZwvTlW7IepjBYVuq(YIQVrNvT8ZAnultUef4J(0x51EF0063 ^ 0x51EDF959), cfatyVvTBmrQuqtHVZ4I(current2)));
																	num6 = 6;
																	continue;
																case 16:
																	if (!ok31HdvT0DdSjYae27cw(current2))
																	{
																		num6 = 2;
																		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
																		{
																			num6 = 2;
																		}
																		continue;
																	}
																	goto case 4;
																case 15:
																	periodicityUid = current2.PeriodicityUid;
																	num8 = 13;
																	goto IL_01a5;
																case 2:
																case 5:
																case 6:
																case 17:
																	break;
																case 9:
																	periodicityUid = current2.PeriodicityUid;
																	num6 = 3;
																	continue;
																case 3:
																	if (periodicityUid.HasValue)
																	{
																		num6 = 0;
																		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
																		{
																			num6 = 0;
																		}
																		continue;
																	}
																	goto case 11;
																case 1:
																	goto IL_032b;
																case 11:
																	num7 = 0;
																	goto IL_03ab;
																case 8:
																	if (periodicityUid.HasValue)
																	{
																		num6 = 11;
																		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
																		{
																			num6 = 15;
																		}
																		continue;
																	}
																	break;
																default:
																	num7 = (zOlvRpvTmAOVyurRjWxB(guid, periodicityUid.GetValueOrDefault()) ? 1 : 0);
																	goto IL_03ab;
																case 10:
																	goto end_IL_02cd;
																	IL_03ab:
																	guid = x5wuqJvTt3HlBxc31Ojn();
																	periodicityUid = current2.PeriodicityUid;
																	num9 = num7 | ((periodicityUid.HasValue && zOlvRpvTmAOVyurRjWxB(guid, periodicityUid.GetValueOrDefault()) && dateToRun.DayOfWeek == DayOfWeek.Monday) ? 1 : 0);
																	guid = GSwp9CvTbtMaFsNtMJ4j();
																	periodicityUid = current2.PeriodicityUid;
																	num10 = num9 | ((guid == periodicityUid && dateToRun.Day == 1) ? 1 : 0);
																	guid = dfReX2vT5c60VanhXjQ2();
																	periodicityUid = current2.PeriodicityUid;
																	num11 = num10 | ((periodicityUid.HasValue && zOlvRpvTmAOVyurRjWxB(guid, periodicityUid.GetValueOrDefault()) && dateToRun.Day == 1 && (dateToRun.Month == 1 || dateToRun.Month == 4 || dateToRun.Month == 7 || dateToRun.Month == 10)) ? 1 : 0);
																	guid = rTXBQqvTgKT4dGRH845T();
																	periodicityUid = current2.PeriodicityUid;
																	num12 = num11 | ((periodicityUid.HasValue && guid == periodicityUid.GetValueOrDefault() && dateToRun.Day == 1 && (dateToRun.Month == 1 || dateToRun.Month == 7)) ? 1 : 0);
																	guid = PeriodicityService.YearPeriodicy.Uid;
																	periodicityUid = current2.PeriodicityUid;
																	if (((uint)num12 | ((periodicityUid.HasValue && zOlvRpvTmAOVyurRjWxB(guid, periodicityUid.GetValueOrDefault()) && dateToRun.DayOfYear == 1) ? 1u : 0u)) != 0)
																	{
																		num6 = 12;
																		continue;
																	}
																	break;
																	IL_01a5:
																	num6 = num8;
																	continue;
																}
																break;
															}
															continue;
															IL_032b:
															current2 = enumerator2.Current;
															num6 = 7;
															goto IL_01a9;
															continue;
															end_IL_02cd:
															break;
														}
													}
													finally
													{
														int num13;
														if (enumerator2 == null)
														{
															num13 = 2;
															goto IL_059c;
														}
														goto IL_05b2;
														IL_059c:
														switch (num13)
														{
														default:
															goto end_IL_0587;
														case 1:
															break;
														case 2:
															goto end_IL_0587;
														case 0:
															goto end_IL_0587;
														}
														goto IL_05b2;
														IL_05b2:
														lsieTWvTPAXTkGrG6Ecv(enumerator2);
														num13 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
														{
															num13 = 0;
														}
														goto IL_059c;
														end_IL_0587:;
													}
													goto case 1;
												case 8:
												{
													list = new List<string>();
													int num5 = 7;
													num4 = num5;
													continue;
												}
												case 1:
													if (!list.Any())
													{
														num4 = 3;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
														{
															num4 = 1;
														}
														continue;
													}
													goto case 9;
												case 9:
													Q7x8gmvTdOIntMgJGIco(session.CreateSQLQuery((string)OGLBWUvTXepEh7ZJJbce(YIQVrNvT8ZAnultUef4J(-106528299 ^ -106556287), text, string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EEB5B), list))), false);
													num4 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
													{
														num4 = 0;
													}
													continue;
												default:
													session.CleanUpCache(InterfaceActivator.TypeOf<ProcessMetricsContainer>());
													num4 = 5;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
													{
														num4 = 10;
													}
													continue;
												case 3:
												case 10:
													goto IL_06f8;
												case 7:
													enumerator2 = ((IEnumerable)current.EntityProperties).Cast<ProcessMetric>().GetEnumerator();
													num4 = 6;
													continue;
												case 5:
													goto end_IL_06f8;
												}
												break;
											}
											goto IL_0162;
											IL_0162:
											current = enumerator.Current;
											num4 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
											{
												num4 = 1;
											}
											goto IL_00ee;
											continue;
											end_IL_06f8:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num14 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
											{
												num14 = 1;
											}
											while (true)
											{
												switch (num14)
												{
												case 1:
													lsieTWvTPAXTkGrG6Ecv(enumerator);
													num14 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
													{
														num14 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									break;
								case 0:
									break;
								}
							}
							catch (Exception)
							{
								int num15 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
								{
									num15 = 1;
								}
								while (true)
								{
									switch (num15)
									{
									case 1:
										LDFtR7vTuUkjOxUcwQeR(unitOfWork);
										num15 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
										{
											num15 = 0;
										}
										break;
									default:
										throw;
									}
								}
							}
							while (true)
							{
								xni46AvTDK74nx0sEeJ9(unitOfWork);
								int num16 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
								{
									num16 = 1;
								}
								switch (num16)
								{
								case 1:
									goto end_IL_082c;
								}
								continue;
								end_IL_082c:
								break;
							}
						}
						finally
						{
							int num17;
							if (unitOfWork == null)
							{
								num17 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
								{
									num17 = 0;
								}
								goto IL_0877;
							}
							goto IL_08ac;
							IL_08ac:
							unitOfWork.Dispose();
							num17 = 2;
							goto IL_0877;
							IL_0877:
							switch (num17)
							{
							default:
								goto end_IL_0852;
							case 0:
								goto end_IL_0852;
							case 1:
								break;
							case 2:
								goto end_IL_0852;
							}
							goto IL_08ac;
							end_IL_0852:;
						}
						goto default;
					case 6:
						kTQPEjvTHLOi4O0Cd4al(stringBuilder, ifCWDivTLaEkbSxbXlpu(YIQVrNvT8ZAnultUef4J(-1657582555 ^ -1657686665), new object[1] { stopwatch.ElapsedMilliseconds }));
						num2 = 4;
						break;
					case 4:
					{
						JobResult jobResult = new JobResult();
						CPOQZxvTfkI7UHo85rej(jobResult, JobStatus.Success);
						zNQ2kdvT9XxxAjxxArAW(jobResult, stringBuilder.ToString());
						return jobResult;
					}
					case 5:
						session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
						num2 = 10;
						break;
					case 9:
						NlXrb7vTsQOJnthM6SsJ(stopwatch);
						num2 = 3;
						break;
					default:
						m3N2nRvTnKThmYloTGTf(stopwatch);
						num2 = 2;
						break;
					case 2:
						kTQPEjvTHLOi4O0Cd4al(stringBuilder, "");
						num2 = 6;
						break;
					case 8:
						stringBuilder = new StringBuilder();
						num2 = 7;
						break;
					case 10:
						unitOfWork = (IUnitOfWork)OOPc7kvTJltSZqJAM9I1("");
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			public JobImpl()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				lN7o4tvTWkQQnykLXn6G();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object YIQVrNvT8ZAnultUef4J(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool qjv73KvTv67YuTsFCc8V()
			{
				return G7AbC4vTZ4P4rO6poGuw == null;
			}

			internal static JobImpl ns3XdsvTYDYmqDJ6q2Sq()
			{
				return (JobImpl)G7AbC4vTZ4P4rO6poGuw;
			}

			internal static void NlXrb7vTsQOJnthM6SsJ(object P_0)
			{
				((Stopwatch)P_0).Start();
			}

			internal static object OOPc7kvTJltSZqJAM9I1(object P_0)
			{
				return UnitOfWork.New((string)P_0);
			}

			internal static object YAs1ZwvTlW7IepjBYVuq(object P_0, object P_1)
			{
				return string.Format((string)P_0, P_1);
			}

			internal static bool ok31HdvT0DdSjYae27cw(object P_0)
			{
				return ((ProcessMetric)P_0).UsePeriodicity;
			}

			internal static bool qY4wINvTyk0NZhr7de6x(Guid P_0, Guid P_1)
			{
				return P_0 != P_1;
			}

			internal static bool zOlvRpvTmAOVyurRjWxB(Guid P_0, Guid P_1)
			{
				return P_0 == P_1;
			}

			internal static Guid x5wuqJvTt3HlBxc31Ojn()
			{
				return PeriodicityService.WeekPeriodicy.Uid;
			}

			internal static Guid GSwp9CvTbtMaFsNtMJ4j()
			{
				return PeriodicityService.MonthPeriodicy.Uid;
			}

			internal static Guid dfReX2vT5c60VanhXjQ2()
			{
				return PeriodicityService.QuarterPeriodicy.Uid;
			}

			internal static Guid rTXBQqvTgKT4dGRH845T()
			{
				return PeriodicityService.HalfYearPeriodicy.Uid;
			}

			internal static object cfatyVvTBmrQuqtHVZ4I(object P_0)
			{
				return ((NamedMetadata)P_0).Name;
			}

			internal static bool taWT28vTckdFndjwkYh1(object P_0)
			{
				return ((IEnumerator)P_0).MoveNext();
			}

			internal static void lsieTWvTPAXTkGrG6Ecv(object P_0)
			{
				((IDisposable)P_0).Dispose();
			}

			internal static object OGLBWUvTXepEh7ZJJbce(object P_0, object P_1, object P_2)
			{
				return string.Format((string)P_0, P_1, P_2);
			}

			internal static int Q7x8gmvTdOIntMgJGIco(object P_0, bool P_1)
			{
				return ((IQuery)P_0).ExecuteUpdate(P_1);
			}

			internal static void LDFtR7vTuUkjOxUcwQeR(object P_0)
			{
				((IUnitOfWork)P_0).Rollback();
			}

			internal static void xni46AvTDK74nx0sEeJ9(object P_0)
			{
				((IUnitOfWork)P_0).Commit();
			}

			internal static void m3N2nRvTnKThmYloTGTf(object P_0)
			{
				((Stopwatch)P_0).Stop();
			}

			internal static object kTQPEjvTHLOi4O0Cd4al(object P_0, object P_1)
			{
				return ((StringBuilder)P_0).AppendLine((string)P_1);
			}

			internal static object ifCWDivTLaEkbSxbXlpu(object P_0, object P_1)
			{
				return SR.T((string)P_0, (object[])P_1);
			}

			internal static void CPOQZxvTfkI7UHo85rej(object P_0, JobStatus P_1)
			{
				((JobResult)P_0).Status = P_1;
			}

			internal static void zNQ2kdvT9XxxAjxxArAW(object P_0, object P_1)
			{
				((JobResult)P_0).Information = (string)P_1;
			}

			internal static void lN7o4tvTWkQQnykLXn6G()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}
		}

		private readonly object _trigger;

		private readonly ICollection<IJob> _jobs;

		internal static object pxvjyrZWaylkb8AXv4ji;

		public override ITrigger Trigger => (ITrigger)_trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public ResetWorkflowIndicatorJob()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Bm5sxtZWNkbYECSi8Q2j();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					_jobs = new List<IJob>
					{
						new JobImpl()
					};
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					return;
				}
				NthIncludedDayTrigger nthIncludedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
				{
					ScheduleType = ScheduleType.Daily,
					DailySettings = new DailySettings
					{
						EveryDay = 1,
						OnlyWorkDays = false
					},
					StartDate = Y4BpdiZWxxnJEC4okAoG().AddMinutes(1.0),
					OvertimeToRun = TimeSpan.FromMinutes(1.0)
				}, (IProductionSchedule)BJnVvmZWSTsjtPxMfsNj(Locator.GetServiceNotNull<IProductionCalendarService>()));
				mfiByBZWEY35aDvXWMYq(nthIncludedDayTrigger, yW7jNpZWhICo0dfWR8Gu(weRCCUZW16M31iOTee0Z(-1214182792 ^ -1214005062)));
				SkA5XsZWww2BOEiKq0un(nthIncludedDayTrigger, new Guid((string)weRCCUZW16M31iOTee0Z(-10408775 ^ -10229763)));
				_trigger = nthIncludedDayTrigger;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num = 1;
				}
			}
		}

		internal static void Bm5sxtZWNkbYECSi8Q2j()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static DateTime Y4BpdiZWxxnJEC4okAoG()
		{
			return DateTime.Today;
		}

		internal static object BJnVvmZWSTsjtPxMfsNj(object P_0)
		{
			return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
		}

		internal static object weRCCUZW16M31iOTee0Z(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object yW7jNpZWhICo0dfWR8Gu(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void mfiByBZWEY35aDvXWMYq(object P_0, object P_1)
		{
			((NthIncludedDayTrigger)P_0).Name = (string)P_1;
		}

		internal static void SkA5XsZWww2BOEiKq0un(object P_0, Guid P_1)
		{
			((NthIncludedDayTrigger)P_0).Id = P_1;
		}

		internal static bool JhnTIVZWrLTlxuAIg15y()
		{
			return pxvjyrZWaylkb8AXv4ji == null;
		}

		internal static ResetWorkflowIndicatorJob OHlWLqZWeWQGyMONpCco()
		{
			return (ResetWorkflowIndicatorJob)pxvjyrZWaylkb8AXv4ji;
		}
	}

	internal static ResetWorkflowIndicatorJobRepository vtL4aPtJJ386bjAHuuU;

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new ResetWorkflowIndicatorJob()
		};
	}

	public ResetWorkflowIndicatorJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YwetNTtlPLjwWJiToru()
	{
		return vtL4aPtJJ386bjAHuuU == null;
	}

	internal static ResetWorkflowIndicatorJobRepository q6WAZxt0SB6Mt0vMTqO()
	{
		return vtL4aPtJJ386bjAHuuU;
	}
}
