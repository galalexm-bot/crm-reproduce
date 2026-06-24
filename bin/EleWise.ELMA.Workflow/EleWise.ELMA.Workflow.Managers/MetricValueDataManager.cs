using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.KPI.Common.Code;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Scales;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MetricValueDataManager : EntityManager<IMetricValueData, long>
{
	private class MetricValueInfo
	{
		internal static object nQ7HiaZQXTNIsaYEnAOt;

		public long MetricId
		{
			[CompilerGenerated]
			get
			{
				return _003CMetricId_003Ek__BackingField;
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
						_003CMetricId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public DateTime MetricTime
		{
			[CompilerGenerated]
			get
			{
				return _003CMetricTime_003Ek__BackingField;
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
						_003CMetricTime_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long WorkflowInstanceId
		{
			[CompilerGenerated]
			get
			{
				return _003CWorkflowInstanceId_003Ek__BackingField;
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
					case 1:
						_003CWorkflowInstanceId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool HasWarnMetric
		{
			[CompilerGenerated]
			get
			{
				return _003CHasWarnMetric_003Ek__BackingField;
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
						_003CHasWarnMetric_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool HasProblemMetric
		{
			[CompilerGenerated]
			get
			{
				return _003CHasProblemMetric_003Ek__BackingField;
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
					case 1:
						_003CHasProblemMetric_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ScaleStatus CurrentStatus
		{
			[CompilerGenerated]
			get
			{
				return _003CCurrentStatus_003Ek__BackingField;
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
						_003CCurrentStatus_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public MetricValueInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			iHPQ4hZQDLYKcQIxBqNP();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool zDritkZQdsdCmYVGr0Gx()
		{
			return nQ7HiaZQXTNIsaYEnAOt == null;
		}

		internal static MetricValueInfo qyBjbCZQuyn1g9Eu0LCp()
		{
			return (MetricValueInfo)nQ7HiaZQXTNIsaYEnAOt;
		}

		internal static void iHPQ4hZQDLYKcQIxBqNP()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private string selectQuery;

	internal static MetricValueDataManager mSWnYODinPr6BT8d2L4;

	public new static MetricValueDataManager Instance => Locator.GetServiceNotNull<MetricValueDataManager>();

	public IProductionCalendarService WorkCalendarService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkCalendarService_003Ek__BackingField;
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
					_003CWorkCalendarService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void CheckCriticalTimeMetric()
	{
		//Discarded unreachable code: IL_0042, IL_004c, IL_019e, IL_01bd, IL_01ed
		int num = 1;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		MetricValueInfo metricValueInfo = default(MetricValueInfo);
		Dictionary<long, ProcessInstanceMetric> dictionary = default(Dictionary<long, ProcessInstanceMetric>);
		List<MetricValueInfo> list = default(List<MetricValueInfo>);
		string sql = default(string);
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!Uwch9sDwrYUPB3l1Eo8(dataReader))
						{
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
							{
								num3 = 2;
							}
							goto IL_0050;
						}
						goto IL_00e5;
						IL_00e5:
						MetricValueInfo obj = new MetricValueInfo
						{
							MetricTime = (DateTime)OkFiUTDeuQVcJWHtplV(dataReader, 0)
						};
						mfpfrSDxomwAvLboJ5R(obj, U2XudFDNa6jAHXQYKLG(dataReader[1]));
						wXiUFPD1sJWqOgUOM2a(obj, fOdwZZDSmsP0v4YLM9G(OkFiUTDeuQVcJWHtplV(dataReader, 2)));
						obj.HasProblemMetric = fOdwZZDSmsP0v4YLM9G(dataReader[3]);
						nowiZrDhir3RwjoQxoK(obj, U2XudFDNa6jAHXQYKLG(OkFiUTDeuQVcJWHtplV(dataReader, 4)));
						metricValueInfo = obj;
						num3 = 4;
						goto IL_0050;
						IL_0050:
						while (true)
						{
							switch (num3)
							{
							case 1:
								dictionary[DMsXZVDE8N9dYNgKYyj(metricValueInfo)] = GetScale(dataReader);
								num3 = 3;
								continue;
							case 3:
								break;
							default:
								if (!dictionary.ContainsKey(DMsXZVDE8N9dYNgKYyj(metricValueInfo)))
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 5:
								goto IL_00e5;
							case 4:
								list.Add(metricValueInfo);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto end_IL_0092;
							}
							break;
						}
						continue;
						end_IL_0092:
						break;
					}
				}
				finally
				{
					int num4;
					if (dataReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num4 = 0;
						}
						goto IL_01a2;
					}
					goto IL_01cb;
					IL_01cb:
					z4JiTUD4UvAp2lUM4JT(dataReader);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num4 = 1;
					}
					goto IL_01a2;
					IL_01a2:
					switch (num4)
					{
					default:
						goto end_IL_017d;
					case 0:
						goto end_IL_017d;
					case 2:
						break;
					case 1:
						goto end_IL_017d;
					}
					goto IL_01cb;
					end_IL_017d:;
				}
				break;
			case 1:
				sql = GetSelectQuery();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				paramValues = new Dictionary<string, object> { [(string)tF3wI0DrHVcDSd06dP8(0x2ACCDD87 ^ 0x2ACC5821)] = true };
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 5;
				}
				continue;
			case 5:
				dataReader = TransformationProvider.ExecuteQuery(sql, paramValues);
				num2 = 6;
				continue;
			case 2:
				list = new List<MetricValueInfo>();
				num2 = 5;
				continue;
			case 7:
				dictionary = new Dictionary<long, ProcessInstanceMetric>();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return;
			case 4:
				break;
			}
			RecountMetrics(list, dictionary);
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
			{
				num2 = 3;
			}
		}
	}

	private void RecountMetrics(ICollection<MetricValueInfo> metricValues, IDictionary<long, ProcessInstanceMetric> scaleDict)
	{
		List<long> list = new List<long>();
		List<long> list2 = new List<long>();
		List<long> list3 = new List<long>();
		List<long> list4 = new List<long>();
		List<long> list5 = new List<long>();
		List<long> list6 = new List<long>();
		foreach (MetricValueInfo metricValue in metricValues)
		{
			ProcessInstanceMetric processInstanceMetric = scaleDict[metricValue.MetricId];
			IIndicatorScale scale = processInstanceMetric.GetScale();
			TimeSpan value = DateTime.Now - metricValue.MetricTime;
			metricValue.CurrentStatus = scale.GetStatus(processInstanceMetric, TimeSpanToDouble.Convert(value));
		}
		foreach (IGrouping<long, MetricValueInfo> item in from m in metricValues
			group m by _003C_003Ec.kyV9JFZQ9MkbsqEXDyvO(m))
		{
			long key = item.Key;
			MetricValueInfo metricValueInfo = item.FirstOrDefault((MetricValueInfo metric) => metric.HasProblemMetric);
			MetricValueInfo metricValueInfo2 = item.FirstOrDefault((MetricValueInfo metric) => metric.CurrentStatus == ScaleStatus.Critical);
			ChangeStatus(key, metricValueInfo, metricValueInfo2, list2, list5);
			MetricValueInfo metricValueInfo3 = item.FirstOrDefault((MetricValueInfo metric) => _003C_003Ec.JBcWyyZQWm48vgvY3DCB(metric));
			MetricValueInfo metricValueInfo4 = item.FirstOrDefault((MetricValueInfo metric) => _003C_003Ec.DtK2RBZQjtDciE82phqf(metric) == ScaleStatus.Normal);
			ChangeStatus(key, metricValueInfo3, metricValueInfo4, list, list4);
			bool flag = metricValueInfo == null && metricValueInfo3 == null;
			bool flag2 = metricValueInfo2 == null && metricValueInfo4 == null;
			if (flag && !flag2)
			{
				list6.Add(key);
			}
			else if (!flag && flag2)
			{
				list3.Add(key);
			}
		}
		if (list.Count > 0)
		{
			string fieldName = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801776751));
			UpdateStatuses(fieldName, list, flagValue: true);
		}
		if (list2.Count > 0)
		{
			string fieldName2 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763633707));
			UpdateStatuses(fieldName2, list2, flagValue: true);
		}
		if (list3.Count > 0)
		{
			string fieldName3 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657550373));
			UpdateStatuses(fieldName3, list3, flagValue: true);
		}
		if (list4.Count > 0)
		{
			string fieldName4 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684244046));
			UpdateStatuses(fieldName4, list4, flagValue: false);
		}
		if (list5.Count > 0)
		{
			string fieldName5 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712461163));
			UpdateStatuses(fieldName5, list5, flagValue: false);
		}
		if (list6.Count > 0)
		{
			string fieldName6 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6DFEBA));
			UpdateStatuses(fieldName6, list6, flagValue: false);
		}
	}

	private void ChangeStatus(long key, MetricValueInfo before, MetricValueInfo after, ICollection<long> activeList, ICollection<long> notActiveList)
	{
		if (before != null && after == null)
		{
			notActiveList.Add(key);
		}
		else if (before == null && after != null)
		{
			activeList.Add(key);
		}
	}

	private void UpdateStatuses(string fieldName, List<long> targetList, bool flagValue)
	{
		string text = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438A56E9));
		string text2 = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6B774));
		string format = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F6B262), text, fieldName, TransformationProvider.ParameterSeparator, text2);
		while (targetList.Count > 0)
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.parameters = new Dictionary<string, object> { [SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EB3F63)] = flagValue };
			string arg = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790207218), targetList.Take(100).Select(delegate(long idValue, int index)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CS_0024_003C_003E8__locals0.parameters[string.Concat(_003C_003Ec__DisplayClass14_0.IbwNX4ZQTGipo6fkjYFs(-720457373 ^ -720453927), index)] = idValue;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return (string)_003C_003Ec__DisplayClass14_0.nHJEe9ZQQBf233jQjof6(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.ParameterSeparator, _003C_003Ec__DisplayClass14_0.IbwNX4ZQTGipo6fkjYFs(-1542190822 ^ -1542191456), index);
					}
				}
			}));
			targetList.RemoveRange(0, Math.Min(100, targetList.Count));
			TransformationProvider.ExecuteNonQuery(string.Format(format, arg), CS_0024_003C_003E8__locals0.parameters);
		}
	}

	private ProcessInstanceMetric GetScale(IDataReader reader)
	{
		ProcessInstanceMetric obj = new ProcessInstanceMetric
		{
			ScaleUid = ((rroUtQDzXUfE3YgQ1FJ(reader, 5) != DBNull.Value) ? new Guid?(m16hainKoSZfepIIBJG(TransformationProvider.Dialect, rroUtQDzXUfE3YgQ1FJ(reader, 5))) : null)
		};
		EPEdkDnZeduTIPv7dZL(obj, (!SyvZh4nO1NmyeqGgim2(reader, 6)) ? ((ScaleValueType)Convert.ToInt32(rroUtQDzXUfE3YgQ1FJ(reader, 6))) : ScaleValueType.Value);
		obj.MinValueType = ((!reader.IsDBNull(7)) ? ((ScaleValueType)Convert.ToInt32(rroUtQDzXUfE3YgQ1FJ(reader, 7))) : ScaleValueType.Value);
		cNnFgDnYdYHcUFQlLLh(obj, (!SyvZh4nO1NmyeqGgim2(reader, 8)) ? ((ScaleValueType)T3y2pvnvjn0MukQUOt6(rroUtQDzXUfE3YgQ1FJ(reader, 8))) : ScaleValueType.Value);
		S19Qhun88Io0LA3Pnmx(obj, (!SyvZh4nO1NmyeqGgim2(reader, 9)) ? ((ScaleValueType)T3y2pvnvjn0MukQUOt6(rroUtQDzXUfE3YgQ1FJ(reader, 9))) : ScaleValueType.Value);
		xxU6MTnsMW1xpSnJiGM(obj, (!SyvZh4nO1NmyeqGgim2(reader, 10)) ? ((ScaleValueType)T3y2pvnvjn0MukQUOt6(rroUtQDzXUfE3YgQ1FJ(reader, 10))) : ScaleValueType.Value);
		jIA6ExnJJ9QryaCQUay(obj, (!SyvZh4nO1NmyeqGgim2(reader, 11)) ? ((ScaleValueType)Convert.ToInt32(reader.GetValue(11))) : ScaleValueType.Value);
		obj.PlanValue = GetDoubleValue(reader, 12);
		obj.MinCriticalValue = GetDoubleValue(reader, 13);
		obj.MinValue = GetDoubleValue(reader, 14);
		obj.MaxCriticalValue = GetDoubleValue(reader, 15);
		obj.MaxValue = GetDoubleValue(reader, 16);
		obj.MinNormalValue = GetDoubleValue(reader, 17);
		obj.MaxNormalValue = GetDoubleValue(reader, 18);
		return obj;
	}

	private double? GetDoubleValue(IDataReader reader, int index)
	{
		if (reader.IsDBNull(index))
		{
			return null;
		}
		return Convert.ToDouble(reader[index]);
	}

	private string GetSelectQuery()
	{
		//Discarded unreachable code: IL_0122
		int num = 18;
		string text27 = default(string);
		string text18 = default(string);
		string text11 = default(string);
		string text7 = default(string);
		string text29 = default(string);
		string text24 = default(string);
		string text21 = default(string);
		string text15 = default(string);
		string text9 = default(string);
		string text5 = default(string);
		string text = default(string);
		string text30 = default(string);
		string text28 = default(string);
		string text26 = default(string);
		string text25 = default(string);
		string text23 = default(string);
		string text22 = default(string);
		string text20 = default(string);
		string text19 = default(string);
		string text17 = default(string);
		string text16 = default(string);
		string text14 = default(string);
		string text13 = default(string);
		string text12 = default(string);
		string text10 = default(string);
		string text8 = default(string);
		string text6 = default(string);
		string text4 = default(string);
		string text3 = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					text27 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A6D68C));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					text18 = (string)lE4TtSny83ms5gVeqUQ(TransformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6DFD8A));
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					text11 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(-360662087 ^ -360645179));
					num2 = 10;
					continue;
				case 8:
					text7 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x10156DB));
					num2 = 3;
					continue;
				case 30:
					text29 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(-684210684 ^ -684241182));
					num2 = 11;
					continue;
				case 11:
					text24 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x5F800F5B ^ 0x5F808A81));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
				case 24:
					return selectQuery;
				case 12:
					text21 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2D4EA));
					num2 = 2;
					continue;
				case 6:
					text15 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111185613));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					text9 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x46EA3D1 ^ 0x46E249D));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
					{
						num2 = 13;
					}
					continue;
				case 19:
					text5 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(0x5F800F5B ^ 0x5F808861));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 5;
					}
					continue;
				case 15:
					text = TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6DF3F6));
					num2 = 33;
					continue;
				case 3:
					text30 = (string)lE4TtSny83ms5gVeqUQ(TransformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F7C10));
					num2 = 14;
					continue;
				case 4:
					text28 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x1843E01F ^ 0x18436849));
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 11;
					}
					continue;
				case 20:
					text26 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(0x438A0E43 ^ 0x438A88B3));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 21;
					}
					continue;
				case 25:
					break;
				case 28:
					text25 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638208058));
					num2 = 12;
					continue;
				case 16:
					text23 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45810405));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 32;
					}
					continue;
				case 32:
					text22 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430613173));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 22;
					}
					continue;
				case 26:
					text20 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x7381F16B ^ 0x7381B7ED));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					text19 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(-1539486135 ^ -1539455437));
					num2 = 9;
					continue;
				case 33:
					text17 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(-1712492721 ^ -1712461943));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 30;
					}
					continue;
				case 9:
					text16 = (string)lE4TtSny83ms5gVeqUQ(TransformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABCF99));
					num2 = 15;
					continue;
				case 27:
					text14 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712461357));
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					text13 = TransformationProvider.Dialect.QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(-2002063381 ^ -2002059269));
					num2 = 26;
					continue;
				case 2:
					text12 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x42311138 ^ 0x42319620));
					num2 = 19;
					continue;
				case 1:
					text10 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(-1712492721 ^ -1712461063));
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 25;
					}
					continue;
				case 31:
					text8 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), tF3wI0DrHVcDSd06dP8(0x5F800F5B ^ 0x5F8088D7));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 6;
					}
					continue;
				case 29:
					text6 = TransformationProvider.Dialect.QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(-961162596 ^ -961193252));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					text4 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA73BE8E));
					num2 = 31;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 8;
					}
					continue;
				case 21:
					text3 = ((Dialect)JMe1fqn0oIOEjBCsdVY(TransformationProvider)).QuoteIfNeeded((string)tF3wI0DrHVcDSd06dP8(-1303601216 ^ -1303591062));
					num2 = 28;
					continue;
				case 14:
					text2 = (string)lE4TtSny83ms5gVeqUQ(JMe1fqn0oIOEjBCsdVY(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438A865B));
					num2 = 29;
					continue;
				case 18:
					if (!XLElGdnljlmk9RGYZqK(selectQuery))
					{
						num2 = 17;
						continue;
					}
					goto case 27;
				}
				break;
			}
			selectQuery = (string)ksfCWHntDi2ScbtS3gJ(tF3wI0DrHVcDSd06dP8(-22348816 ^ -22383882), new object[31]
			{
				text14,
				text23,
				text10,
				text24,
				text20,
				text9,
				text4,
				text8,
				text15,
				text7,
				text30,
				text2,
				text6,
				text28,
				text19,
				text16,
				text,
				text17,
				text29,
				text18,
				text3,
				text25,
				text21,
				text26,
				text12,
				text5,
				text13,
				text22,
				text11,
				text27,
				BmY6NxnmKYsxHMcIFd0(TransformationProvider)
			});
			num = 24;
		}
	}

	public void Delete(IWorkflowInstance workflowInstance, Guid metricUid)
	{
		int num = 2;
		int num2 = num;
		IMetricValueDataFilter metricValueDataFilter = default(IMetricValueDataFilter);
		IMetricValueData metricValueData = default(IMetricValueData);
		while (true)
		{
			switch (num2)
			{
			case 1:
				B174kunbvTtL8XVoaTP(metricValueDataFilter, workflowInstance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				PcZHifn5uMfistq34xS(metricValueData);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				metricValueData = Instance.Find(metricValueDataFilter, FetchOptions.All).FirstOrDefault();
				num2 = 4;
				break;
			case 4:
				if (metricValueData != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			case 2:
				metricValueDataFilter = InterfaceActivator.Create<IMetricValueDataFilter>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				metricValueDataFilter.MetricUid = metricUid;
				num2 = 6;
				break;
			}
		}
	}

	public IMetricValueData Load(IWorkflowInstance workflowInstance, Guid metricUid)
	{
		int num = 2;
		int num2 = num;
		IMetricValueDataFilter metricValueDataFilter = default(IMetricValueDataFilter);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return ((AbstractNHEntityManager<IMetricValueData, long>)goORImng8bIgCanw7UM()).Find((IEntityFilter)metricValueDataFilter, (FetchOptions)eDxaE9nBuAfqmsQiUyT()).FirstOrDefault();
			case 2:
				metricValueDataFilter = InterfaceActivator.Create<IMetricValueDataFilter>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 1;
				}
				break;
			default:
				metricValueDataFilter.MetricUid = metricUid;
				num2 = 3;
				break;
			case 1:
				metricValueDataFilter.WorkflowInstance = workflowInstance;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void DeactivateMetricTime(IWorkflowInstance workflowInstance, Guid metricUid)
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 7;
		int num2 = num;
		IMetricValueData metricValueData = default(IMetricValueData);
		IMetricValueDataFilter metricValueDataFilter = default(IMetricValueDataFilter);
		DateTime? time = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 11:
				metricValueData = ((AbstractNHEntityManager<IMetricValueData, long>)goORImng8bIgCanw7UM()).Find((IEntityFilter)metricValueDataFilter, (FetchOptions)eDxaE9nBuAfqmsQiUyT()).FirstOrDefault();
				num2 = 5;
				break;
			case 8:
				return;
			default:
				time = metricValueData.Time;
				num2 = 9;
				break;
			case 1:
				wNOqcInc92YR3HsccGB(metricValueData, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				metricValueData.Save();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				metricValueDataFilter = InterfaceActivator.Create<IMetricValueDataFilter>();
				num2 = 6;
				break;
			case 5:
				if (metricValueData == null)
				{
					num2 = 8;
					break;
				}
				goto case 1;
			case 6:
				B174kunbvTtL8XVoaTP(metricValueDataFilter, workflowInstance);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 9:
				if (time.HasValue)
				{
					num2 = 10;
					break;
				}
				goto case 3;
			case 10:
			{
				IMetricValueData metricValueData2 = metricValueData;
				DateTime dateTime = j71yXtnPGpmU6Z35wDV(JMe1fqn0oIOEjBCsdVY(TransformationProvider));
				DateTime dateTime2 = ABon2JnXh6xRnyopdCm();
				time = metricValueData.Time;
				metricValueData2.Time = kVRoWwnudEk03xxMmAP(dateTime, TtceMBndw3kEONLN3Xq(dateTime2, time.Value));
				num2 = 3;
				break;
			}
			case 4:
				metricValueDataFilter.MetricUid = metricUid;
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num2 = 11;
				}
				break;
			}
		}
	}

	public DateTime? GetMetricTemporaryTimeValue(IWorkflowInstance workflowInstance, Guid metricUid)
	{
		IMetricValueData metricValueData = Load(workflowInstance, metricUid);
		if (metricValueData == null || !metricValueData.Time.HasValue)
		{
			return null;
		}
		double totalDays = (DateTime.Now - metricValueData.Time.Value).TotalDays;
		if (!metricValueData.Active && !(totalDays < 30.0))
		{
			DateTime now = DateTime.Now;
			TimeSpan? timeSpan = metricValueData.Time - TransformationProvider.Dialect.MinDateTime;
			return now - timeSpan;
		}
		return metricValueData.Time;
	}

	public void SetMetricTemporaryTimeValue(IWorkflowInstance workflowInstance, Guid metricUid, DateTime? value)
	{
		SetMetricTemporaryTimeValue(workflowInstance, metricUid, value, null, null);
	}

	public void SetMetricTemporaryTimeValue(IWorkflowInstance workflowInstance, Guid metricUid, DateTime? value, double? warningMinutes, double? criticalMinutes, bool useWorkCalendar = false)
	{
		IMetricValueData metricValueData = Load(workflowInstance, metricUid);
		if (metricValueData == null)
		{
			metricValueData = InterfaceActivator.Create<IMetricValueData>();
		}
		metricValueData.WorkflowInstance = workflowInstance;
		metricValueData.MetricUid = metricUid;
		metricValueData.Time = value;
		metricValueData.Active = true;
		if (value.HasValue)
		{
			if (warningMinutes.HasValue)
			{
				metricValueData.WarningTime = (useWorkCalendar ? WorkCalendarService.EvalTargetTime(value.Value, TimeSpan.FromMinutes(warningMinutes.Value)) : value.Value.AddMinutes(warningMinutes.Value));
			}
			if (criticalMinutes.HasValue)
			{
				metricValueData.CriticalTime = (useWorkCalendar ? WorkCalendarService.EvalTargetTime(value.Value, TimeSpan.FromMinutes(criticalMinutes.Value)) : value.Value.AddMinutes(criticalMinutes.Value));
			}
		}
		metricValueData.Save();
	}

	public MetricValueDataManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TnkSDPnDuuCHG9Lm2gY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zJNodODIcCal5NEbLIE()
	{
		return mSWnYODinPr6BT8d2L4 == null;
	}

	internal static MetricValueDataManager UO6qBNDamZhow5lBoDK()
	{
		return mSWnYODinPr6BT8d2L4;
	}

	internal static object tF3wI0DrHVcDSd06dP8(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OkFiUTDeuQVcJWHtplV(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static long U2XudFDNa6jAHXQYKLG(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void mfpfrSDxomwAvLboJ5R(object P_0, long value)
	{
		((MetricValueInfo)P_0).WorkflowInstanceId = value;
	}

	internal static bool fOdwZZDSmsP0v4YLM9G(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	internal static void wXiUFPD1sJWqOgUOM2a(object P_0, bool value)
	{
		((MetricValueInfo)P_0).HasWarnMetric = value;
	}

	internal static void nowiZrDhir3RwjoQxoK(object P_0, long value)
	{
		((MetricValueInfo)P_0).MetricId = value;
	}

	internal static long DMsXZVDE8N9dYNgKYyj(object P_0)
	{
		return ((MetricValueInfo)P_0).MetricId;
	}

	internal static bool Uwch9sDwrYUPB3l1Eo8(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void z4JiTUD4UvAp2lUM4JT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object rroUtQDzXUfE3YgQ1FJ(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).GetValue(P_1);
	}

	internal static Guid m16hainKoSZfepIIBJG(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static bool SyvZh4nO1NmyeqGgim2(object P_0, int P_1)
	{
		return ((IDataRecord)P_0).IsDBNull(P_1);
	}

	internal static void EPEdkDnZeduTIPv7dZL(object P_0, ScaleValueType value)
	{
		((ProcessInstanceMetric)P_0).MinCriticalValueType = value;
	}

	internal static int T3y2pvnvjn0MukQUOt6(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static void cNnFgDnYdYHcUFQlLLh(object P_0, ScaleValueType value)
	{
		((ProcessInstanceMetric)P_0).MaxCriticalValueType = value;
	}

	internal static void S19Qhun88Io0LA3Pnmx(object P_0, ScaleValueType value)
	{
		((ProcessInstanceMetric)P_0).MaxValueType = value;
	}

	internal static void xxU6MTnsMW1xpSnJiGM(object P_0, ScaleValueType value)
	{
		((ProcessInstanceMetric)P_0).MinNormalValueType = value;
	}

	internal static void jIA6ExnJJ9QryaCQUay(object P_0, ScaleValueType value)
	{
		((ProcessInstanceMetric)P_0).MaxNormalValueType = value;
	}

	internal static bool XLElGdnljlmk9RGYZqK(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object JMe1fqn0oIOEjBCsdVY(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object lE4TtSny83ms5gVeqUQ(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object BmY6NxnmKYsxHMcIFd0(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object ksfCWHntDi2ScbtS3gJ(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void B174kunbvTtL8XVoaTP(object P_0, object P_1)
	{
		((IMetricValueDataFilter)P_0).WorkflowInstance = (IWorkflowInstance)P_1;
	}

	internal static void PcZHifn5uMfistq34xS(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object goORImng8bIgCanw7UM()
	{
		return Instance;
	}

	internal static object eDxaE9nBuAfqmsQiUyT()
	{
		return FetchOptions.All;
	}

	internal static void wNOqcInc92YR3HsccGB(object P_0, bool value)
	{
		((IMetricValueData)P_0).Active = value;
	}

	internal static DateTime j71yXtnPGpmU6Z35wDV(object P_0)
	{
		return ((Dialect)P_0).MinDateTime;
	}

	internal static DateTime ABon2JnXh6xRnyopdCm()
	{
		return DateTime.Now;
	}

	internal static TimeSpan TtceMBndw3kEONLN3Xq(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static DateTime kVRoWwnudEk03xxMmAP(DateTime P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static void TnkSDPnDuuCHG9Lm2gY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
