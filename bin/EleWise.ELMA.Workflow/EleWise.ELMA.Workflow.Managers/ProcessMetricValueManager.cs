using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.KPI.Common.Code;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ProcessMetricExtensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ProcessMetricValueManager : EntityManager<IProcessMetricValue, long>
{
	private static ProcessMetricValueManager nGYM28cQ93PPGXtdJGU;

	public IPeriodicityService periodicityService
	{
		[CompilerGenerated]
		get
		{
			return _003CperiodicityService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CperiodicityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IProcessMetricSaveValue> ProcessMetricSaveValuePoints { get; set; }

	public new static ProcessMetricValueManager Instance => Locator.GetServiceNotNull<ProcessMetricValueManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_017e, IL_01e6
		int num = 10;
		int num2 = num;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		IProcessMetricValueFilter processMetricValueFilter = default(IProcessMetricValueFilter);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 11:
			{
				object obj = xd2yE8cVaEqhUvHOB8D(criteria, Restrictions.IsNotNull((string)PBvwPkcUACSFLvIGQrT(-539998957 ^ -540012347)));
				object obj2 = PBvwPkcUACSFLvIGQrT(-539998957 ^ -540012347);
				dateTimeRange = tLiGKcck0cKLECOKXtW(processMetricValueFilter);
				dateTime = dateTimeRange.From;
				xd2yE8cVaEqhUvHOB8D(obj, UWCyHhcAG15FZWh5RHL(obj2, dateTime.Value));
				num2 = 20;
				break;
			}
			case 9:
				processMetricValueFilter = filter as IProcessMetricValueFilter;
				num2 = 12;
				break;
			case 14:
			case 21:
				if (d6He8NcGb3qHFfRsJf4(processMetricValueFilter) == null)
				{
					num2 = 2;
					break;
				}
				return;
			case 5:
				return;
			case 13:
				dateTimeRange = tLiGKcck0cKLECOKXtW(processMetricValueFilter);
				num2 = 4;
				break;
			case 4:
				dateTime = dateTimeRange.From;
				num2 = 3;
				break;
			case 19:
				dateTime = dateTimeRange.To;
				num2 = 15;
				break;
			case 7:
				dateTime = dateTimeRange.To;
				num2 = 8;
				break;
			case 3:
				if (!dateTime.HasValue)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 16;
			case 6:
				dateTimeRange = tLiGKcck0cKLECOKXtW(processMetricValueFilter);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				xd2yE8cVaEqhUvHOB8D(criteria, Restrictions.IsNull((string)PBvwPkcUACSFLvIGQrT(-420003255 ^ -420015025)));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 1;
				}
				break;
			case 20:
				dateTimeRange = tLiGKcck0cKLECOKXtW(processMetricValueFilter);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 19;
				}
				break;
			case 16:
				dateTimeRange = processMetricValueFilter.Period;
				num2 = 17;
				break;
			default:
			{
				object obj3 = xd2yE8cVaEqhUvHOB8D(criteria, Restrictions.IsNotNull((string)PBvwPkcUACSFLvIGQrT(0xDF4D1F8 ^ 0xDF48408)));
				string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108899260);
				dateTimeRange = tLiGKcck0cKLECOKXtW(processMetricValueFilter);
				dateTime = dateTimeRange.To;
				xd2yE8cVaEqhUvHOB8D(obj3, Restrictions.Le(text, (object)dateTime.Value));
				num2 = 14;
				break;
			}
			case 17:
				dateTime = dateTimeRange.From;
				num2 = 18;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 13;
				}
				break;
			case 1:
				return;
			case 12:
				if (processMetricValueFilter == null)
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 13;
				}
				break;
			case 10:
				ChV8GmcMTrwn3H7Xvsc(this, criteria, filter);
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				if (!dateTime.HasValue)
				{
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 21;
					}
					break;
				}
				goto case 16;
			case 18:
				if (dateTime.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 20;
			case 15:
				if (dateTime.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 14;
			}
		}
	}

	public void MetricSave(ProcessMetric processMetric, IUser executor, object value)
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
				MetricSave(processMetric, executor, value, luWDBoc7ZAuaCVQ1xgj());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void MetricSave(ProcessMetric processMetric, IUser executor, object value, DateTime date)
	{
		//Discarded unreachable code: IL_0144, IL_0153, IL_01a5, IL_02a5, IL_0345, IL_0370, IL_037f, IL_04a7, IL_04b6, IL_0524, IL_05c6, IL_06b7, IL_06e7, IL_06f6, IL_0702, IL_076a
		int num = 11;
		IProcessMetricValue processMetricValue = default(IProcessMetricValue);
		Guid? periodicityUid = default(Guid?);
		Pair<DateTime, DateTime> pair = default(Pair<DateTime, DateTime>);
		IPeriodicity periodicity = default(IPeriodicity);
		ICriteria val = default(ICriteria);
		IUser user = default(IUser);
		double result = default(double);
		IEnumerator<IProcessMetricSaveValue> enumerator = default(IEnumerator<IProcessMetricSaveValue>);
		IProcessMetricSaveValue current = default(IProcessMetricSaveValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					processMetricValue = InterfaceActivator.Create<IProcessMetricValue>();
					num2 = 24;
					continue;
				case 25:
					if (!periodicityUid.HasValue)
					{
						num2 = 43;
						continue;
					}
					goto case 36;
				case 27:
					pair = periodicityService.GetPeriod(periodicity, date);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 4;
					}
					continue;
				case 26:
					processMetricValue.PeriodStart = pair.First;
					num2 = 8;
					continue;
				case 40:
					xd2yE8cVaEqhUvHOB8D(val, v32V5ScIqF8GYFsfi4x(PBvwPkcUACSFLvIGQrT(0x361628FF ^ 0x36167EBB), executor.Id));
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 22;
					}
					continue;
				case 21:
					if (executor == null)
					{
						num2 = 33;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 40;
				case 42:
					YStTA8c1T9McHOgn7Ys(processMetricValue, user);
					num2 = 3;
					continue;
				case 8:
					processMetricValue.PeriodEnd = pair.Second;
					num2 = 23;
					continue;
				case 29:
					processMetricValue.Value = result;
					num2 = 31;
					continue;
				case 12:
				case 33:
					val.Add((ICriterion)FBVJdacaEUryEnkAgoJ(PBvwPkcUACSFLvIGQrT(-980570076 ^ -980556254)));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 37:
					user = (IUser)VB35IpceCw2Gc0aUkw5(am7EZbcrAbZkiFN0aMX(this));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 39;
					}
					continue;
				case 10:
					if (value == null)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
						{
							num2 = 14;
						}
						continue;
					}
					if (QsjMTGc2B5Hyo4BcEQH(processMetric))
					{
						num = 41;
						break;
					}
					goto case 5;
				case 19:
				case 31:
					Hk5mbxchJZMZ60jDF0B(processMetricValue);
					num2 = 7;
					continue;
				case 38:
					MJNZpfcxxOT9oPSyvJe(processMetricValue, sSZLJmcNjRZghkRTbO0(processMetric));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (pair == null)
					{
						num2 = 30;
						continue;
					}
					goto case 17;
				case 18:
				case 30:
					xd2yE8cVaEqhUvHOB8D(val, v32V5ScIqF8GYFsfi4x(PBvwPkcUACSFLvIGQrT(-11799394 ^ -11820354), processMetric.Uid));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 14;
					}
					continue;
				case 3:
					if (double.TryParse(value.ToString(), out result))
					{
						num2 = 29;
						continue;
					}
					goto case 15;
				default:
					xd2yE8cVaEqhUvHOB8D(val.Add((ICriterion)Q4yfrHcFGw9XMPHwOB7(PBvwPkcUACSFLvIGQrT(0x1AF6F1F2 ^ 0x1AF6A402))), NAf1T3ciCLM8nXcsrZI(PBvwPkcUACSFLvIGQrT(0x56F860D7 ^ 0x56F83527), pair.Second));
					num = 18;
					break;
				case 39:
					if (processMetricValue != null)
					{
						num2 = 37;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num2 = 44;
						}
						continue;
					}
					goto case 28;
				case 17:
					((ICriteria)xd2yE8cVaEqhUvHOB8D(val, Q4yfrHcFGw9XMPHwOB7(PBvwPkcUACSFLvIGQrT(0x3C1FFB55 ^ 0x3C1FAE83)))).Add((ICriterion)(object)Restrictions.Ge((string)PBvwPkcUACSFLvIGQrT(0x4943E3E4 ^ 0x4943B632), (object)pair.First));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (pair == null)
					{
						num2 = 34;
						continue;
					}
					goto case 26;
				case 20:
				case 44:
					processMetricValue.ChangeDate = luWDBoc7ZAuaCVQ1xgj();
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 42;
					}
					continue;
				case 9:
					if (periodicity == null)
					{
						num2 = 6;
						continue;
					}
					goto case 27;
				case 35:
					processMetricValue.CreationAuthor = user;
					num2 = 38;
					continue;
				case 11:
					pair = null;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 10;
					}
					continue;
				case 16:
					return;
				case 32:
					processMetricValue.Value = TimeSpanToDouble.Convert((TimeSpan)value);
					num2 = 19;
					continue;
				case 14:
					return;
				case 15:
					if (value is TimeSpan)
					{
						num2 = 32;
						continue;
					}
					goto case 19;
				case 36:
				{
					IPeriodicityService obj = periodicityService;
					periodicityUid = processMetric.PeriodicityUid;
					periodicity = obj.Load(periodicityUid.Value);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 9;
					}
					continue;
				}
				case 23:
				case 34:
					MJ46xqcSt9gG0EeBm7y(processMetricValue, executor);
					num2 = 20;
					continue;
				case 7:
					enumerator = ProcessMetricSaveValuePoints.GetEnumerator();
					num2 = 13;
					continue;
				case 13:
					try
					{
						while (true)
						{
							int num3;
							if (!BbvCXaczUpFtrFlGl3f(enumerator))
							{
								num3 = 4;
								goto IL_05d4;
							}
							goto IL_0626;
							IL_05d4:
							while (true)
							{
								switch (num3)
								{
								case 4:
									return;
								case 1:
									if (VKgdwIcEOgWp1HUSvs7(processMetricValue) != null)
									{
										int num4 = 3;
										num3 = num4;
										continue;
									}
									goto default;
								case 2:
									break;
								case 5:
									goto IL_0626;
								default:
									NTKQj8c4qBlqem0KFtE(current, processMetric, processMetricValue);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									sof4xZcw3guoCoFgNbm(current, processMetric, processMetricValue);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							continue;
							IL_0626:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
							{
								num3 = 1;
							}
							goto IL_05d4;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
							{
								num5 = 0;
							}
							goto IL_06bb;
						}
						goto IL_06d1;
						IL_06d1:
						M50QbTPKUer2IA2ayoC(enumerator);
						num5 = 2;
						goto IL_06bb;
						IL_06bb:
						switch (num5)
						{
						case 1:
							goto end_IL_0696;
						case 2:
							goto end_IL_0696;
						}
						goto IL_06d1;
						end_IL_0696:;
					}
				case 41:
					periodicityUid = processMetric.PeriodicityUid;
					num2 = 25;
					continue;
				case 4:
				case 22:
					processMetricValue = val.SetMaxResults(1).List<IProcessMetricValue>().FirstOrDefault();
					num2 = 37;
					continue;
				case 24:
					processMetricValue.CreationDate = luWDBoc7ZAuaCVQ1xgj();
					num2 = 35;
					continue;
				case 5:
				case 6:
				case 43:
					val = (ICriteria)XV7ktocoviu71mZ6AGu(this, null);
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	public IEnumerable<IProcessMetricValue> GetMetricValues(ProcessMetric processMetric, int periodCount = 0, IWorkflowProcess publishedProcess = null)
	{
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		if (processMetric == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393913770));
		}
		Pair<DateTime, DateTime> pair = null;
		Pair<DateTime, DateTime> pair2 = null;
		if (processMetric.UsePeriodicity && processMetric.PeriodicityUid.HasValue && processMetric.PeriodicityUid != Guid.Empty)
		{
			IPeriodicity periodicity = periodicityService.Load(processMetric.PeriodicityUid.Value);
			if (periodicity != null)
			{
				pair = periodicityService.GetPeriod(periodicity, DateTime.Now);
				pair2 = pair;
				for (int i = 0; i < periodCount; i++)
				{
					pair2 = periodicityService.GetPrevPeriod(periodicity, pair2);
				}
			}
		}
		ICriteria val = CreateCriteria();
		if (pair != null)
		{
			if (periodCount != 0)
			{
				val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106507261))).Add((ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716470253), (object)(pair2?.First ?? pair.First)));
				val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25696742))).Add((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539499079), (object)pair.Second.AddDays(1.0).AddSeconds(-1.0)));
			}
			else
			{
				val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F805A8D))).Add((ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF40582E), (object)pair.First));
				val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361023471))).Add((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057710921), (object)pair.Second));
			}
		}
		val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F80597B), (object)processMetric.Uid));
		val.AddOrder(new Order(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D522D2), true));
		IList<IProcessMetricValue> list = val.List<IProcessMetricValue>();
		if (!list.Any() && publishedProcess != null)
		{
			object propertyValue = publishedProcess.MetricValues.GetPropertyValue(processMetric.Uid);
			if (propertyValue != null && double.TryParse(propertyValue.ToString(), out var result))
			{
				InstanceOf<IProcessMetricValue> instanceOf = new InstanceOf<IProcessMetricValue>();
				instanceOf.New.Value = result;
				instanceOf.New.PeriodStart = pair.First;
				instanceOf.New.PeriodEnd = pair.Second;
				instanceOf.New.Responsible = null;
				instanceOf.New.ProcessMetricUid = processMetric.Uid;
				IProcessMetricValue @new = instanceOf.New;
				list.Add(@new);
			}
		}
		return list;
	}

	[PublicApiMember]
	public ProcessMetric GetMetricByName(IWorkflowProcess process, string metricName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((IEnumerable)((EntityMetadata)e6dGWUPOQ6ZPXReyfUA(process)).EntityProperties).Cast<ProcessMetric>().FirstOrDefault(_003C_003Ec__DisplayClass14_._003CGetMetricByName_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass14_.metricName = metricName;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void SetMetricValue(ProcessMetric processMetric, double? value)
	{
		Instance.MetricSave(processMetric, null, value);
	}

	[PublicApiMember]
	public void SetMetricValue(ProcessMetric processMetric, TimeSpan value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				hioOHfPvHvH9hytv8Qc(YkcHJePZXschM3N8O92(), processMetric, null, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	public void SetMetricValue(ProcessMetric processMetric, TimeSpan value, DateTime period, IUser executor)
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
				slZ3nXPYCS1DDWCNDPt(YkcHJePZXschM3N8O92(), processMetric, executor, value, period);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void SetMetricValue(ProcessMetric processMetric, double? value, DateTime period, IUser executor)
	{
		Instance.MetricSave(processMetric, executor, value, period);
	}

	[PublicApiMember]
	public void IncrementMetricValue(ProcessMetric processMetric, double? value, DateTime period, IUser executor)
	{
		ICriteria val = CreateCriteria();
		val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC65FDE), (object)processMetric.Uid));
		if (executor != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122766053), (object)executor.Id));
		}
		else
		{
			val.Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712506551)));
		}
		if (!value.HasValue)
		{
			value = 1.0;
		}
		IProcessMetricValue processMetricValue = val.SetMaxResults(1).List<IProcessMetricValue>().FirstOrDefault();
		if (processMetricValue != null)
		{
			value += processMetricValue.Value;
		}
		Instance.MetricSave(processMetric, executor, value, period);
	}

	[PublicApiMember]
	public void IncrementMetricValue(ProcessMetric processMetric, TimeSpan value, DateTime period, IUser executor)
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
				((ProcessMetricValueManager)YkcHJePZXschM3N8O92()).IncrementMetricValue(processMetric, TimeSpanToDouble.Convert(value), period, executor);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void IncrementMetricValue(ProcessMetric processMetric, double? value)
	{
		Instance.IncrementMetricValue(processMetric, value, DateTime.Now, null);
	}

	[PublicApiMember]
	public void IncrementMetricValue(ProcessMetric processMetric, TimeSpan value)
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
				((ProcessMetricValueManager)YkcHJePZXschM3N8O92()).IncrementMetricValue(processMetric, TimeSpanToDouble.Convert(value), luWDBoc7ZAuaCVQ1xgj(), (IUser)null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public double? GetMetricValueDouble(ProcessMetric processMetric, DateTime period, IUser executor)
	{
		Pair<DateTime, DateTime> pair = null;
		if (processMetric.UsePeriodicity && processMetric.PeriodicityUid.HasValue)
		{
			IPeriodicity periodicity = periodicityService.Load(processMetric.PeriodicityUid.Value);
			if (periodicity != null)
			{
				pair = periodicityService.GetPeriod(periodicity, period);
			}
		}
		ICriteria val = CreateCriteria();
		if (pair != null)
		{
			val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130118400))).Add((ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7381A4BD), (object)pair.First));
			val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC8877))).Add((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4943B614), (object)pair.Second));
		}
		val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F836F7), (object)processMetric.Uid));
		if (executor != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772636386), (object)executor.Id));
		}
		else
		{
			val.Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965272757)));
		}
		return val.SetMaxResults(1).List<IProcessMetricValue>().FirstOrDefault()?.Value;
	}

	[PublicApiMember]
	public TimeSpan GetMetricValueTimeSpan(ProcessMetric processMetric, DateTime period, IUser executor)
	{
		int num = 1;
		int num2 = num;
		double? metricValueDouble = default(double?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return new TimeSpan(0, 0, 0);
			case 1:
				metricValueDouble = ((ProcessMetricValueManager)YkcHJePZXschM3N8O92()).GetMetricValueDouble(processMetric, period, executor);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (metricValueDouble.HasValue)
			{
				return DoubleToTimeSpan.Convert(metricValueDouble.Value);
			}
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
			{
				num2 = 2;
			}
		}
	}

	public ProcessMetricValueManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zIbQ5nP8g1PXhRGMY9a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bmabOkcpAxmAxGXjRlw()
	{
		return nGYM28cQ93PPGXtdJGU == null;
	}

	internal static ProcessMetricValueManager G4ZZEscCUuW2Pdm7RS5()
	{
		return nGYM28cQ93PPGXtdJGU;
	}

	internal static void ChV8GmcMTrwn3H7Xvsc(object P_0, object P_1, object P_2)
	{
		((EntityManager<IProcessMetricValue, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static DateTimeRange tLiGKcck0cKLECOKXtW(object P_0)
	{
		return ((IProcessMetricValueFilter)P_0).Period;
	}

	internal static object PBvwPkcUACSFLvIGQrT(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xd2yE8cVaEqhUvHOB8D(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object UWCyHhcAG15FZWh5RHL(object P_0, object P_1)
	{
		return Restrictions.Ge((string)P_0, P_1);
	}

	internal static object d6He8NcGb3qHFfRsJf4(object P_0)
	{
		return ((IProcessMetricValueFilter)P_0).Responsible;
	}

	internal static DateTime luWDBoc7ZAuaCVQ1xgj()
	{
		return DateTime.Now;
	}

	internal static bool QsjMTGc2B5Hyo4BcEQH(object P_0)
	{
		return ((ProcessMetric)P_0).UsePeriodicity;
	}

	internal static object XV7ktocoviu71mZ6AGu(object P_0, object P_1)
	{
		return ((EntityManager<IProcessMetricValue, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object Q4yfrHcFGw9XMPHwOB7(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static object NAf1T3ciCLM8nXcsrZI(object P_0, object P_1)
	{
		return Restrictions.Le((string)P_0, P_1);
	}

	internal static object v32V5ScIqF8GYFsfi4x(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object FBVJdacaEUryEnkAgoJ(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object am7EZbcrAbZkiFN0aMX(object P_0)
	{
		return ((EntityManager<IProcessMetricValue, long>)P_0).AuthenticationService;
	}

	internal static object VB35IpceCw2Gc0aUkw5(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static Guid sSZLJmcNjRZghkRTbO0(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void MJNZpfcxxOT9oPSyvJe(object P_0, Guid value)
	{
		((IProcessMetricValue)P_0).ProcessMetricUid = value;
	}

	internal static void MJ46xqcSt9gG0EeBm7y(object P_0, object P_1)
	{
		((IProcessMetricValue)P_0).Responsible = (IUser)P_1;
	}

	internal static void YStTA8c1T9McHOgn7Ys(object P_0, object P_1)
	{
		((IProcessMetricValue)P_0).ChangeAuthor = (IUser)P_1;
	}

	internal static void Hk5mbxchJZMZ60jDF0B(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object VKgdwIcEOgWp1HUSvs7(object P_0)
	{
		return ((IProcessMetricValue)P_0).Responsible;
	}

	internal static void sof4xZcw3guoCoFgNbm(object P_0, object P_1, object P_2)
	{
		((IProcessMetricSaveValue)P_0).PersonalSynchronize((ProcessMetric)P_1, (IProcessMetricValue)P_2);
	}

	internal static void NTKQj8c4qBlqem0KFtE(object P_0, object P_1, object P_2)
	{
		((IProcessMetricSaveValue)P_0).Synchronize((ProcessMetric)P_1, (IProcessMetricValue)P_2);
	}

	internal static bool BbvCXaczUpFtrFlGl3f(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void M50QbTPKUer2IA2ayoC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object e6dGWUPOQ6ZPXReyfUA(object P_0)
	{
		return ((IWorkflowProcess)P_0).ProcessMetrics;
	}

	internal static object YkcHJePZXschM3N8O92()
	{
		return Instance;
	}

	internal static void hioOHfPvHvH9hytv8Qc(object P_0, object P_1, object P_2, object P_3)
	{
		((ProcessMetricValueManager)P_0).MetricSave((ProcessMetric)P_1, (IUser)P_2, P_3);
	}

	internal static void slZ3nXPYCS1DDWCNDPt(object P_0, object P_1, object P_2, object P_3, DateTime date)
	{
		((ProcessMetricValueManager)P_0).MetricSave((ProcessMetric)P_1, (IUser)P_2, P_3, date);
	}

	internal static void zIbQ5nP8g1PXhRGMY9a()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
