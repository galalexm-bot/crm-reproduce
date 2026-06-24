using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ComponentOrder(0)]
internal class CommonStatisticsPage : PerformanceReportPage
{
	internal static CommonStatisticsPage aBRGMMEQXfjp2Sk0MLWh;

	public override string Name => (string)yMSoRuEQOMy2jxBatbEZ(Wb38NaEQn7wkAn8k42e6(-672123589 ^ -671874213));

	public CommonStatisticsPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		//Discarded unreachable code: IL_00a7, IL_00c7, IL_00d6, IL_00e1, IL_0119, IL_0128, IL_0133, IL_026b, IL_028a, IL_0299, IL_02c6, IL_03e4, IL_0424, IL_0433, IL_043f
		int num = 1;
		IEnumerator<ICommonInformationPart> enumerator = default(IEnumerator<ICommonInformationPart>);
		ICommonInformationPart current = default(ICommonInformationPart);
		IEnumerator<CommonInformationPartItem> enumerator2 = default(IEnumerator<CommonInformationPartItem>);
		CommonInformationPartItem current2 = default(CommonInformationPartItem);
		List<DateTimeRange> list = default(List<DateTimeRange>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					builder.SetValues(yMSoRuEQOMy2jxBatbEZ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335252297)), k1o4MeEQNyNCblxqBLdj());
					num2 = 8;
					continue;
				case 4:
					if (!PK1DjpEQ3PvGcIwNHhTG())
					{
						num2 = 14;
						continue;
					}
					goto case 3;
				case 8:
					UJLYPTEQ13HZHdiKall8(builder);
					num2 = 13;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_034f:
							int num3;
							if (!dLXAuuEQHMFGYjIP1RKI(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num3 = 2;
								}
								goto IL_00e5;
							}
							goto IL_031c;
							IL_031c:
							current = enumerator.Current;
							num3 = 4;
							goto IL_00e5;
							IL_00e5:
							while (true)
							{
								switch (num3)
								{
								case 8:
									try
									{
										while (true)
										{
											IL_019e:
											int num4;
											if (!dLXAuuEQHMFGYjIP1RKI(enumerator2))
											{
												num4 = 7;
												goto IL_0137;
											}
											goto IL_0165;
											IL_0137:
											while (true)
											{
												switch (num4)
												{
												case 6:
													if (LXf74IEQ6jgAeYvMwTPw(current2) != null)
													{
														num4 = 4;
														continue;
													}
													goto IL_019e;
												case 3:
													goto IL_019e;
												case 8:
													if (dSTJFfEQ4wZbTPvj3LvP(current2) != null)
													{
														num4 = 5;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
														{
															num4 = 5;
														}
														continue;
													}
													goto case 6;
												case 4:
													builder.SetValue(2, LXf74IEQ6jgAeYvMwTPw(current2));
													num4 = 3;
													continue;
												case 5:
													builder.SetValue(1, dSTJFfEQ4wZbTPvj3LvP(current2));
													num4 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
													{
														num4 = 6;
													}
													continue;
												case 2:
													builder.SetValue(0, ICMlEgEQw7n5HOyiNYGq(current2));
													num4 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
													{
														num4 = 8;
													}
													continue;
												case 1:
													UJLYPTEQ13HZHdiKall8(builder);
													num4 = 2;
													continue;
												case 7:
													goto end_IL_019e;
												}
												break;
											}
											goto IL_0165;
											IL_0165:
											current2 = enumerator2.Current;
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
											{
												num4 = 0;
											}
											goto IL_0137;
											continue;
											end_IL_019e:
											break;
										}
									}
									finally
									{
										int num5;
										if (enumerator2 == null)
										{
											num5 = 2;
											goto IL_026f;
										}
										goto IL_02a4;
										IL_026f:
										switch (num5)
										{
										case 2:
											goto end_IL_025a;
										case 1:
											goto end_IL_025a;
										}
										goto IL_02a4;
										IL_02a4:
										enumerator2.Dispose();
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num5 = 0;
										}
										goto IL_026f;
										end_IL_025a:;
									}
									goto IL_034f;
								case 4:
									UJLYPTEQ13HZHdiKall8(builder);
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
									{
										num3 = 7;
									}
									continue;
								default:
									builder.SetCellStyle(0, (IExcelStyle)PUMltOEQDxtA8UAGEORY(Jct9XiEQew538rQqxEdX(builder)));
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num3 = 6;
									}
									continue;
								case 5:
									break;
								case 7:
									UJLYPTEQ13HZHdiKall8(builder);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto IL_034f;
								case 1:
									enumerator2 = current.GetItems(metrics).GetEnumerator();
									num3 = 8;
									continue;
								case 6:
									builder.SetValues(d097wlEQt2PwNSUIgYfN(current));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									return;
								}
								break;
							}
							goto IL_031c;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num6 = 0;
							}
							goto IL_03e8;
						}
						goto IL_03fe;
						IL_03fe:
						UnZecxEQAXpI4il4sTxm(enumerator);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num6 = 0;
						}
						goto IL_03e8;
						IL_03e8:
						switch (num6)
						{
						default:
							goto end_IL_03c3;
						case 1:
							break;
						case 2:
							goto end_IL_03c3;
						case 0:
							goto end_IL_03c3;
						}
						goto IL_03fe;
						end_IL_03c3:;
					}
				case 13:
					list = new List<DateTimeRange>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
				{
					int[] array = new int[3];
					w1lNvkEQ2eoepOklYnXd(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					builder.SetColumnsWidths(array);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 12:
					builder.SetValues(yMSoRuEQOMy2jxBatbEZ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921453651)));
					num2 = 10;
					continue;
				default:
					builder.SetRowStyle((IExcelStyle)WHB9x5EQPmwJF4aG8qMo(Jct9XiEQew538rQqxEdX(builder)));
					num2 = 12;
					continue;
				case 10:
					UJLYPTEQ13HZHdiKall8(builder);
					num2 = 11;
					continue;
				case 7:
					return;
				case 3:
					list.Add(new DateTimeRange(IYhjAAEQpWuyWIl7yWso(metrics), DateTime.Now));
					num2 = 6;
					continue;
				case 2:
					break;
				case 9:
					enumerator = ((ComponentManager)TBD752EQatEUEJC9sfeW()).GetExtensionPoints<ICommonInformationPart>().GetEnumerator();
					num2 = 5;
					continue;
				case 6:
				case 14:
					builder.SetValues(yMSoRuEQOMy2jxBatbEZ(Wb38NaEQn7wkAn8k42e6(0xD3DEF7E ^ 0xD39D9AC)), string.Join((string)Wb38NaEQn7wkAn8k42e6(-1858887263 ^ -1858884189), list.Select(delegate(DateTimeRange p)
					{
						int num7 = 1;
						int num8 = num7;
						DateTime? from = default(DateTime?);
						DateTime value = default(DateTime);
						while (true)
						{
							switch (num8)
							{
							case 1:
								from = p.From;
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num8 = 0;
								}
								break;
							default:
								value = from.Value;
								num8 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num8 = 1;
								}
								break;
							case 2:
								return (string)_003C_003Ec.QoM6wo8R1DJ4jHjr8O1i(value.ToString((string)_003C_003Ec.p3qKqv8RPXOxZ5jxe9sj(0x4785BC0D ^ 0x47854B8D)), _003C_003Ec.p3qKqv8RPXOxZ5jxe9sj(0x53FA00CE ^ 0x53FAC368), p.To.Value.ToString((string)_003C_003Ec.p3qKqv8RPXOxZ5jxe9sj(-210725949 ^ -210738109)));
							}
						}
					})));
					num2 = 9;
					continue;
				}
				break;
			}
			list.AddRange(metrics.Periods);
			num = 4;
		}
	}

	internal static object Wb38NaEQn7wkAn8k42e6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yMSoRuEQOMy2jxBatbEZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool LidTPdEQTrqr4HeBsfNN()
	{
		return aBRGMMEQXfjp2Sk0MLWh == null;
	}

	internal static CommonStatisticsPage d85sL7EQkTqW4GcDbicF()
	{
		return aBRGMMEQXfjp2Sk0MLWh;
	}

	internal static void w1lNvkEQ2eoepOklYnXd(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static object Jct9XiEQew538rQqxEdX(object P_0)
	{
		return ((ExcelReportBuilder)P_0).Styles;
	}

	internal static object WHB9x5EQPmwJF4aG8qMo(object P_0)
	{
		return ((ExcelStylesheet)P_0).MainHeaderStyle;
	}

	internal static void UJLYPTEQ13HZHdiKall8(object P_0)
	{
		((ExcelReportBuilder)P_0).NextRow();
	}

	internal static object k1o4MeEQNyNCblxqBLdj()
	{
		return Environment.MachineName;
	}

	internal static bool PK1DjpEQ3PvGcIwNHhTG()
	{
		return DiagnosticsManager.Enabled;
	}

	internal static DateTime IYhjAAEQpWuyWIl7yWso(object P_0)
	{
		return ((MetricsContainer)P_0).StartTime;
	}

	internal static object TBD752EQatEUEJC9sfeW()
	{
		return ComponentManager.Current;
	}

	internal static object PUMltOEQDxtA8UAGEORY(object P_0)
	{
		return ((ExcelStylesheet)P_0).HeaderStyle;
	}

	internal static object d097wlEQt2PwNSUIgYfN(object P_0)
	{
		return ((ICommonInformationPart)P_0).Title;
	}

	internal static object ICMlEgEQw7n5HOyiNYGq(object P_0)
	{
		return ((CommonInformationPartItem)P_0).Name;
	}

	internal static object dSTJFfEQ4wZbTPvj3LvP(object P_0)
	{
		return ((CommonInformationPartItem)P_0).Value1;
	}

	internal static object LXf74IEQ6jgAeYvMwTPw(object P_0)
	{
		return ((CommonInformationPartItem)P_0).Value2;
	}

	internal static bool dLXAuuEQHMFGYjIP1RKI(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void UnZecxEQAXpI4il4sTxm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
