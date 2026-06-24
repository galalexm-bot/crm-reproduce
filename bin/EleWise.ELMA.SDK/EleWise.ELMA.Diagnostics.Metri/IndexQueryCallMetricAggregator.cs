using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class IndexQueryCallMetricAggregator : BaseMetricAggregator<IndexQueryInfo>
{
	internal static IndexQueryCallMetricAggregator I1erDDEVeOnMjhRdEbOb;

	public IndexQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(IndexQueryInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_00db, IL_0113, IL_0122
		int num = 3;
		int num2 = num;
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		IndexQueryMetric orAdd = default(IndexQueryMetric);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				orAdd = container.GetOrAdd<IndexQueryMetric>().GetOrAdd(callInfo.Description);
				num2 = 2;
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 2;
						}
						goto IL_0050;
					}
					goto IL_008c;
					IL_008c:
					JiFbSYEVNrVhHSr5Gnex(enumerator.Current, callInfo, orAdd);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num3 = 1;
					}
					goto IL_0050;
					IL_0050:
					switch (num3)
					{
					case 1:
						break;
					default:
						goto IL_008c;
					case 2:
						return;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							zDGmEYEV365Sx7LF0ZVh(enumerator);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	internal static void JiFbSYEVNrVhHSr5Gnex(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static void zDGmEYEV365Sx7LF0ZVh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool qQahXMEVPtwfTpMhCI4p()
	{
		return I1erDDEVeOnMjhRdEbOb == null;
	}

	internal static IndexQueryCallMetricAggregator URr9NSEV1lYpQu6kFoH3()
	{
		return I1erDDEVeOnMjhRdEbOb;
	}
}
