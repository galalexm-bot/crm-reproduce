using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class SqlQueryCallMetricAggregator : BaseMetricAggregator<SqlQueryInfo>
{
	private static SqlQueryCallMetricAggregator hxubH0EVJnUBbHhZen6B;

	public SqlQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(SqlQueryInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_0092, IL_0121, IL_0161, IL_0170, IL_017c, IL_018b
		int num = 2;
		int num2 = num;
		SqlQueryMetric orAdd = default(SqlQueryMetric);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				orAdd = container.GetOrAdd<SqlQueryMetric>().GetOrAdd(callInfo.Description);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 3;
				break;
			case 0:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!SxGlG9EVlENWxMxKEoUU(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num3 = 1;
							}
							goto IL_0096;
						}
						goto IL_00d2;
						IL_00d2:
						enumerator.Current.Process(callInfo, orAdd);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num3 = 0;
						}
						goto IL_0096;
						IL_0096:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							goto IL_00d2;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num4 = 0;
						}
						goto IL_0125;
					}
					goto IL_013b;
					IL_013b:
					K8VBrBEVrh5RlvZi75qE(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num4 = 1;
					}
					goto IL_0125;
					IL_0125:
					switch (num4)
					{
					default:
						goto end_IL_0100;
					case 2:
						break;
					case 0:
						goto end_IL_0100;
					case 1:
						goto end_IL_0100;
					}
					goto IL_013b;
					end_IL_0100:;
				}
			}
		}
	}

	internal static bool SxGlG9EVlENWxMxKEoUU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void K8VBrBEVrh5RlvZi75qE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool HamHVWEV9fJpZAsQ3MQJ()
	{
		return hxubH0EVJnUBbHhZen6B == null;
	}

	internal static SqlQueryCallMetricAggregator huFrsUEVdIpFTWBVUmwj()
	{
		return hxubH0EVJnUBbHhZen6B;
	}
}
